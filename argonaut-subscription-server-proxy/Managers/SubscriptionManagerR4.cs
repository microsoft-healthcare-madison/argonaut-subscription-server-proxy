// <copyright file="SubscriptionManagerR4.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir4;
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
using fhir4.Hl7.Fhir.Model;
using fhir4.Hl7.Fhir.Rest;
using fhir4.Hl7.Fhir.Serialization;
using Hl7.Fhir.Model;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace argonaut_subscription_server_proxy.Managers
{
    /// <summary>Manager for subscriptions.</summary>
    public class SubscriptionManagerR4
    {
        /// <summary>The instance for singleton pattern.</summary>
        private static SubscriptionManagerR4 _instance;

        /// <summary>Dictionary of subscriptions, by ID.</summary>
        private Dictionary<string, Subscription> _idSubscriptionDict;

        /// <summary>Dictionary of identifier subscriptions in R5.</summary>
        private Dictionary<string, fhir5.Hl7.Fhir.Model.Subscription> _idSubscriptionR5Dict;

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
        /// Initializes a new instance of the <see cref="SubscriptionManagerR4"/> class.
        /// </summary>
        private SubscriptionManagerR4()
        {
            // create our index objects
            _idSubscriptionDict = new Dictionary<string, Subscription>();
            _idSubscriptionR5Dict = new Dictionary<string, fhir5.Hl7.Fhir.Model.Subscription>();
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
                new Uri($"/r4/Subscription/{subscriptionId}", UriKind.Relative))
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

        /// <summary>Gets subscriptions bundle r 4.</summary>
        /// <returns>The subscriptions bundle r 4.</returns>
        private Bundle _GetSubscriptionsBundle()
        {
            Bundle bundle = new Bundle()
            {
                Type = Bundle.BundleType.Searchset,
                Total = _idSubscriptionDict.Count,
                Meta = new Hl7.Fhir.Model.Meta()
                {
                    LastUpdated = new DateTimeOffset(DateTime.Now.ToUniversalTime()),
                },
                Entry = new List<Bundle.EntryComponent>(),
            };

            foreach (Subscription subscription in _idSubscriptionDict.Values)
            {
                bundle.Entry.Add(new Bundle.EntryComponent()
                {
                    FullUrl = Program.UrlForR4ResourceId("Subscription", subscription.Id),
                    Resource = subscription,
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

            fhir5.Hl7.Fhir.Model.Subscription s5 = _idSubscriptionR5Dict[subscription.Id];

            lock (_resourceSubscriptionDictLock)
            {
                if (node.Subscriptions.Contains(s5))
                {
                    node.Subscriptions.Remove(s5);
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
            _idSubscriptionR5Dict.Remove(id);

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

            Encounter e4 = null;

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
                    e4 = _fhirParser.Parse<Encounter>(content);
                }
            }
            catch (Exception)
            {
                // ignore, likely an operation outcome or empty content
            }

            // check for not having an encounter
            if (e4 == null)
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
                    e4 = client.Read<Encounter>(location);
                }
                finally
                {
                    // return the client
                    ReturnFhirClientToQ(ref client);
                }
            }

            // check for no resource
            if (e4 == null)
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
                searchKeys.Add($"patient:{e4.Subject.Reference}");

                // get the groups this patient belongs to
                GetEncounterPatientGroupKeys(e4, out List<string> patientGroupKeys);

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
                    TryNotifySubscription(subscription.Id, e4);
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
                foreach (fhir5.Hl7.Fhir.Model.Subscription s5 in node.Subscriptions)
                {
                    subscriptions.Add(_idSubscriptionDict[s5.Id]);
                }
            }

            // check each of our keys
            foreach (string key in matchKeys)
            {
                // check for inclusions
                if (node.Inclusions.ContainsKey(key))
                {
                    FindSubscriptionsForKeys(node.Inclusions[key], matchKeys, matchHashSet, ref subscriptions);
                }
            }

            // check exclusions
            foreach (string key in node.Exclusions.Keys.ToArray<string>())
            {
                // check for not existing
                if (!matchHashSet.Contains(key))
                {
                    FindSubscriptionsForKeys(node.Exclusions[key], matchKeys, matchHashSet, ref subscriptions);
                }
            }
        }

        /// <summary>Handles a POST of a Subscription object.</summary>
        /// <exception cref="ArgumentException">Thrown when one or more arguments have unsupported or
        ///  illegal values.</exception>
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
                if (subscription == null)
                {
                    throw new ArgumentException("Invalid subscription content", nameof(content));
                }

                fhir5.Hl7.Fhir.Model.Subscription s5 = SubscriptionConverter.ToR5(subscription);

                // check for no parsed object
                if (s5 == null)
                {
                    statusCode = HttpStatusCode.BadRequest;
                    failureContent = "Invalid subscription";
                    return;
                }

                // check for no channel
                if (s5.ChannelType == null)
                {
                    statusCode = HttpStatusCode.BadRequest;
                    failureContent = "Invalid channel";
                    return;
                }

                // check for invalid content type
                if (string.IsNullOrEmpty(s5.ContentType) ||
                    s5.ContentType.Contains("xml", StringComparison.OrdinalIgnoreCase))
                {
                    statusCode = HttpStatusCode.BadRequest;
                    failureContent = $"Invalid channel payload type: {s5.ContentType}!" +
                        $" currently only 'application/fhir+json' is supported.";
                    return;
                }

                // check for the topic
                if ((s5.Topic == null) ||
                    (!SubscriptionTopicManager.IsImplemented(s5.Topic.Reference)))
                {
                    statusCode = HttpStatusCode.BadRequest;
                    failureContent = $"Invalid SubscriptionTopic: {s5.Topic}!";
                    return;
                }

                if (string.IsNullOrEmpty(subscription.Id))
                {
                    subscription.Id = Guid.NewGuid().ToString();
                    s5.Id = subscription.Id;
                }

                // force the subscription to be one day or less
                DateTime maxEnd = DateTime.Now.AddDays(1.0);

                if ((subscription.End == null) ||
                    (subscription.End.Value.DateTime > maxEnd))
                {
                    // force our end
                    subscription.End = new DateTimeOffset(maxEnd.ToUniversalTime());
                    s5.End = subscription.End;
                }

                _AddOrUpdate(subscription, s5);

                bool shouldSendHandshake = false;

                if (s5.ChannelType != null)
                {
                    if (s5.ChannelType.Code == fhirP5.SubscriptionChannelType.rest_hook.Code)
                    {
                        if (string.IsNullOrEmpty(s5.Endpoint) ||
                            (!Uri.TryCreate(s5.Endpoint, UriKind.Absolute, out _)))
                        {
                            statusCode = HttpStatusCode.BadRequest;
                            failureContent = $"Invalid Endpoint for rest-hook subscription: {s5.Endpoint}";
                            return;
                        }

                        // rest-hook sends handshake
                        shouldSendHandshake = true;
                    }

                    if (s5.ChannelType.Code == fhirP5.SubscriptionChannelType.email.Code)
                    {
                        // email sends handshake
                        shouldSendHandshake = true;
                    }

                    if (!_supportedChannelTypes.Contains(s5.ChannelType.Code))
                    {
                        statusCode = HttpStatusCode.BadRequest;
                        failureContent = $"Invalid channel type requested: {s5.ChannelType.Code}";
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
                    _idSubscriptionDict[subscription.Id].Status = Subscription.SubscriptionStatus.Active;
                    _idSubscriptionR5Dict[subscription.Id].Status = fhir5.Hl7.Fhir.Model.SubscriptionState.Active;
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
        /// <param name="s5">          The R5 Subscription.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        private bool _AddOrUpdate(Subscription subscription, fhir5.Hl7.Fhir.Model.Subscription s5)
        {
            // check for an existing subscription (may need to remove URL for cleanup)
            if (_idSubscriptionDict.ContainsKey(subscription.Id))
            {
                // remove from the main dict
                _idSubscriptionDict.Remove(subscription.Id);
            }

            if (_idSubscriptionR5Dict.ContainsKey(s5.Id))
            {
                _idSubscriptionR5Dict.Remove(s5.Id);
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
            _idSubscriptionR5Dict.Add(s5.Id, s5);
            _idEventCountDict.Add(subscription.Id, 0);

            // log this addition
            Console.WriteLine($" <<< added Subscription:" +
                $" {subscription.Id}" +
                $" ({subscription.Channel.Type})," +
                $" {s5.Topic.Reference}");

            // get the topic for this subscription
            fhir5.Hl7.Fhir.Model.SubscriptionTopic topic = SubscriptionTopicManager.GetTopic(
                Program.ResourceIdFromReference(s5.Topic.Reference));

            // check for unknown topic
            if (topic == null)
            {
                Console.WriteLine($"SubscriptionManager._AddOrUpdate <<< could not find topic: {s5.Topic.Reference}");
                return false;
            }

            // track this subscription (based on topic)
            if (!TrackSubscription(subscription, s5, topic))
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
                        Subscriptions = new List<fhir5.Hl7.Fhir.Model.Subscription>(),
                        Inclusions = new Dictionary<string, SubscriptionFilterNode>(),
                        Exclusions = new Dictionary<string, SubscriptionFilterNode>(),
                    })
                    ;
                }
            }
        }

        /// <summary>Track subscription.</summary>
        /// <param name="subscription">[out] The subscription.</param>
        /// <param name="s5">          The R5 Subscription.</param>
        /// <param name="topic">       The topic.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        private bool TrackSubscription(
            Subscription subscription,
            fhir5.Hl7.Fhir.Model.Subscription s5,
            fhir5.Hl7.Fhir.Model.SubscriptionTopic topic)
        {
            // check for unfiltered subscriptions
            if ((s5.FilterBy == null) || (s5.FilterBy.Count == 0))
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
                    foreach (ResourceType? resourceType in topic.ResourceTrigger.ResourceType)
                    {
                        if ((resourceType == null) || (!resourceType.HasValue))
                        {
                            continue;
                        }

                        TrackResource(resourceType.ToString());
                        lock (_resourceSubscriptionDictLock)
                        {
                            _resourceSubscriptionDict[resourceType.ToString()].Subscriptions.Add(s5);
                        }
                    }
                }

                // done with this type of subscription
                return true;
            }

            // for now, reject any subscription that starts with an exclusion
            if (s5.FilterBy[0].SearchModifier == fhir5.Hl7.Fhir.Model.SubscriptionSearchModifier.NotIn)
            {
                Console.WriteLine($"SubscriptionManager.TrackSubscription <<< first match cannot be {s5.FilterBy[0].SearchModifier}");
                return false;
            }

            // get our list of filters
            List<fhir5.Hl7.Fhir.Model.Subscription.FilterByComponent> filters = s5.FilterBy.ToList();

            // sort by field, match, value
            filters.Sort(
                (a, b) => string.CompareOrdinal(
                    $"{a.SearchParamName}{a.SearchModifier.ToString()}{a.Value}",
                    $"{b.SearchParamName}{b.SearchModifier.ToString()}{b.Value}"));

            // loop over resources in the topic
            foreach (Code<fhir5.Hl7.Fhir.Model.ResourceType> resourceType in topic.ResourceTrigger.ResourceTypeElement)
            {
                if (resourceType == null)
                {
                    continue;
                }

                // make sure this resource is tracked
                TrackResource(resourceType.Value.ToString());

                // track based on filters
                if (!TrackFilterNode(s5, _resourceSubscriptionDict[resourceType.ToString()], filters))
                {
                    return false;
                }
            }

            // still here is success
            return true;
        }

        /// <summary>Track filter node.</summary>
        /// <param name="s5">[out] The subscription.</param>
        /// <param name="node">        The node.</param>
        /// <param name="filters">     The filters.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        private bool TrackFilterNode(
            fhir5.Hl7.Fhir.Model.Subscription s5,
            SubscriptionFilterNode node,
            List<fhir5.Hl7.Fhir.Model.Subscription.FilterByComponent> filters)
        {
            // check for no filters (done)
            if (filters.Count == 0)
            {
                // add the subscription to this node
                node.Subscriptions.Add(s5);

                // done
                return true;
            }

            // grab the first filter (sorted)
            fhir5.Hl7.Fhir.Model.Subscription.FilterByComponent filter = filters[0];
            filters.RemoveAt(0);

            // check for no value
            if (string.IsNullOrEmpty(filter.Value))
            {
                // cannot add this
                Console.WriteLine($"SubscriptionManager.TrackFilterNode <<<" +
                    $" invalid value is null! subscription: {s5.Id}");
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
                    case fhir5.Hl7.Fhir.Model.SubscriptionSearchModifier.NotIn:
                    case fhir5.Hl7.Fhir.Model.SubscriptionSearchModifier.Ne:
                        // make sure this field is in exclusions
                        lock (_resourceSubscriptionDictLock)
                        {
                            if (!node.Exclusions.ContainsKey(filterKey))
                            {
                                node.Exclusions.Add(filterKey, new SubscriptionFilterNode()
                                {
                                    Subscriptions = new List<fhir5.Hl7.Fhir.Model.Subscription>(),
                                    Inclusions = new Dictionary<string, SubscriptionFilterNode>(),
                                    Exclusions = new Dictionary<string, SubscriptionFilterNode>(),
                                });
                            }
                        }

                        // continue traversing, stop on failures
                        if (!TrackFilterNode(s5, node.Exclusions[filterKey], filters))
                        {
                            return false;
                        }

                        break;

                    case fhir5.Hl7.Fhir.Model.SubscriptionSearchModifier.In:
                    case fhir5.Hl7.Fhir.Model.SubscriptionSearchModifier.Equal:
                    case fhir5.Hl7.Fhir.Model.SubscriptionSearchModifier.Eq:
                        // make sure this field is in the inclusions
                        lock (_resourceSubscriptionDictLock)
                        {
                            if (!node.Inclusions.ContainsKey(filterKey))
                            {
                                node.Inclusions.Add(filterKey, new SubscriptionFilterNode()
                                {
                                    Subscriptions = new List<fhir5.Hl7.Fhir.Model.Subscription>(),
                                    Inclusions = new Dictionary<string, SubscriptionFilterNode>(),
                                    Exclusions = new Dictionary<string, SubscriptionFilterNode>(),
                                });
                            }
                        }

                        // continue traversing, stop of failures
                        if (!TrackFilterNode(s5, node.Inclusions[filterKey], filters))
                        {
                            return false;
                        }

                        break;

                    default:
                        // unhandled match type
                        Console.WriteLine($"SubscriptionManager.TrackFilterNode <<<" +
                            $" invalid MatchType: {filter.SearchModifier}! subscription: {s5.Id}");
                        return false;
                }
            }

            return success;
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
            fhir5.Hl7.Fhir.Model.Subscription s5 = _idSubscriptionR5Dict[subscriptionId];

            if (string.IsNullOrEmpty(s5.Endpoint))
            {
                // nothing to do
                _idSubscriptionDict[subscription.Id].Status = Subscription.SubscriptionStatus.Error;
                _idSubscriptionR5Dict[subscription.Id].Status = fhir5.Hl7.Fhir.Model.SubscriptionState.Error;

                return false;
            }

            bool notified = TryNotifySubscription(subscriptionId, null);

            // attempt to send the notification
            if (notified)
            {
                // update in the manager (if it hasn't been removed)
                if (_idSubscriptionDict.ContainsKey(subscriptionId))
                {
                    _idSubscriptionDict[subscription.Id].Status = Subscription.SubscriptionStatus.Active;
                    _idSubscriptionR5Dict[subscription.Id].Status = fhir5.Hl7.Fhir.Model.SubscriptionState.Active;
                }
            }
            else
            {
                // update to error in the manager (if it hasn't been removed)
                if (_idSubscriptionDict.ContainsKey(subscriptionId))
                {
                    _idSubscriptionDict[subscription.Id].Status = Subscription.SubscriptionStatus.Error;
                    _idSubscriptionR5Dict[subscription.Id].Status = fhir5.Hl7.Fhir.Model.SubscriptionState.Error;
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
                        Program.FhirServerUrlR4,
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
                    Console.WriteLine($"SubscriptionMananger.TryGetFhirClientR4 <<<" +
                        $" failed url: {Program.FhirServerUrlR4}," +
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
        /// Attempts to get subscription status r 4 the r4.Parameters from the given string.
        /// </summary>
        /// <param name="id">                  The identifier.</param>
        /// <param name="status">              [out] The status.</param>
        /// <param name="eventsInNotification">The events in notification.</param>
        /// <param name="isForQuery">          True if is for query, false if not.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        public static bool TryGetSubscriptionStatus(
            string id,
            out Parameters status,
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

            fhir5.Hl7.Fhir.Model.Subscription s5 = _instance._idSubscriptionR5Dict[subscription.Id];

            long eventCount = _instance._idEventCountDict[subscription.Id];

            status = new Parameters();
            status.Add("subscription", new ResourceReference(Program.UrlForR4ResourceId("Subscription", subscription.Id)));
            status.Add("topic", new FhirUri(s5.Topic.Url));
            status.Add("events-since-subscription-start", new UnsignedInt((int)eventCount));
            status.Add("events-in-notification", new UnsignedInt(eventsInNotification));

            switch (subscription.Status)
            {
                case Subscription.SubscriptionStatus.Active:
                    status.Add("status", new Code("active"));
                    break;

                case Subscription.SubscriptionStatus.Error:
                    status.Add("status", new Code("error"));
                    break;

                case Subscription.SubscriptionStatus.Off:
                    status.Add("status", new Code("off"));
                    break;

                case Subscription.SubscriptionStatus.Requested:
                    status.Add("status", new Code("requested"));
                    break;
                default:
                    break;
            }

            if (isForQuery)
            {
                status.Add("type", new Code("query-status"));
            }
            else if (eventsInNotification == 0)
            {
                if (eventCount == 0)
                {
                    status.Add("type", new Code("handshake"));
                }
                else
                {
                    status.Add("type", new Code("heartbeat"));
                }
            }
            else
            {
                status.Add("type", new Code("event-notification"));
            }

            return true;
        }

        /// <summary>Bundle for subscription notification r 4.</summary>
        /// <exception cref="ArgumentNullException">Thrown when one or more required arguments are null.</exception>
        /// <param name="subscription">          The subscription.</param>
        /// <param name="s5">                    The R5 Subscription.</param>
        /// <param name="content">               The content.</param>
        /// <param name="bundle">                [out] The bundle.</param>
        /// <param name="subscriptionEventCount">[out] Number of events.</param>
        public static void BundleForSubscriptionNotification(
            Subscription subscription,
            fhir5.Hl7.Fhir.Model.Subscription s5,
            Resource content,
            out Bundle bundle,
            out long subscriptionEventCount)
        {
            if ((subscription == null) || (s5 == null))
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
                Type = Bundle.BundleType.History,
                Timestamp = new DateTimeOffset(DateTime.Now),
                Meta = new Meta(),
                Entry = new List<Bundle.EntryComponent>(),
            };

            if (TryGetSubscriptionStatus(subscription.Id, out Parameters status, (content == null) ? 0 : 1, false))
            {
                bundle.Entry.Add(new Bundle.EntryComponent()
                {
                    FullUrl = Program.UrlForR4ResourceId(status.TypeName, status.Id),
                    Resource = status,
                });
            }

            // check if we are adding contents
            if ((content != null) && (s5.Content != fhir5.Hl7.Fhir.Model.Subscription.SubscriptionPayloadContent.Empty))
            {
                // add depending on type
                if (s5.Content == fhir5.Hl7.Fhir.Model.Subscription.SubscriptionPayloadContent.IdOnly)
                {
                    // add the URL, but no resource
                    bundle.Entry.Add(new Bundle.EntryComponent()
                    {
                        FullUrl = Program.UrlForR4ResourceId(content.TypeName, content.Id),
                    });

                }
                else
                {
                    // add the URL and the resource
                    bundle.Entry.Add(new Bundle.EntryComponent()
                    {
                        FullUrl = Program.UrlForR4ResourceId(content.TypeName, content.Id),
                        Resource = content,
                    });
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
            fhir5.Hl7.Fhir.Model.Subscription s5 = _idSubscriptionR5Dict[subscriptionId];

            // get our bundle we want to send
            BundleForSubscriptionNotification(
                subscription,
                s5,
                content,
                out Bundle bundle,
                out long subscriptionEventCount);

            string json = _fhirSerializer.SerializeToString(bundle);

            // check for a rest-hook
            if (s5.ChannelType.Code == fhirP5.SubscriptionChannelType.rest_hook.Code)
            {
                // send via hook
                bool notified = NotificationManager.TryNotifyRestHook(
                    s5.Id,
                    s5.Endpoint,
                    s5.Header,
                    json,
                    contentTypeName,
                    contentId,
                    subscriptionEventCount);

                if (notified)
                {
                    // check to see if we need to clear an error
                    if (_idSubscriptionDict[subscriptionId].Status == Subscription.SubscriptionStatus.Error)
                    {
                        _idSubscriptionDict[subscriptionId].Status = Subscription.SubscriptionStatus.Active;
                        _idSubscriptionR5Dict[subscriptionId].Status = fhir5.Hl7.Fhir.Model.SubscriptionState.Active;
                        //_idSubscriptionDict[subscription.Id].Error = null;
                    }
                }
                else
                {
                    // done
                    _idSubscriptionDict[subscriptionId].Status = Subscription.SubscriptionStatus.Error;
                    _idSubscriptionR5Dict[subscriptionId].Status = fhir5.Hl7.Fhir.Model.SubscriptionState.Error;
                    //_idSubscriptionDict[subscription.Id].Error = ErrorConceptForString($"Endpoint returned: {response.ReasonPhrase}", (int)response.StatusCode);
                }
            }

            if (s5.ChannelType.Code == fhirP5.SubscriptionChannelType.email.Code)
            {
                // send via email
                bool notified = NotificationManager.TryNotifyEmail(
                    s5.Id,
                    s5.Endpoint,
                    s5.ContentType,
                    s5.Content.ToString(),
                    json,
                    contentTypeName,
                    contentId,
                    subscriptionEventCount);

                if (notified)
                {
                    // check to see if we need to clear an error
                    if (_idSubscriptionDict[subscriptionId].Status == Subscription.SubscriptionStatus.Error)
                    {
                        _idSubscriptionDict[subscriptionId].Status = Subscription.SubscriptionStatus.Active;
                        _idSubscriptionR5Dict[subscriptionId].Status = fhir5.Hl7.Fhir.Model.SubscriptionState.Active;
                        //_idSubscriptionDict[subscription.Id].Error = null;
                    }
                }
                else
                {
                    // done
                    _idSubscriptionDict[subscriptionId].Status = Subscription.SubscriptionStatus.Error;
                    _idSubscriptionR5Dict[subscriptionId].Status = fhir5.Hl7.Fhir.Model.SubscriptionState.Error;
                    //_idSubscriptionDict[subscription.Id].Error = ErrorConceptForString($"Endpoint returned: {response.ReasonPhrase}", (int)response.StatusCode);
                }
            }

            if (s5.ChannelType.Code == fhirP5.SubscriptionChannelType.websocket.Code)
            {
                // send via websocket
                WebsocketManager.QueueMessagesForSubscription(s5, json);
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
                _instance = new SubscriptionManagerR4();
            }
        }
    }
}
