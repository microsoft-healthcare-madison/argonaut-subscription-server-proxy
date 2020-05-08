// <copyright file="WebsocketManager.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir4;
extern alias fhir5;

using System;
using System.Collections.Generic;
using argonaut_subscription_server_proxy.Models;
using r4 = fhir4.Hl7.Fhir.Model;
using r4s = fhir4.Hl7.Fhir.Serialization;
using r5 = fhir5.Hl7.Fhir.Model;
using r5s = fhir5.Hl7.Fhir.Serialization;

namespace argonaut_subscription_server_proxy.Managers
{
    /// <summary>Manager for websockets.</summary>
    public class WebsocketManager
    {
        /// <summary>The instance for singleton pattern.</summary>
        private static WebsocketManager _instance;

        /// <summary>Dictionary of unique identifier informations.</summary>
        private Dictionary<Guid, WebsocketClientInformation> _guidInfoDict;

        private Dictionary<string, List<WebsocketClientInformation>> _subscriptionInfosDict;

        /// <summary>
        /// Prevents a default instance of the
        /// <see cref="WebsocketManager"/> class from being created.
        /// </summary>
        private WebsocketManager()
        {
            _guidInfoDict = new Dictionary<Guid, WebsocketClientInformation>();
            _subscriptionInfosDict = new Dictionary<string, List<WebsocketClientInformation>>();
        }

        /// <summary>Initializes this object.</summary>
        public static void Init()
        {
            // make an instance
            CheckOrCreateInstance();
        }

        /// <summary>Registers the client described by client.</summary>
        /// <param name="client">The client.</param>
        public static void RegisterClient(WebsocketClientInformation client)
        {
            if (client == null)
            {
                return;
            }

            // add this client to our dictionary
            if (!_instance._guidInfoDict.ContainsKey(client.Uid))
            {
                _instance._guidInfoDict.Add(client.Uid, client);
            }
        }

        /// <summary>Unregisters the client described by GUID.</summary>
        /// <param name="guid">Unique identifier.</param>
        public static void UnregisterClient(Guid guid)
        {
            if (guid == null)
            {
                return;
            }

            if (_instance._guidInfoDict.ContainsKey(guid))
            {
                _instance._guidInfoDict.Remove(guid);
            }
        }

        /// <summary>
        /// Attempts to get client a WebsocketClientInformation from the given GUID.
        /// </summary>
        /// <param name="guid">  Unique identifier.</param>
        /// <param name="client">[out] The client.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        public static bool TryGetClient(Guid guid, out WebsocketClientInformation client)
        {
            if (guid == null)
            {
                client = null;
                return false;
            }

            // check for this client existing
            if (_instance._guidInfoDict.ContainsKey(guid))
            {
                // set our client object
                client = _instance._guidInfoDict[guid];

                // success
                return true;
            }

            // not found
            client = null;

            // failure
            return false;
        }

        /// <summary>Adds a subscription to client to 'clientGuid'.</summary>
        /// <param name="subscriptionId">Identifier for the subscription.</param>
        /// <param name="clientGuid">    Unique identifier for the client.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        public static bool AddSubscriptionToClient(string subscriptionId, Guid clientGuid)
        {
            if (string.IsNullOrEmpty(subscriptionId) || (clientGuid == null))
            {
                return false;
            }

            if (!SubscriptionManager.Exists(subscriptionId))
            {
                return false;
            }

            if (!_instance._guidInfoDict.ContainsKey(clientGuid))
            {
                return false;
            }

            _instance._guidInfoDict[clientGuid].SubscriptionIdSet.Add(subscriptionId);

            if (!_instance._subscriptionInfosDict.ContainsKey(subscriptionId))
            {
                _instance._subscriptionInfosDict.Add(subscriptionId, new List<WebsocketClientInformation>());
            }

            _instance._subscriptionInfosDict[subscriptionId].Add(_instance._guidInfoDict[clientGuid]);
            return true;
        }

        /// <summary>Removes the subscription from client.</summary>
        /// <param name="subscriptionId">Identifier for the subscription.</param>
        /// <param name="clientGuid">    Unique identifier for the client.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        public static bool RemoveSubscriptionFromClient(string subscriptionId, Guid clientGuid)
        {
            if (string.IsNullOrEmpty(subscriptionId) || (clientGuid == null))
            {
                return false;
            }

            if (_instance._guidInfoDict[clientGuid].SubscriptionIdSet.Contains(subscriptionId))
            {
                _instance._guidInfoDict[clientGuid].SubscriptionIdSet.Remove(subscriptionId);
            }

            if (_instance._subscriptionInfosDict.ContainsKey(subscriptionId) &&
                _instance._subscriptionInfosDict[subscriptionId].Contains(_instance._guidInfoDict[clientGuid]))
            {
                _instance._subscriptionInfosDict[subscriptionId].Remove(_instance._guidInfoDict[clientGuid]);

                if (_instance._subscriptionInfosDict[subscriptionId].Count == 0)
                {
                    _instance._subscriptionInfosDict.Remove(subscriptionId);
                }
            }

            return true;
        }

        /// <summary>Queue messages for subscription.</summary>
        /// <param name="subscription">The subscription.</param>
        /// <param name="resource">    The resource.</param>
        public static void QueueMessagesForSubscription(
            r5.Subscription subscription,
            r5.Resource resource)
        {
            if (subscription == null)
            {
                return;
            }

            if (!_instance._subscriptionInfosDict.ContainsKey(subscription.Id))
            {
                return;
            }

            foreach (WebsocketClientInformation client in _instance._subscriptionInfosDict[subscription.Id])
            {
                string clientMessage = string.Empty;

                // determine the type of message this client wants
                switch (client.PayloadType)
                {
                    case WebsocketClientInformation.WebsocketPayloadTypes.Empty:
                    case WebsocketClientInformation.WebsocketPayloadTypes.FullResource:
                    case WebsocketClientInformation.WebsocketPayloadTypes.IdOnly:

                        // get a notification bundle
                        SubscriptionManager.BundleForSubscriptionNotification(
                            subscription,
                            resource,
                            out r5.Bundle bundle,
                            out long eventCount);

                        // serialize using the Firely serialization engine
                        r5s.FhirJsonSerializer serializer = new r5s.FhirJsonSerializer();

                        // serialize our bundle as our message
                        clientMessage = serializer.SerializeToString(bundle);

                        break;

                    case WebsocketClientInformation.WebsocketPayloadTypes.R4:

                        // send a notification
                        clientMessage = $"ping {subscription.Id}";

                        break;
                }

                // add this message to this client's queue
                client.MessageQ.Enqueue(clientMessage);
            }
        }

        /// <summary>Check or create instance.</summary>
        private static void CheckOrCreateInstance()
        {
            if (_instance == null)
            {
                _instance = new WebsocketManager();
            }
        }
    }
}
