﻿// <copyright file="SubscriptionManagerR5.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir5;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using argonaut_subscription_server_proxy.Backport;
using argonaut_subscription_server_proxy.Models;
using fhir5.Hl7.Fhir.Model;
using fhir5.Hl7.Fhir.Rest;
using fhir5.Hl7.Fhir.Serialization;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace argonaut_subscription_server_proxy.Managers
{
    /// <summary>Manager for subscriptions.</summary>
    public class SubscriptionManagerR5
    {
        /// <summary>The instance for singleton pattern.</summary>
        private static SubscriptionManagerR5 _instance;

        /// <summary>Dictionary of subscriptions, by ID.</summary>
        private Dictionary<string, Subscription> _idSubscriptionDict;

        /// <summary>Dictionary of identifier status.</summary>
        private Dictionary<string, long> _idEventCountDict;

        /// <summary>Dictionary of identifier locks.</summary>
        private Dictionary<string, object> _idLockDict;

        /// <summary>A random-number generator for this class.</summary>
        private Random _rand;

        private Dictionary<string, SubscriptionFilterNode> _resourceSubscriptionDict;
        private object _resourceSubscriptionDictLock;

        private HashSet<string> _supportedChannelTypes;

        private Queue<FhirClient> _clientQ;
        private object _clientQLock;

        private Thread _cleanUpThread;

        private CamelCasePropertyNamesContractResolver _contractResolver;

        private FhirJsonSerializer _fhirSerializer;
        private FhirJsonParser _fhirParser;

        /// <summary>
        /// Prevents a default instance of the
        /// <see cref="SubscriptionManagerR5"/> class from being created.
        /// </summary>
        private SubscriptionManagerR5()
        {
            // create our index objects
            _idSubscriptionDict = new Dictionary<string, Subscription>();
            _idEventCountDict = new Dictionary<string, long>();
            _idLockDict = new Dictionary<string, object>();
            _resourceSubscriptionDict = new Dictionary<string, SubscriptionFilterNode>();
            _resourceSubscriptionDictLock = new object();
            _rand = new Random();
            _supportedChannelTypes = new HashSet<string>()
            {
                "rest-hook",
                "websocket",
                "email",
            };

            _clientQ = new Queue<FhirClient>();
            _clientQLock = new object();

            // create our clean-up thread
            _cleanUpThread = new Thread(new ThreadStart(CleanUpThreadFunc));
            _cleanUpThread.IsBackground = true;
            _cleanUpThread.Start();


            // serialization related
            _contractResolver = new CamelCasePropertyNamesContractResolver();
            _fhirSerializer = new FhirJsonSerializer();
            _fhirParser = new FhirJsonParser();
        }

        /// <summary>Initializes this object.</summary>
        public static void Init()
        {
            // make an instance
            CheckOrCreateInstance();
        }

        /// <summary>Gets a list of all currently known Subscriptions.</summary>
        /// <returns>The Subscription list.</returns>
        public static List<Subscription> GetSubscriptionList()
        {
            // return our list of known subscriptions
            return _instance._idSubscriptionDict.Values.ToList<Subscription>();
        }

        /// <summary>Gets subscriptions bundle.</summary>
        /// <returns>The subscriptions bundle.</returns>
        public static Bundle GetSubscriptionsBundle()
        {
            return _instance._GetSubscriptionsBundle();
        }

        /// <summary>Handles a POST of a Subscription object.</summary>
        /// <param name="content">       The content.</param>
        /// <param name="subscription">  [out] The subscription.</param>
        /// <param name="statusCode">    [out] The status code.</param>
        /// <param name="failureContent">[out] The failure content.</param>
        public static void HandlePost(
            string content,
            out Subscription subscription,
            out HttpStatusCode statusCode,
            out string failureContent)
        {
            _instance._HandlePost(
                content,
                out subscription,
                out statusCode,
                out failureContent);
        }

        /// <summary>Handles the delete described by request.</summary>
        /// <param name="request">The request.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        public static bool HandleDelete(HttpRequest request)
        {
            if (request == null)
            {
                return false;
            }

            return _instance._HandleDelete(request);
        }

        /// <summary>Process the encounter described by content.</summary>
        /// <param name="content"> The content.</param>
        /// <param name="location">The location.</param>
        public static void ProcessEncounter(string content, Uri location)
        {
            _ = System.Threading.Tasks.Task.Run((Action)(() => _instance._ProcessEncounter(content, location)));
        }

        /// <summary>URL for subscription.</summary>
        /// <param name="subscriptionId">The subscription id.</param>
        /// <returns>A string.</returns>
        public static string UrlForSubscription(string subscriptionId)
        {
            return new Uri(
                new Uri(Program.Configuration["Server_Public_Url"], UriKind.Absolute),
                new Uri($"/r5/Subscription/{subscriptionId}", UriKind.Relative))
                .ToString();
        }

        /// <summary>Attempts to get subscription a Subscription from the given string.</summary>
        /// <param name="subscriptionId">The subscription id.</param>
        /// <param name="subscription">  [out] The subscription.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        public static bool TryGetSubscription(string subscriptionId, out Subscription subscription)
        {
            if (_instance._idSubscriptionDict.ContainsKey(subscriptionId))
            {
                subscription = _instance._idSubscriptionDict[subscriptionId];
                return true;
            }

            subscription = null;
            return false;
        }

        /// <summary>Attempts to get serialized subscription a string from the given string.</summary>
        /// <param name="subscriptionId">The subscription id.</param>
        /// <param name="serialized">    [out] The serialized.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        public static bool TryGetSerialized(string subscriptionId, out string serialized)
        {
            if (TryGetSubscription(subscriptionId, out Subscription subscription))
            {
                serialized = _instance._fhirSerializer.SerializeToString(subscription);

                return true;
            }

            serialized = null;
            return false;
        }

        /// <summary>Determine if 'subscriptionId' exists.</summary>
        /// <param name="subscriptionId">The subscription id.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        public static bool Exists(string subscriptionId)
        {
            if (string.IsNullOrEmpty(subscriptionId))
            {
                return false;
            }

            if (subscriptionId.StartsWith("Subscription/", StringComparison.Ordinal))
            {
                return _instance._idSubscriptionDict.ContainsKey(
                    subscriptionId.Replace("Subscription/", string.Empty, StringComparison.Ordinal));
            }

            return _instance._idSubscriptionDict.ContainsKey(subscriptionId);
        }

        /// <summary>Gets subscriptions bundle.</summary>
        /// <returns>The subscriptions bundle.</returns>
        private Bundle _GetSubscriptionsBundle()
        {
            Bundle bundle = new Bundle()
            {
                Type = Bundle.BundleType.Searchset,
                Total = _idSubscriptionDict.Count,
                Meta = new Meta()
                {
                    LastUpdated = new DateTimeOffset(DateTime.Now.ToUniversalTime()),
                },
                Entry = new List<Bundle.EntryComponent>(),
            };

            foreach (Subscription subscription in _idSubscriptionDict.Values)
            {
                bundle.Entry.Add(new Bundle.EntryComponent()
                {
                    FullUrl = Program.UrlForR5ResourceId("Subscription", subscription.Id),
                    Resource = (Resource)subscription,
                    Search = new Bundle.SearchComponent()
                    {
                        Mode = Bundle.SearchEntryMode.Match,
                    },
                });
            }

            // return our bundle
            return bundle;
        }

        /// <summary>Handles the delete described by request.</summary>
        /// <param name="request">The request.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        private bool _HandleDelete(HttpRequest request)
        {
            // pull the URL components out of the request
            string[] components = request.Path.ToUriComponent().Split('/');

            bool foundSubscriptionComponent = false;

            // traverse components
            for (int componentIndex = 0; componentIndex < components.Length; componentIndex++)
            {
                // grab this component
                string component = components[componentIndex];

                // make sure that we hit a 'Subscription' component
                if (component.Equals("subscription", StringComparison.OrdinalIgnoreCase))
                {
                    foundSubscriptionComponent = true;
                    continue;
                }

                // only look for a GUID AFTER we have the subscription part
                if (foundSubscriptionComponent)
                {
                    // attempt to parse
                    if (Guid.TryParse(component, out _))
                    {
                        // remove this entry
                        return Remove(component);
                    }
                }
            }

            // still here is failure
            return false;
        }

        /// <summary>Removes the subscription from node tree.</summary>
        /// <param name="subscription">The subscription.</param>
        /// <param name="node">        The node.</param>
        /// <param name="isEmpty">     [out] True if is empty, false if not.</param>
        private void RemoveSubscriptionFromNodeTree(
            Subscription subscription,
            SubscriptionFilterNode node,
            out bool isEmpty)
        {
            isEmpty = false;

            lock (_resourceSubscriptionDictLock)
            {
                if (node.Subscriptions.Contains(subscription))
                {
                    node.Subscriptions.Remove(subscription);
                }
            }

            string[] inclusionKeys = node.Inclusions.Keys.ToArray<string>();
            foreach (string key in inclusionKeys)
            {
                // recurse
                RemoveSubscriptionFromNodeTree(subscription, node.Inclusions[key], out bool subIsEmpty);

                if (subIsEmpty)
                {
                    // remove this node
                    lock (_resourceSubscriptionDictLock)
                    {
                        node.Inclusions.Remove(key);
                    }
                }
            }

            string[] exclusionKeys = node.Exclusions.Keys.ToArray<string>();
            foreach (string key in exclusionKeys)
            {
                // recurse
                RemoveSubscriptionFromNodeTree(subscription, node.Exclusions[key], out bool subIsEmpty);

                if (subIsEmpty)
                {
                    // remove this node
                    lock (_resourceSubscriptionDictLock)
                    {
                        node.Exclusions.Remove(key);
                    }
                }
            }

            if ((node.Subscriptions.Count == 0) &&
                (node.Inclusions.Count == 0) &&
                (node.Exclusions.Count == 0))
            {
                isEmpty = true;
            }
        }

        /// <summary>Removes the subscription specified by ID.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        private bool Remove(string id)
        {
            if (string.IsNullOrEmpty(id) || (!_idSubscriptionDict.ContainsKey(id)))
            {
                return false;
            }

            // grab this object
            Subscription subscription = _idSubscriptionDict[id];

            // traverse trackings looking for this subscription
            string[] resourceKeys = _resourceSubscriptionDict.Keys.ToArray<string>();
            foreach (string key in resourceKeys)
            {
                // check this node
                RemoveSubscriptionFromNodeTree(subscription, _resourceSubscriptionDict[key], out bool isEmpty);

                if (isEmpty)
                {
                    lock (_resourceSubscriptionDictLock)
                    {
                        _resourceSubscriptionDict.Remove(key);
                    }
                }
            }

            // remove from the main dictionary
            _idSubscriptionDict.Remove(id);

            // remove from status
            _idEventCountDict.Remove(id);

            // remove from the lock dictionary
            if (_idLockDict.ContainsKey(id))
            {
                _idLockDict.Remove(id);
            }

            // log this addition
            Console.WriteLine($" <<< removed Subscription: {id}");

            // success
            return true;
        }

        /// <summary>Gets encounter patient groups.</summary>
        /// <param name="encounter">The encounter.</param>
        /// <param name="groups">   [out] The list.</param>
        private void GetEncounterPatientGroupKeys(Encounter encounter, out List<string> groups)
        {
            FhirClient client = null;
            groups = new List<string>();

            // attempt to get groups this patient may belong to
            try
            {
                // get a FHIR client
#pragma warning disable CA2000 // Dispose objects before losing scope
                if (!TryGetFhirClient(out client))
#pragma warning restore CA2000 // Dispose objects before losing scope
                {
                    return;
                }

                // ask for the groups for this patient
                Bundle results = client.Search<Group>(new string[] { $"member={encounter.Subject.Reference}" });

                if ((results != null) &&
                    (results.Entry != null) &&
                    (results.Entry.Count > 0))
                {
                    // traverse entries
                    foreach (Bundle.EntryComponent entry in results.Entry)
                    {
                        groups.Add($"patient:{entry.Resource.TypeName}/{entry.Resource.Id}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ProcessEncounter <<< failed to get groups, ignoring: {ex.Message}");
            }
            finally
            {
                if (client != null)
                {
                    // return to our queue
                    ReturnFhirClientToQ(ref client);
                }
            }
        }

        /// <summary>Process the encounter described by content.</summary>
        /// <param name="content"> The content.</param>
        /// <param name="location">The location.</param>
        private void _ProcessEncounter(string content, Uri location)
        {
            List<Subscription> subscriptions = new List<Subscription>();

            Encounter e5 = null;

            // check to see if this resource is tracked (any subscriptions)
            if (!_resourceSubscriptionDict.ContainsKey("Encounter"))
            {
                // done
                return;
            }

            // attempt to parse the encounter
            try
            {
                if ((!string.IsNullOrEmpty(content)) && (content.Length > 20))
                {
                    // attempt to parse this encounter
                    e5 = _fhirParser.Parse<Encounter>(content);
                }
            }
            catch (Exception)
            {
                // ignore, likely an operation outcome or empty content
            }

            // check for not having an encounter
            if (e5 == null)
            {
                FhirClient client = null;

                // attempt to retrieve the encounter
                try
                {
                    // get a FHIR client
#pragma warning disable CA2000 // Dispose objects before losing scope
                    if (!TryGetFhirClient(out client))
#pragma warning restore CA2000 // Dispose objects before losing scope
                    {
                        return;
                    }

                    // read the specified resource
                    e5 = client.Read<Encounter>(location);
                }
                finally
                {
                    // return the client
                    ReturnFhirClientToQ(ref client);
                }
            }

            // check for no resource
            if (e5 == null)
            {
                Console.WriteLine("Could not get Encounter resource!");
                return;
            }

            // parse the encounter
            try
            {
                // build a list of all our keys
                List<string> searchKeys = new List<string>();

                // add our patient match key
                searchKeys.Add($"patient:{e5.Subject.Reference}");

                // get the groups this patient belongs to
                GetEncounterPatientGroupKeys(e5, out List<string> patientGroupKeys);

                // add our patient group keys
                searchKeys.AddRange(patientGroupKeys);

                // sort our keys
                searchKeys.Sort();

                // create a hashset of the keys (for exclusion checking)
                HashSet<string> searchSet = searchKeys.ToHashSet<string>();

                // find the subscriptions for this resource
                FindSubscriptionsForKeys(
                    _resourceSubscriptionDict["Encounter"],
                    searchKeys,
                    searchSet,
                    ref subscriptions);

                // notify all subscriptions
                foreach (Subscription subscription in subscriptions)
                {
                    TryNotifySubscription(subscription.Id, e5);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ProcessEncounter <<< caught exception: {ex.Message}");
            }
        }

        /// <summary>Searches for the first subscriptions for keys.</summary>
        /// <param name="node">         The node.</param>
        /// <param name="matchKeys">    The match keys.</param>
        /// <param name="matchHashSet"> Set the match hash belongs to.</param>
        /// <param name="subscriptions">[in,out] The subscriptions.</param>
        private void FindSubscriptionsForKeys(
            SubscriptionFilterNode node,
            List<string> matchKeys,
            HashSet<string> matchHashSet,
            ref List<Subscription> subscriptions)
        {
            // add subscriptions on this level
            if (node.Subscriptions.Count > 0)
            {
                subscriptions.AddRange(node.Subscriptions);
            }

            // check each of our keys
            foreach (string key in matchKeys)
            {
                // check for inclusions
                if (node.Inclusions.ContainsKey(key))
                {
                    // **** process this node ***
                    FindSubscriptionsForKeys(node.Inclusions[key], matchKeys, matchHashSet, ref subscriptions);
                }
            }

            // check exclusions
            foreach (string key in node.Exclusions.Keys.ToArray<string>())
            {
                // check for not existing
                if (!matchHashSet.Contains(key))
                {
                    // process this node
                    FindSubscriptionsForKeys(node.Exclusions[key], matchKeys, matchHashSet, ref subscriptions);
                }
            }
        }

        /// <summary>Handles a POST of a Subscription object.</summary>
        /// <param name="content">       The content.</param>
        /// <param name="subscription">  [out] The subscription.</param>
        /// <param name="statusCode">    [out] The status code.</param>
        /// <param name="failureContent">[out] The failure content.</param>
        private void _HandlePost(
                                    string content,
                                    out Subscription subscription,
                                    out HttpStatusCode statusCode,
                                    out string failureContent)
        {
            subscription = null;
            statusCode = System.Net.HttpStatusCode.Created;
            failureContent = string.Empty;

            // attempt to parse our content into a subscription request
            try
            {
                subscription = _fhirParser.Parse<Subscription>(content);

                // check for no parsed object
                if (subscription == null)
                {
                    statusCode = HttpStatusCode.BadRequest;
                    failureContent = "Invalid subscription";
                    return;
                }

                // check for no channel
                if (subscription.ChannelType == null)
                {
                    statusCode = HttpStatusCode.BadRequest;
                    failureContent = "Invalid channel";
                    return;
                }

                // check for invalid content type
                if (string.IsNullOrEmpty(subscription.ContentType) ||
                    subscription.ContentType.Contains("xml", StringComparison.OrdinalIgnoreCase))
                {
                    statusCode = HttpStatusCode.BadRequest;
                    failureContent = $"Invalid channel payload type: {subscription.ContentType}!" +
                        $" currently only 'application/fhir+json' is supported.";
                    return;
                }

                // check for the topic
                if ((subscription.Topic == null) ||
                    (!SubscriptionTopicManager.IsImplemented(subscription.Topic.Reference)))
                {
                    statusCode = HttpStatusCode.BadRequest;
                    failureContent = $"Invalid SubscriptionTopic: {subscription.Topic}!";
                    return;
                }

                if (string.IsNullOrEmpty(subscription.Id))
                {
                    subscription.Id = Guid.NewGuid().ToString();
                }

                // force the subscription to be one day or less
                DateTime maxEnd = DateTime.Now.AddDays(1.0);

                if ((subscription.End == null) ||
                    (subscription.End.Value.DateTime > maxEnd))
                {
                    // force our end
                    subscription.End = new DateTimeOffset(maxEnd.ToUniversalTime());
                }

                _AddOrUpdate(subscription);

                bool shouldSendHandshake = false;

                if (subscription.ChannelType != null)
                {
                    if (subscription.ChannelType.Code == fhirP5.SubscriptionChannelType.rest_hook.Code)
                    {
                        if (string.IsNullOrEmpty(subscription.Endpoint) ||
                            (!Uri.TryCreate(subscription.Endpoint, UriKind.Absolute, out _)))
                        {
                            statusCode = HttpStatusCode.BadRequest;
                            failureContent = $"Invalid Endpoint for rest-hook subscription: {subscription.Endpoint}";
                            return;
                        }

                        // rest-hook sends handshake
                        shouldSendHandshake = true;
                    }

                    if (subscription.ChannelType.Code == fhirP5.SubscriptionChannelType.email.Code)
                    {
                        // email sends handshake
                        shouldSendHandshake = true;
                    }

                    if (!_supportedChannelTypes.Contains(subscription.ChannelType.Code))
                    {
                        statusCode = HttpStatusCode.BadRequest;
                        failureContent = $"Invalid channel type requested: {subscription.ChannelType.Code}";
                        return;
                    }
                }

                if (shouldSendHandshake)
                {
                    string id = subscription.Id;

                    // attempt to validate the endpoint
                    _ = System.Threading.Tasks.Task.Run((Action)(() => HandshakeSubscription(id)));
                }
                else
                {
                    // if there's no handshake, just mark the subscription active
                    _idSubscriptionDict[subscription.Id].Status = SubscriptionState.Active;
                }
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception ex)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                Console.WriteLine($"SubscriptionManager._HandlePost <<< caught exception: {ex}");
            }
        }

        /// <summary>Adds or updates a Topic.</summary>
        /// <param name="subscription">The subscription.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        private bool _AddOrUpdate(Subscription subscription)
        {
            // check for an existing subscription (may need to remove URL for cleanup)
            if (_idSubscriptionDict.ContainsKey(subscription.Id))
            {
                // remove from the main dict
                _idSubscriptionDict.Remove(subscription.Id);
            }

            if (_idEventCountDict.ContainsKey(subscription.Id))
            {
                _idEventCountDict.Remove(subscription.Id);
            }

            // create a lock object for this subscription
            if (!_idLockDict.ContainsKey(subscription.Id))
            {
                _idLockDict.Add(subscription.Id, new object());
            }

            // add to the main dictionaries
            _idSubscriptionDict.Add(subscription.Id, subscription);
            _idEventCountDict.Add(subscription.Id, 0);

            // log this addition
            Console.WriteLine($" <<< added Subscription:" +
                $" {subscription.Id}" +
                $" ({subscription.ChannelType.Code}," +
                $" {subscription.Content})");

            // get the topic for this subscription
            SubscriptionTopic topic = SubscriptionTopicManager.GetTopic(
                Program.ResourceIdFromReference(subscription.Topic.Reference));

            // check for unknown topic
            if (topic == null)
            {
                Console.WriteLine($"SubscriptionManager._AddOrUpdate <<< could not find topic: {subscription.Topic.Reference}");
                return false;
            }

            // track this subscription (based on topic)
            if (!TrackSubscription(subscription, topic))
            {
                // make sure partial updates are removed
                Remove(subscription.Id);

                // failed
                return false;
            }

            // still here is success
            return true;
        }

        /// <summary>Track resource.</summary>
        /// <param name="resourceName">Name of the resource.</param>
        private void TrackResource(string resourceName)
        {
            lock (_resourceSubscriptionDictLock)
            {
                // make sure this resource is tracked
                if (!_resourceSubscriptionDict.ContainsKey(resourceName))
                {
                    _resourceSubscriptionDict.Add(resourceName, new SubscriptionFilterNode()
                    {
                        Subscriptions = new List<Subscription>(),
                        Inclusions = new Dictionary<string, SubscriptionFilterNode>(),
                        Exclusions = new Dictionary<string, SubscriptionFilterNode>(),
                    })
                    ;
                }
            }
        }

        /// <summary>Track subscription.</summary>
        /// <param name="subscription">[out] The subscription.</param>
        /// <param name="topic">       The topic.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        private bool TrackSubscription(Subscription subscription, SubscriptionTopic topic)
        {
            // check for unfiltered subscriptions
            if ((subscription.FilterBy == null) || (subscription.FilterBy.Count == 0))
            {
                // check for resource types
                if ((topic.ResourceTrigger.ResourceType == null) ||
                    (!topic.ResourceTrigger.ResourceType.Any()))
                {
                    // reject this subscription
                    Console.WriteLine("SubscriptionManager.TrackSubscription <<< invalid resource triggers: [].");
                    return false;
                }
                else
                {
                    // loop over resource types
                    foreach (Code<fhir5.Hl7.Fhir.Model.ResourceType> resourceType in topic.ResourceTrigger.ResourceTypeElement)
                    {
                        if (resourceType == null)
                        {
                            continue;
                        }

                        TrackResource(resourceType.ToString());
                        lock (_resourceSubscriptionDictLock)
                        {
                            _resourceSubscriptionDict[resourceType.ToString()].Subscriptions.Add(subscription);
                        }
                    }
                }

                // done with this type of subscription
                return true;
            }

            // for now, reject any subscription that starts with an exclusion
            if (subscription.FilterBy[0].SearchModifier == SubscriptionSearchModifier.NotIn)
            {
                Console.WriteLine($"SubscriptionManager.TrackSubscription <<< first match cannot be {subscription.FilterBy[0].SearchModifier}");
                return false;
            }

            // get our list of filters
            List<Subscription.FilterByComponent> filters = subscription.FilterBy.ToList();

            // sort by field, match, value
            filters.Sort(
                (a, b) => string.CompareOrdinal(
                    $"{a.SearchParamName}{a.SearchModifier.ToString()}{a.Value}",
                    $"{b.SearchParamName}{b.SearchModifier.ToString()}{b.Value}"));

            // loop over resources in the topic
            foreach (ResourceType? resourceType in topic.ResourceTrigger.ResourceType)
            {
                if ((resourceType == null) || (!resourceType.HasValue))
                {
                    continue;
                }

                // make sure this resource is tracked
                TrackResource(resourceType.ToString());

                // track based on filters
                if (!TrackFilterNode(subscription, _resourceSubscriptionDict[resourceType.ToString()], filters))
                {
                    return false;
                }
            }

            // still here is success
            return true;
        }

        /// <summary>Track filter node.</summary>
        /// <param name="subscription">[out] The subscription.</param>
        /// <param name="node">        The node.</param>
        /// <param name="filters">     The filters.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        private bool TrackFilterNode(
            Subscription subscription,
            SubscriptionFilterNode node,
            List<Subscription.FilterByComponent> filters)
        {
            // check for no filters (done)
            if (filters.Count == 0)
            {
                // add the subscription to this node
                node.Subscriptions.Add(subscription);

                // done
                return true;
            }

            // grab the first filter (sorted)
            Subscription.FilterByComponent filter = filters[0];
            filters.RemoveAt(0);

            // check for no value
            if (string.IsNullOrEmpty(filter.Value))
            {
                // cannot add this
                Console.WriteLine($"SubscriptionManager.TrackFilterNode <<<" +
                    $" invalid value is null! subscription: {subscription.Id}");
                return false;
            }

            bool success = true;

            // split possible values
            string[] filterValues = filter.Value.Split(',');

            foreach (string filterValue in filterValues)
            {
                // build the key
                string filterKey = $"{filter.SearchParamName}:{filterValue}";

                // add to the correct type
                switch (filter.SearchModifier)
                {
                    case SubscriptionSearchModifier.NotIn:
                    case SubscriptionSearchModifier.Ne:
                        // make sure this field is in exclusions
                        lock (_resourceSubscriptionDictLock)
                        {
                            if (!node.Exclusions.ContainsKey(filterKey))
                            {
                                node.Exclusions.Add(filterKey, new SubscriptionFilterNode()
                                {
                                    Subscriptions = new List<Subscription>(),
                                    Inclusions = new Dictionary<string, SubscriptionFilterNode>(),
                                    Exclusions = new Dictionary<string, SubscriptionFilterNode>(),
                                });
                            }
                        }

                        // continue traversing, stop on failures
                        if (!TrackFilterNode(subscription, node.Exclusions[filterKey], filters))
                        {
                            return false;
                        }

                        break;

                    case SubscriptionSearchModifier.In:
                    case SubscriptionSearchModifier.Equal:
                    case SubscriptionSearchModifier.Eq:
                        // make sure this field is in the inclusions
                        lock (_resourceSubscriptionDictLock)
                        {
                            if (!node.Inclusions.ContainsKey(filterKey))
                            {
                                node.Inclusions.Add(filterKey, new SubscriptionFilterNode()
                                {
                                    Subscriptions = new List<Subscription>(),
                                    Inclusions = new Dictionary<string, SubscriptionFilterNode>(),
                                    Exclusions = new Dictionary<string, SubscriptionFilterNode>(),
                                });
                            }
                        }

                        // continue traversing, stop of failures
                        if (!TrackFilterNode(subscription, node.Inclusions[filterKey], filters))
                        {
                            return false;
                        }

                        break;

                    default:
                        // unhandled match type
                        Console.WriteLine($"SubscriptionManager.TrackFilterNode <<<" +
                            $" invalid MatchType: {filter.SearchModifier}! subscription: {subscription.Id}");
                        return false;
                }
            }

            return success;
        }

        /// <summary>Dumps a node.</summary>
        /// <param name="node">The node.</param>
        private void DumpNode(ISourceNode node)
        {
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "{0,70} {1,20} {2}", "Location", "Name", "Text"));
            _DumpNode(node);
        }

        /// <summary>Dumps a node.</summary>
        /// <param name="node">The node.</param>
        private void _DumpNode(ISourceNode node)
        {
            Console.WriteLine($"{node.Location,70} {node.Name,20} {node.Text}");

            foreach (ISourceNode child in node.Children())
            {
                _DumpNode(child);
            }
        }

        /// <summary>Handshake REST hook.</summary>
        /// <param name="subscriptionId">The subscription id.</param>
        /// <returns>An asynchronous result that yields true if it succeeds, false if it fails.</returns>
        private bool HandshakeSubscription(string subscriptionId)
        {
            // sanity checks
            if (string.IsNullOrEmpty(subscriptionId) ||
                (!_idSubscriptionDict.ContainsKey(subscriptionId)))
            {
                return false;
            }

            Subscription subscription = _idSubscriptionDict[subscriptionId];

            if (string.IsNullOrEmpty(subscription.Endpoint))
            {
                // nothing to do
                _idSubscriptionDict[subscription.Id].Status = SubscriptionState.Error;

                return false;
            }

            bool notified = TryNotifySubscription(subscriptionId, null);

            // attempt to send the notification
            if (notified)
            {
                // update in the manager (if it hasn't been removed)
                if (_idSubscriptionDict.ContainsKey(subscriptionId))
                {
                    _idSubscriptionDict[subscriptionId].Status = SubscriptionState.Active;
                }
            }
            else
            {
                // update to error in the manager (if it hasn't been removed)
                if (_idSubscriptionDict.ContainsKey(subscriptionId))
                {
                    _idSubscriptionDict[subscriptionId].Status = SubscriptionState.Error;
                }
            }

            // tell the user
            Console.WriteLine($" <<< Subscription {subscription.Id} set to active!");

            // done
            return true;
        }

        /// <summary>Attempts to get fhir client a FhirClient from the given string.</summary>
        /// <param name="client">[out] The client.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        private bool TryGetFhirClient(out FhirClient client)
        {
            // check to see if we can get a client from the queue
            lock (_clientQLock)
            {
                if (_clientQ.Count > 0)
                {
                    client = _clientQ.Dequeue();
                    return true;
                }

                // attempt to create our client
                try
                {
                    client = new FhirClient(
                        Program.FhirServerUrlR5,
                        new Hl7.Fhir.Rest.FhirClientSettings()
                        {
                            PreferredFormat = Hl7.Fhir.Rest.ResourceFormat.Json,
                            PreferredReturn = Hl7.Fhir.Rest.Prefer.ReturnRepresentation,
                        });

                    // valid
                    return true;
                }
                catch (Exception ex)
                {
                    // log for reference
                    Console.WriteLine($"SubscriptionMananger.TryGetFhirClient <<<" +
                        $" failed url: {Program.FhirServerUrlR5}," +
                        $" exception: {ex.Message}");
                }
            }

            // still here means failure
            client = null;
            return false;
        }

        /// <summary>Returns fhir client to q.</summary>
        /// <param name="client">[out] The client.</param>
        private void ReturnFhirClientToQ(ref FhirClient client)
        {
            // thread safe
            lock (_clientQLock)
            {
                _clientQ.Enqueue(client);
                client = null;
            }
        }

        /// <summary>
        /// Attempts to get subscription status the SubscriptionStatus from the given Subscription.
        /// </summary>
        /// <param name="id">                  The identifier.</param>
        /// <param name="status">              [out] The status.</param>
        /// <param name="eventsInNotification">The events in notification.</param>
        /// <param name="isForQuery">          True if is for query, false if not.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        public static bool TryGetSubscriptionStatus(
            string id,
            out SubscriptionStatus status,
            int eventsInNotification,
            bool isForQuery)
        {
            if (string.IsNullOrEmpty(id))
            {
                status = null;
                return false;
            }

            if (!TryGetSubscription(id, out Subscription subscription))
            {
                status = null;
                return false;
            }

            long eventCount = _instance._idEventCountDict[subscription.Id];

            status = new SubscriptionStatus()
            {
                EventsSinceSubscriptionStart = eventCount,
                EventsInNotification = eventsInNotification,
                Status = subscription.Status,
                Subscription = new ResourceReference(Program.UrlForR5ResourceId("Subscription", subscription.Id)),
                Topic = new Canonical(subscription.Topic.Reference),
            };

            if (isForQuery)
            {
                status.Type = SubscriptionStatus.SubscriptionNotificationType.QueryStatus;
            }
            else if (eventsInNotification == 0)
            {
                if (eventCount == 0)
                {
                    status.Type = SubscriptionStatus.SubscriptionNotificationType.Handshake;
                }
                else
                {
                    status.Type = SubscriptionStatus.SubscriptionNotificationType.Heartbeat;
                }
            }
            else
            {
                status.Type = SubscriptionStatus.SubscriptionNotificationType.EventNotification;
            }

            return true;
        }

        /// <summary>Bundle for subscription notification.</summary>
        /// <exception cref="ArgumentNullException">Thrown when one or more required arguments are null.</exception>
        /// <param name="subscription">          The subscription.</param>
        /// <param name="content">               The content.</param>
        /// <param name="bundle">                [out] The bundle.</param>
        /// <param name="subscriptionEventCount">[out] Number of events.</param>
        public static void BundleForSubscriptionNotification(
            Subscription subscription,
            Resource content,
            out Bundle bundle,
            out long subscriptionEventCount)
        {
            if (subscription == null)
            {
                throw new ArgumentNullException(nameof(subscription));
            }

            // check our event count
            lock (_instance._idLockDict[subscription.Id])
            {
                // get the event count
                subscriptionEventCount = _instance._idEventCountDict[subscription.Id];

                // check if we are incrementing the event
                if (content != null)
                {
                    _instance._idEventCountDict[subscription.Id] = ++subscriptionEventCount;
                }
            }

            // create a bundle for this message message
            bundle = new Bundle()
            {
                // Identifier = new Identifier("http://terminology.hl7.org/CodeSystem/ietf-uuid", Guid.NewGuid().ToString()),
                Type = Bundle.BundleType.SubscriptionNotification,  // History
                Timestamp = new DateTimeOffset(DateTime.Now),
                Meta = new Meta(),
                Entry = new List<Bundle.EntryComponent>(),
            };

            if (TryGetSubscriptionStatus(subscription.Id, out SubscriptionStatus status, (content == null) ? 0 : 1, false))
            {
                bundle.AddResourceEntry(status, Program.UrlForR5ResourceId(status.TypeName, status.Id));
            }

            // check if we are adding contents
            if ((content != null) && (subscription.Content != Subscription.SubscriptionPayloadContent.Empty))
            {
                // add depending on type
                if (subscription.Content == Subscription.SubscriptionPayloadContent.IdOnly)
                {
                    // add the URL, but no resource
                    bundle.AddResourceEntry(null, Program.UrlForR5ResourceId(content.TypeName, content.Id));
                }
                else
                {
                    // add the URL and the resource
                    bundle.AddResourceEntry(content, Program.UrlForR5ResourceId(content.TypeName, content.Id));
                }
            }
        }

        /// <summary>Error concept for string.</summary>
        /// <param name="message">The message.</param>
        /// <param name="errno">  (Optional) The errno.</param>
        /// <returns>A CodeableConcept[].</returns>
        private List<CodeableConcept> ErrorConceptForString(string message, int errno = 1)
        {
            return new List<CodeableConcept>()
            {
                new CodeableConcept(
                    "http://example.org/primary/code/system/is/not/yet/defined",
                    $"{errno}",
                    message),
            };
        }

        /// <summary>Attempts to notify subscription a Resource from the given string.</summary>
        /// <param name="subscriptionId">The subscription id.</param>
        /// <param name="content">       (Optional) The content.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        private bool TryNotifySubscription(string subscriptionId, Resource content = null)
        {
            // sanity checks
            if (string.IsNullOrEmpty(subscriptionId) ||
                (!_idSubscriptionDict.ContainsKey(subscriptionId)))
            {
                // fail
                return false;
            }

            string contentTypeName = (content == null) ? string.Empty : content.TypeName;
            string contentId = (content == null) ? string.Empty : content.Id;

            // get the subscription
            Subscription subscription = _idSubscriptionDict[subscriptionId];

            // get our bundle we want to send
            BundleForSubscriptionNotification(
                subscription,
                content,
                out Bundle bundle,
                out long subscriptionEventCount);

            string json = _fhirSerializer.SerializeToString(bundle);

            // check for a rest-hook
            if (subscription.ChannelType.Code == fhirP5.SubscriptionChannelType.rest_hook.Code)
            {
                // send via hook
                bool notified = NotificationManager.TryNotifyRestHook(
                    subscription.Id,
                    subscription.Endpoint,
                    subscription.Header,
                    json,
                    contentTypeName,
                    contentId,
                    subscriptionEventCount);

                if (notified)
                {
                    // check to see if we need to clear an error
                    if (_idSubscriptionDict[subscription.Id].Status == SubscriptionState.Error)
                    {
                        _idSubscriptionDict[subscription.Id].Status = SubscriptionState.Active;
                        //_idSubscriptionDict[subscription.Id].Error = null;
                    }
                }
                else
                {
                    // done
                    _idSubscriptionDict[subscription.Id].Status = SubscriptionState.Error;
                    //_idSubscriptionDict[subscription.Id].Error = ErrorConceptForString($"Endpoint returned: {response.ReasonPhrase}", (int)response.StatusCode);
                }
            }

            if (subscription.ChannelType.Code == fhirP5.SubscriptionChannelType.email.Code)
            {
                // send via email
                bool notified = NotificationManager.TryNotifyEmail(
                    subscription.Id,
                    subscription.Endpoint,
                    subscription.ContentType,
                    subscription.Content.ToString(),
                    json,
                    contentTypeName,
                    contentId,
                    subscriptionEventCount);

                if (notified)
                {
                    // check to see if we need to clear an error
                    if (_idSubscriptionDict[subscription.Id].Status == SubscriptionState.Error)
                    {
                        _idSubscriptionDict[subscription.Id].Status = SubscriptionState.Active;
                    }
                }
                else
                {
                    // done
                    _idSubscriptionDict[subscription.Id].Status = SubscriptionState.Error;
                }
            }

            if (subscription.ChannelType.Code == fhirP5.SubscriptionChannelType.websocket.Code)
            {
                // send via websocket
                WebsocketManager.QueueMessagesForSubscription(subscription, json);
            }

            // done
            return true;
        }

        /// <summary>Clean up thread function.</summary>
        private void CleanUpThreadFunc()
        {
            // loop forever (will be killed at shutdown as background thread)
            while (true)
            {
                // wait a minute, not in one call so we can be responsive to shutdown
                for (int sleepSecond = 0; sleepSecond < 60; sleepSecond++)
                {
                    Thread.Sleep(1000);
                }

                // check each subscription
                foreach (string id in _idLockDict.Keys)
                {
                    try
                    {
                        // check this subscription
                        Subscription subscription = _idSubscriptionDict[id];

                        if ((subscription.End == null) ||
                            (subscription.End.Value.DateTime < DateTime.Now))
                        {
                            // tell the user what's going on
                            Console.WriteLine($" <<< Removing subscription {id} due to expiration! - {DateTime.Now}");

                            // remove this subscription
                            Remove(id);
                        }
                    }
                    catch (Exception ex)
                    {
                        // just log for now
                        Console.WriteLine($"SubscriptionManager.CleanUpThreadFunc <<<" +
                            $"id: {id} raised exception: {ex.Message}");
                    }
                }
            }
        }

        /// <summary>Check or create instance.</summary>
        private static void CheckOrCreateInstance()
        {
            if (_instance == null)
            {
                _instance = new SubscriptionManagerR5();
            }
        }
    }
}
