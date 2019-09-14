using argonaut_subscription_server_proxy.Models;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace argonaut_subscription_server_proxy.Managers
{
    public class WebsocketManager
    {
        #region Class Variables . . .

        /// <summary>The instance for singleton pattern.</summary>
        private static WebsocketManager _instance;

        #endregion Class Variables . . .

        #region Instance Variables . . .

        /// <summary>Dictionary of unique identifier informations.</summary>
        private Dictionary<Guid, WebsocketClientInformation> _guidInfoDict;

        private Dictionary<string, List<WebsocketClientInformation>> _subscriptionInfosDict;

        #endregion Instance Variables . . .

        #region Constructors . . .

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Constructor that prevents a default instance of this class from being created.</summary>
        ///
        /// <remarks>Gino Canessa, 9/13/2019.</remarks>
        ///-------------------------------------------------------------------------------------------------

        private WebsocketManager()
        {
            _guidInfoDict = new Dictionary<Guid, WebsocketClientInformation>();
            _subscriptionInfosDict = new Dictionary<string, List<WebsocketClientInformation>>();
        }
        #endregion Constructors . . .

        #region Class Interface . . .

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Initializes this object.</summary>
        ///
        /// <remarks>Gino Canessa, 9/13/2019.</remarks>
        ///-------------------------------------------------------------------------------------------------

        public static void Init()
        {
            // **** make an instance ****

            CheckOrCreateInstance();
        }

        public static void RegisterClient(WebsocketClientInformation client)
        {
            _instance._RegisterClient(client);
        }

        public static void UnregisterClient(Guid guid)
        {
            if (_instance._guidInfoDict.ContainsKey(guid))
            {
                _instance._guidInfoDict.Remove(guid);
            }
        }

        public static bool TryGetClient(Guid guid, out WebsocketClientInformation client)
        {
            // **** check for this client existing ****

            if (_instance._guidInfoDict.ContainsKey(guid))
            {
                // **** set our client object ****

                client = _instance._guidInfoDict[guid];

                // **** success ****

                return true;
            }

            // **** not found ****

            client = null;

            // **** failure ****

            return false;
        }

        public static bool AddSubscriptionToClient(string subscriptionId, Guid clientGuid)
        {
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

        public static void QueueMessagesForSubscription(
                                                        fhir.Subscription subscription,
                                                        Resource resource
                                                        )
        {
            if (!_instance._subscriptionInfosDict.ContainsKey(subscription.Id))
            {
                return;
            }

            // **** ****

            foreach (WebsocketClientInformation client in _instance._subscriptionInfosDict[subscription.Id])
            {
                string clientMessage = "";

                // **** determine the type of message this client wants ****

                switch (client.PayloadType)
                {
                    case WebsocketClientInformation.WebsocketPayloadTypes.EMPTY:
                    case WebsocketClientInformation.WebsocketPayloadTypes.FULL_RESOURCE:
                    case WebsocketClientInformation.WebsocketPayloadTypes.ID_ONLY:

                        // **** get a notification bundle ****

                        SubscriptionManager.BundleForSubscriptionNotification(subscription, resource, out Bundle bundle, out int eventCount);

                        // **** serialize using the Firely serialization engine ****

                        Hl7.Fhir.Serialization.FhirJsonSerializer serializer = new Hl7.Fhir.Serialization.FhirJsonSerializer();

                        // **** serialize our bundle as our message ****

                        clientMessage = serializer.SerializeToString(bundle);

                        break;

                    case WebsocketClientInformation.WebsocketPayloadTypes.R4:

                        // **** send a notification ****

                        clientMessage = $"ping {subscription.Id}";

                        break;
                }

                // **** add this message to this client's queue ****

                client.MessageQ.Enqueue(clientMessage);
            }
        }

        #endregion Class Interface . . .

        #region Instance Interface . . .

        private void _RegisterClient(WebsocketClientInformation client)
        {
            // **** add this client to our dictionary ****

            _guidInfoDict.Add(client.Uid, client);
        }

        #endregion Instance Interface . . .

        #region Internal Functions . . .

        private static void CheckOrCreateInstance()
        {
            if (_instance == null)
            {
                _instance = new WebsocketManager();
            }
        }
        #endregion Internal Functions . . .

    }
}
