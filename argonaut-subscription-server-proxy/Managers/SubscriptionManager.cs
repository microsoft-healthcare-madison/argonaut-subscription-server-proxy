using argonaut_subscription_server_proxy.Models;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace argonaut_subscription_server_proxy.Managers
{
    public class SubscriptionManager
    {
        #region Class Types . . .

        #endregion Class Types . . .

        #region Class Variables . . .

        /// <summary>The instance for singleton pattern.</summary>
        private static SubscriptionManager _instance;

        #endregion Class Variables . . .

        #region Instance Variables . . .

        /// <summary>Dictionary of subscriptions, by ID.</summary>
        private Dictionary<string, fhir.Subscription> _idSubscriptionDict;

        /// <summary>Dictionary of identifier locks.</summary>
        private Dictionary<string, object> _idLockDict;

        /// <summary>A random-number generator for this class.</summary>
        private Random _rand;

        private Dictionary<string, SubscriptionFilterNode> _resourceSubscriptionDict;
        private object _resourceSubscriptionDictLock;

        private static HashSet<string> _supportedChannelTypes;

        private static Queue<FhirClient> _fhirClientQ;
        private static object _fhirClientQLock;

        #endregion Instance Variables . . .

        #region Constructors . . .

        private SubscriptionManager()
        {
            // **** create our index objects ****

            _idSubscriptionDict = new Dictionary<string, fhir.Subscription>();
            _idLockDict = new Dictionary<string, object>();
            _resourceSubscriptionDict = new Dictionary<string, SubscriptionFilterNode>();
            _resourceSubscriptionDictLock = new object();
            _rand = new Random();
            _supportedChannelTypes = new HashSet<string>()
            {
                "rest-hook"
            };
            _fhirClientQ = new Queue<FhirClient>();
            _fhirClientQLock = new object();
        }

        #endregion Constructors . . .

        #region Class Interface . . .

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Initializes this object.</summary>
        ///
        /// <remarks>Gino Canessa, 7/2/2019.</remarks>
        ///-------------------------------------------------------------------------------------------------

        public static void Init()
        {
            // **** make an instance ****

            CheckOrCreateInstance();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Gets a list of all currently known Subscriptions.</summary>
        ///
        /// <remarks>Gino Canessa, 7/2/2019.</remarks>
        ///
        /// <returns>The Subscription list.</returns>
        ///-------------------------------------------------------------------------------------------------

        public static List<fhir.Subscription> GetSubscriptionList()
        {
            // **** return our list of known subscriptions ****

            return _instance._idSubscriptionDict.Values.ToList<fhir.Subscription>();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Adds or updates a Subscription.</summary>
        ///
        /// <remarks>Gino Canessa, 7/2/2019.</remarks>
        ///
        /// <param name="subscription">The subscription.</param>
        ///-------------------------------------------------------------------------------------------------

        public static void AddOrUpdate(fhir.Subscription subscription)
        {
            _instance._AddOrUpdate(subscription);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Gets a subscription.</summary>
        ///
        /// <remarks>Gino Canessa, 7/2/2019.</remarks>
        ///
        /// <param name="id">The identifier.</param>
        ///
        /// <returns>The subscription.</returns>
        ///-------------------------------------------------------------------------------------------------

        public static fhir.Subscription GetSubscription(string id)
        {
            if ((string.IsNullOrEmpty(id)) || (!_instance._idSubscriptionDict.ContainsKey(id)))
            {
                return null;
            }

            return _instance._idSubscriptionDict[id];
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Handles a POST of a Subscription object.</summary>
        ///
        /// <remarks>Gino Canessa, 8/1/2019.</remarks>
        ///
        /// <param name="content">       The content.</param>
        /// <param name="subscription">  [out] The subscription.</param>
        /// <param name="statusCode">    [out] The status code.</param>
        /// <param name="failureContent">[out] The failure content.</param>
        ///-------------------------------------------------------------------------------------------------

        public static void HandlePost(
                                        string content, 
                                        out fhir.Subscription subscription,
                                        out HttpStatusCode statusCode,
                                        out string failureContent
                                        )
        {
            _instance._HandlePost(
                content, 
                out subscription,
                out statusCode,
                out failureContent
                );
        }

        public static bool HandleDelete(HttpRequest request)
        {
            return _instance._HandleDelete(request);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Process the encounter described by content.</summary>
        ///
        /// <remarks>Gino Canessa, 8/16/2019.</remarks>
        ///
        /// <param name="content"> The content.</param>
        /// <param name="location">The location.</param>
        ///-------------------------------------------------------------------------------------------------

        public static void ProcessEncounter(string content, Uri location)
        {
            // **** run this async and return immediately, we don't care about results ****

            _ = System.Threading.Tasks.Task.Run((Action)(() => _instance._ProcessEncounter(content, location)));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>URL for subscription.</summary>
        ///
        /// <remarks>Gino Canessa, 8/1/2019.</remarks>
        ///
        /// <param name="subscriptionId">The subscription id.</param>
        ///
        /// <returns>A string.</returns>
        ///-------------------------------------------------------------------------------------------------

        public static string UrlForSubscription(string subscriptionId)
        {
            return (new Uri(
                new Uri(Program.Configuration["Server_Public_Url"], UriKind.Absolute),
                new Uri($"Subscription/{subscriptionId}", UriKind.Relative))
                ).ToString();
        }

        public static bool TryGetSubscription(string subscriptionId, out fhir.Subscription subscription)
        {
            if (_instance._idSubscriptionDict.ContainsKey(subscriptionId))
            {
                subscription = _instance._idSubscriptionDict[subscriptionId];
                return true;
            }
            subscription = null;
            return false;
        }

        public static bool Exists(string subscriptionId)
        {
            if (subscriptionId.StartsWith("Subscription/"))
            {
                return _instance._idSubscriptionDict.ContainsKey(subscriptionId.Replace("Subscription/", ""));
            }
            return _instance._idSubscriptionDict.ContainsKey(subscriptionId);
        }

        #endregion Class Interface . . .

        #region Instance Interface . . .

        #endregion Instance Interface . . .

        #region Internal Functions . . .

        private bool _HandleDelete(HttpRequest request)
        {
            // **** pull the URL components out of the request ****

            string[] components = request.Path.ToUriComponent().Split('/');

            bool foundSubscriptionComponent = false;

            // **** traverse components ****

            for (int componentIndex = 0; componentIndex < components.Length; componentIndex++)
            {
                // **** grab this component ****

                string component = components[componentIndex];

                // **** make sure that we hit a 'Subscription' component ****

                if (component.Equals("subscription", StringComparison.OrdinalIgnoreCase))
                {
                    foundSubscriptionComponent = true;
                    continue;
                }

                // **** only look for a GUID AFTER we have the subscription part ****

                if (foundSubscriptionComponent)
                {
                    // **** attempt to parse ****

                    if (Guid.TryParse(component, out _))
                    {
                        // **** remove this entry ****

                        return Remove(component);
                    }
                }
            }

            // **** still here is failure ****

            return false;
        }
        
        private void RemoveSubscriptionFromNodeTree(
                                                    fhir.Subscription subscription, 
                                                    SubscriptionFilterNode node, 
                                                    out bool isEmpty
                                                    )
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
                // **** recurse ****

                RemoveSubscriptionFromNodeTree(subscription, node.Inclusions[key], out bool subIsEmpty);

                if (subIsEmpty)
                {
                    // **** remove this node ****

                    lock (_resourceSubscriptionDictLock)
                    {
                        node.Inclusions.Remove(key);
                    }
                }
            }

            string[] exclusionKeys = node.Exclusions.Keys.ToArray<string>();
            foreach (string key in exclusionKeys)
            {
                // **** recurse ****

                RemoveSubscriptionFromNodeTree(subscription, node.Exclusions[key], out bool subIsEmpty);

                if (subIsEmpty)
                {
                    // **** remove this node ****

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

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Removes the subscription specified by ID.</summary>
        ///
        /// <remarks>Gino Canessa, 8/16/2019.</remarks>
        ///
        /// <param name="id">The identifier.</param>
        ///
        /// <returns>True if it succeeds, false if it fails.</returns>
        ///-------------------------------------------------------------------------------------------------

        private bool Remove(string id)
        {
            if ((string.IsNullOrEmpty(id)) || (!_idSubscriptionDict.ContainsKey(id)))
            {
                return false;
            }

            // **** grab this object ****

            fhir.Subscription subscription = _idSubscriptionDict[id];

            // **** traverse trackings looking for this subscription ****

            string[] resourceKeys = _resourceSubscriptionDict.Keys.ToArray<string>();
            foreach (string key in resourceKeys)
            {
                // **** check this node ****

                RemoveSubscriptionFromNodeTree(subscription, _resourceSubscriptionDict[key], out bool isEmpty);

                if (isEmpty)
                {
                    lock (_resourceSubscriptionDictLock)
                    {
                        _resourceSubscriptionDict.Remove(key);
                    }
                }
            }

            // **** remove from the main dictionary ****

            _idSubscriptionDict.Remove(id);

            // **** remove from the lock dictionary ****

            if (_idLockDict.ContainsKey(id))
            {
                _idLockDict.Remove(id);
            }

            // **** log this addition ****

            Console.WriteLine($" <<< removed Subscription: {id}");

            // **** success ****

            return true;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Gets encounter patient groups.</summary>
        ///
        /// <remarks>Gino Canessa, 9/9/2019.</remarks>
        ///
        /// <param name="encounter">         The encounter.</param>
        /// <param name="List<string>groups">[out] The list.</param>
        ///-------------------------------------------------------------------------------------------------

        private void GetEncounterPatientGroupKeys(Hl7.Fhir.Model.Encounter encounter, out List<string>groups)
        {
            FhirClient client = null;
            groups = new List<string>();

            // **** attempt to get groups this patient may belong to ****

            try
            {
                // **** get a FHIR client ****

                if (!TryGetFhirClient(out client))
                {
                    return;
                }

                // **** ask for the groups for this patient ****

                Hl7.Fhir.Model.Bundle results = client.Search<Hl7.Fhir.Model.Group>(new string[] { $"member={encounter.Subject.Reference}" });

                if ((results != null) &&
                    (results.Entry != null) &&
                    (results.Entry.Count > 0))
                {
                    // **** traverse entries ****

                    foreach (Hl7.Fhir.Model.Bundle.EntryComponent entry in results.Entry)
                    {
                        groups.Add($"patient:{entry.Resource.ResourceType}/{entry.Resource.Id}");
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
                    // **** return to our queue ****

                    ReturnFhirClientToQ(ref client);
                }
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Process the encounter described by content.</summary>
        ///
        /// <remarks>Gino Canessa, 8/15/2019.</remarks>
        ///
        /// <param name="content"> The content.</param>
        /// <param name="location">The location.</param>
        ///-------------------------------------------------------------------------------------------------

        private void _ProcessEncounter(string content, Uri location)
        {
            FhirJsonParser parser = new FhirJsonParser();
            List<fhir.Subscription> subscriptions = new List<fhir.Subscription>();

            Hl7.Fhir.Model.Encounter encounter = null;

            // **** check to see if this resource is tracked (any subscriptions) ****

            if (!_resourceSubscriptionDict.ContainsKey("Encounter"))
            {
                // **** done ****

                return;
            }

            // **** attempt to parse the encounter ****

            try 
            {
                if ((!string.IsNullOrEmpty(content)) && (content.Length > 20))
                {
                    // **** attempt to parse this encounter ****

                    encounter = parser.Parse<Hl7.Fhir.Model.Encounter>(content);
                }
            }
            catch (Exception)
            {
                // **** ignore, likely an operation outcome or empty content ****
            }

            // **** check for not having an encounter ****

            if (encounter == null)
            {
                FhirClient client = null;

                // **** attempt to retrieve the encounter ****

                try
                {
                    // **** get a FHIR client ****

                    if (!TryGetFhirClient(out client))
                    {
                        return;
                    }

                    // **** read the specified resource ****

                    encounter = client.Read<Hl7.Fhir.Model.Encounter>(location);
                }
                finally
                {
                    // **** return the client ****

                    ReturnFhirClientToQ(ref client);
                }
            }

            // **** check for no resource ****

            if (encounter == null)
            {
                Console.WriteLine("Could not get Encounter resource!");
                return;
            }

            // ***** parse the encounter ****

            try
            {
                // **** build a list of all our keys ****

                List<string> searchKeys = new List<string>();

                // **** add our patient match key ****

                searchKeys.Add($"patient:{encounter.Subject.Reference}");

                // **** get the groups this patient belongs to ****

                GetEncounterPatientGroupKeys(encounter, out List<string> patientGroupKeys);

                // **** add our patient group keys ****

                searchKeys.AddRange(patientGroupKeys);

                // **** sort our keys ****

                searchKeys.Sort();

                // **** create a hashset of the keys (for exclusion checking) ****

                HashSet<string> searchSet = searchKeys.ToHashSet<string>();

                // **** find the subscriptions for this resource ****

                FindSubscriptionsForKeys(
                    _resourceSubscriptionDict["Encounter"],
                    searchKeys,
                    searchSet,
                    ref subscriptions
                    );

                // **** notify all subscriptions ****

                foreach (fhir.Subscription subscription in subscriptions)
                {
                    TryNotifySubscription(subscription.Id, encounter);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ProcessEncounter <<< caught exception: {ex.Message}");
            }
        }

        private void FindSubscriptionsForKeys(
                                                SubscriptionFilterNode node,
                                                List<string> matchKeys,
                                                HashSet<string> matchHashSet,
                                                ref List<fhir.Subscription> subscriptions
                                                )
        {
            // **** add subscriptions on this level ****

            if (node.Subscriptions.Count > 0)
            {
                subscriptions.AddRange(node.Subscriptions);
            }

            // **** check each of our keys ****

            foreach (string key in matchKeys)
            {
                // **** check for inclusions ****

                if (node.Inclusions.ContainsKey(key))
                {
                    // **** process this node ***

                    FindSubscriptionsForKeys(node.Inclusions[key], matchKeys, matchHashSet, ref subscriptions);
                }
            }

            // **** check exclusions ****

            foreach (string key in node.Exclusions.Keys.ToArray<string>())
            {
                // **** check for not existing ****

                if (!matchHashSet.Contains(key))
                {
                    // **** process this node ****

                    FindSubscriptionsForKeys(node.Exclusions[key], matchKeys, matchHashSet, ref subscriptions);
                }
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Handles a POST of a Subscription object.</summary>
        ///
        /// <remarks>Gino Canessa, 7/30/2019.</remarks>
        ///
        /// <param name="content">       The content.</param>
        /// <param name="subscription">  [out] The subscription.</param>
        /// <param name="statusCode">    [out] The status code.</param>
        /// <param name="failureContent">[out] The failure content.</param>
        ///-------------------------------------------------------------------------------------------------

        private void _HandlePost(
                                    string content,
                                    out fhir.Subscription subscription,
                                    out HttpStatusCode statusCode,
                                    out string failureContent
                                    )
        {
            subscription = null;
            statusCode = System.Net.HttpStatusCode.Created;
            failureContent = string.Empty;

            // **** attempt to parse our content into a subscription request ****
            
            try
            {
                // **** parse the subscription ****

                subscription = JsonConvert.DeserializeObject<fhir.Subscription>(content);

                // **** check for no parsed object ****

                if (subscription == null)
                {
                    statusCode = HttpStatusCode.BadRequest;
                    failureContent = "Invalid subscription";
                    return;
                }

                // **** check for no channel ****

                if (subscription.Channel == null)
                {
                    statusCode = HttpStatusCode.BadRequest;
                    failureContent = "Invalid channel";
                    return;
                }

                // **** check for invalid content type ****

                if ((subscription.Channel.Payload == null) ||
                    (subscription.Channel.Payload.ContentType != "application/fhir+json"))
                {
                    statusCode = HttpStatusCode.BadRequest;
                    failureContent = $"Invalid channel payload type:" +
                        ((subscription.Channel.Payload != null) ? subscription.Channel.Payload.ContentType : "''") +
                        $" currently only 'application/fhir+json' is supported.";
                    return;
                }

                // **** create an id (if necessary) ****

                if (string.IsNullOrEmpty(subscription.Id))
                {
                    subscription.Id = Guid.NewGuid().ToString();
                }

                // **** add or update internally ****

                _AddOrUpdate(subscription);

                // **** check for rest-hook ****

                bool isRest = false;
                
                if ((subscription.Channel != null) &&
                    (subscription.Channel.Type != null) &&
                    (subscription.Channel.Type.Coding != null))
                {
                    foreach (fhir.Coding coding in subscription.Channel.Type.Coding)
                    {
                        if (coding.Code == fhir.SubscriptionChannelTypeCodes.rest_hook.Code)
                        {
                            // **** check for an endpoint ****

                            if ((string.IsNullOrEmpty(subscription.Channel.Endpoint)) ||
                                (!Uri.TryCreate(subscription.Channel.Endpoint, UriKind.Absolute, out _)))
                            {
                                statusCode = HttpStatusCode.BadRequest;
                                failureContent = $"Invalid Endpoint for rest-hook subscription: {subscription.Channel.Endpoint}";
                                return;
                            }

                            // **** valid rest-hook ****

                            isRest = true;
                            break;
                        }

                        if (!_supportedChannelTypes.Contains(coding.Code))
                        {
                            statusCode = HttpStatusCode.BadRequest;
                            failureContent = $"Invalid channel type requested: {coding.Code}";
                            return;
                        }
                    }
                }

                if (isRest)
                {
                    string id = subscription.Id;

                    // **** attempt to validate the endpoint ****

                    _ = System.Threading.Tasks.Task.Run((Action)(() => HandshakeRestHook(id)));
                }
                else
                {
                    // **** just mark active ****

                    _idSubscriptionDict[subscription.Id].Status = fhir.SubscriptionStatusCodes.ACTIVE;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SubscriptionManager._HandlePost <<< caught exception: {ex}");
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Adds or updates a Topic.</summary>
        ///
        /// <remarks>Gino Canessa, 7/2/2019.</remarks>
        ///
        /// <param name="subscription">The subscription.</param>
        ///-------------------------------------------------------------------------------------------------

        private bool _AddOrUpdate(fhir.Subscription subscription)
        {
            // **** check for an existing topic (may need to remove URL for cleanup) ****

            if (_idSubscriptionDict.ContainsKey(subscription.Id))
            {
                // **** remove from the main dict ****

                _idSubscriptionDict.Remove(subscription.Id);
            }

            // **** create a lock object for this subscription ****

            if (!_idLockDict.ContainsKey(subscription.Id))
            {
                _idLockDict.Add(subscription.Id, new object());
            }

            // **** add to the main dictionary ****

            _idSubscriptionDict.Add(subscription.Id, subscription);

            // **** log this addition ****

            Console.WriteLine($" <<< added Subscription:" +
                $" {subscription.Id}" +
                $" ({subscription.Channel.Type.Coding[0].Code}," +
                $" {subscription.Channel.Payload.Content})"
                );
            
            // **** get the topic for this subscription ****

            fhir.Topic topic = TopicManager.GetTopic(Program.ResourceIdFromReference(subscription.Topic.reference));

            // **** check for unknown topic ****

            if (topic == null)
            {
                Console.WriteLine($"SubscriptionManager._AddOrUpdate <<< could not find topic: {subscription.Topic.reference}");
                return false;
            }

            // **** track this subscription (based on topic) ****

            if (!TrackSubscription(subscription, topic))
            {
                // **** make sure partial updates are removed ****

                Remove(subscription.Id);

                // **** failed ****

                return false;
            }

            // **** still here is success ****

            return true;
        }

        private void TrackResource(string resourceName)
        {
            lock (_resourceSubscriptionDictLock)
            {
                // **** make sure this resource is tracked ****

                if (!_resourceSubscriptionDict.ContainsKey(resourceName))
                {
                    _resourceSubscriptionDict.Add(resourceName, new SubscriptionFilterNode()
                    {
                        Subscriptions = new List<fhir.Subscription>(),
                        Inclusions = new Dictionary<string, SubscriptionFilterNode>(),
                        Exclusions = new Dictionary<string, SubscriptionFilterNode>(),
                    })
                    ;
                }
            }
        }

        private bool TrackSubscription(fhir.Subscription subscription, fhir.Topic topic)
        {
            // **** check for unfiltered subscriptions ****

            if ((subscription.FilterBy == null) || (subscription.FilterBy.Length == 0))
            {
                // **** check for resource types ****

                if ((topic.ResourceTrigger.ResourceType == null) ||
                    (topic.ResourceTrigger.ResourceType.Length == 0))
                {
                    // **** reject this subscription ****

                    Console.WriteLine("SubscriptionManager.TrackSubscription <<< invalid resource triggers: [].");
                    return false;
                }
                else
                {
                    // **** loop over resource types ****

                    foreach (string resourceName in topic.ResourceTrigger.ResourceType)
                    {
                        TrackResource(resourceName);
                        lock (_resourceSubscriptionDictLock)
                        {
                            _resourceSubscriptionDict[resourceName].Subscriptions.Add(subscription);
                        }
                    }
                }

                // **** done with this type of subscription ****

                return true;
            }

            // **** for now, reject any subscription that starts with an exclusion ****

            if (subscription.FilterBy[0].MatchType == "not-in")
            {
                Console.WriteLine($"SubscriptionManager.TrackSubscription <<<" +
                    $" first match cannot be {subscription.FilterBy[0].MatchType}");
                return false;
            }

            // **** get our list of filters ****

            List<fhir.SubscriptionFilterBy> filters = subscription.FilterBy.ToList<fhir.SubscriptionFilterBy>();

            // **** sort by field, match, value ****

            filters.Sort((a, b) => ($"{a.Name}{a.MatchType}{a.Value}".CompareTo($"{b.Name}{b.MatchType}{b.Value}")));

            // **** loop over resources in the topic ****

            foreach (string resourceName in topic.ResourceTrigger.ResourceType)
            {
                // **** make sure this resource is tracked ****

                TrackResource(resourceName);

                // **** track based on filters ****

                if (!TrackFilterNode(subscription, _resourceSubscriptionDict[resourceName], filters))
                {
                    return false;
                }
            }

            // **** still here is success ****

            return true;
        }

        private bool TrackFilterNode(
                                    fhir.Subscription subscription,
                                    SubscriptionFilterNode node,
                                    List<fhir.SubscriptionFilterBy> filters
                                    )
        {
            // **** check for no filters (done) ****

            if (filters.Count == 0)
            {
                // **** add the subscription to this node ****

                node.Subscriptions.Add(subscription);

                // **** done ****

                return true;
            }

            // **** grab the first filter (sorted) ****

            fhir.SubscriptionFilterBy filter = filters[0];
            filters.RemoveAt(0);

            // **** check for no value ****

            if (string.IsNullOrEmpty(filter.Value))
            {
                // **** cannot add this ****

                Console.WriteLine($"SubscriptionManager.TrackFilterNode <<<" +
                    $" invalid value is null! subscription: {subscription.Id}");
                return false;
            }

            bool success = true;

            // **** split possible values ****

            string[] filterValues = filter.Value.Split(',');

            foreach (string filterValue in filterValues)
            {
                // **** build the key ****

                string filterKey = $"{filter.Name}:{filterValue}";

                // **** add to the correct type ****

                switch (filter.MatchType)
                {
                    case "not-in":
                    case "!=":
                    case "ne":
                        // **** make sure this field is in exclusions ****

                        lock (_resourceSubscriptionDictLock)
                        {
                            if (!node.Exclusions.ContainsKey(filterKey))
                            {
                                node.Exclusions.Add(filterKey, new SubscriptionFilterNode()
                                {
                                    Subscriptions = new List<fhir.Subscription>(),
                                    Inclusions = new Dictionary<string, SubscriptionFilterNode>(),
                                    Exclusions = new Dictionary<string, SubscriptionFilterNode>()
                                });
                            }
                        }

                        // **** continue traversing, stop on failures ****

                        if (!TrackFilterNode(subscription, node.Exclusions[filterKey], filters))
                        {
                            return false;
                        }

                        break;

                    case "in":
                    case "=":
                    case "eq":
                        // **** make sure this field is in the inclusions ****

                        lock (_resourceSubscriptionDictLock)
                        {
                            if (!node.Inclusions.ContainsKey(filterKey))
                            {
                                node.Inclusions.Add(filterKey, new SubscriptionFilterNode()
                                {
                                    Subscriptions = new List<fhir.Subscription>(),
                                    Inclusions = new Dictionary<string, SubscriptionFilterNode>(),
                                    Exclusions = new Dictionary<string, SubscriptionFilterNode>()
                                });
                            }
                        }

                        // **** continue traversing, stop of failures ****

                        if (!TrackFilterNode(subscription, node.Inclusions[filterKey], filters))
                        {
                            return false;
                        }
                        break;

                    default:
                        // **** unhandled match type ****

                        Console.WriteLine($"SubscriptionManager.TrackFilterNode <<<" +
                            $" invalid MatchType: {filter.MatchType}! subscription: {subscription.Id}");
                        return false;

                        break;
                }

            }

            return success;
        }

        private void DumpNode(ISourceNode node)
        {
            Console.WriteLine(string.Format("{0,70} {1,20} {2}", "Location", "Name", "Text"));
            _DumpNode(node);
        }

        private void _DumpNode(ISourceNode node)
        {
            Console.WriteLine($"{node.Location,70} {node.Name,20} {node.Text}");

            foreach (ISourceNode child in node.Children())
            {
                _DumpNode(child);
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Handshake REST hook.</summary>
        ///
        /// <remarks>Gino Canessa, 7/30/2019.</remarks>
        ///
        /// <param name="subscriptionId">The subscription id.</param>
        ///
        /// <returns>An asynchronous result that yields true if it succeeds, false if it fails.</returns>
        ///-------------------------------------------------------------------------------------------------

        private bool HandshakeRestHook(string subscriptionId)
        {
            // **** sanity checks ****

            if ((string.IsNullOrEmpty(subscriptionId)) ||
                (!_idSubscriptionDict.ContainsKey(subscriptionId)))
            {
                return false;
            }

            fhir.Subscription subscription = _idSubscriptionDict[subscriptionId];

            if ((subscription.Channel == null) ||
                (subscription.Channel.Endpoint == null) ||
                (string.IsNullOrEmpty(subscription.Channel.Endpoint)))
            {
                // **** nothing to do ****

                _idSubscriptionDict[subscription.Id].Status = fhir.SubscriptionStatusCodes.ERROR;

                return false;
            }

            // **** attempt to send the notification ****

            if (TryNotifySubscription(subscriptionId, null))
            {
                // **** update in the manager (if it hasn't been removed) ****

                if (_idSubscriptionDict.ContainsKey(subscriptionId))
                {
                    _idSubscriptionDict[subscriptionId].Status = fhir.SubscriptionStatusCodes.ACTIVE;
                }
            }
            else
            {
                // **** update to error in the manager (if it hasn't been removed) ****

                if (_idSubscriptionDict.ContainsKey(subscriptionId))
                {
                    _idSubscriptionDict[subscriptionId].Status = fhir.SubscriptionStatusCodes.ERROR;
                }
            }

            // **** tell the user ****

            Console.WriteLine($" <<< Subscription {subscription.Id} set to active!");

            // **** done ****

            return true;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Attempts to get fhir client a FhirClient from the given string.</summary>
        ///
        /// <remarks>Gino Canessa, 9/9/2019.</remarks>
        ///
        /// <param name="client">[out] The client.</param>
        ///
        /// <returns>True if it succeeds, false if it fails.</returns>
        ///-------------------------------------------------------------------------------------------------

        private bool TryGetFhirClient(out FhirClient client)
        {
            // **** check to see if we can get a client from the queue ****

            lock (_fhirClientQLock)
            {
                if (_fhirClientQ.Count > 0)
                {
                    client = _fhirClientQ.Dequeue();
                    return true;
                }

                // **** attempt to create our client ****

                try
                {
                    client = new FhirClient(Program.FhirServerUrl)
                    {
                        PreferredFormat = ResourceFormat.Json,
                        PreferredReturn = Prefer.ReturnRepresentation,
                    };

                    // **** valid ****

                    return true;
                }
                catch (Exception ex)
                {
                    // **** log for reference ****

                    Console.WriteLine($"SubscriptionMananger.TryGetFhirClient <<<" +
                        $" failed url: {Program.FhirServerUrl}," +
                        $" exception: {ex.Message}");
                }
            }

            // **** still here means failure ****

            client = null;
            return false;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Returns fhir client to q.</summary>
        ///
        /// <remarks>Gino Canessa, 9/9/2019.</remarks>
        ///
        /// <param name="client">[out] The client.</param>
        ///-------------------------------------------------------------------------------------------------

        private void ReturnFhirClientToQ(ref FhirClient client)
        {
            // **** thread safe ****

            lock (_fhirClientQLock)
            {
                _fhirClientQ.Enqueue(client);
                client = null;
            }
        }

        public static void BundleForSubscriptionNotification(
                                                            fhir.Subscription subscription,
                                                            Hl7.Fhir.Model.Resource content,
                                                            out Hl7.Fhir.Model.Bundle bundle,
                                                            out int eventCount
                                                            )
        {

            // **** check our event count ****

            lock (_instance._idLockDict[subscription.Id])
            {
                // **** get the event count ****

                eventCount = (int)subscription.EventCount;

                // **** check if we are incrementing the event ****

                if (content != null)
                {
                    subscription.EventCount = ++eventCount;
                }
            }

            // **** create a bundle for this message message ****

            bundle = new Hl7.Fhir.Model.Bundle()
            {
                //Identifier = new Hl7.Fhir.Model.Identifier("http://terminology.hl7.org/CodeSystem/ietf-uuid", Guid.NewGuid().ToString()),
                Type = Hl7.Fhir.Model.Bundle.BundleType.History,
                Timestamp = new DateTimeOffset(DateTime.Now),
                Meta = new Hl7.Fhir.Model.Meta()
            };

            // **** setup our extensions for the bundle ****

            bundle.Meta.Extension.Add(new Hl7.Fhir.Model.Extension()
            {
                Url = "http://hl7.org/fhir/StructureDefinition/subscriptionEventCount",
                Value = new Hl7.Fhir.Model.UnsignedInt(eventCount)
            });

            bundle.Meta.Extension.Add(new Hl7.Fhir.Model.Extension()
            {
                Url = "http://hl7.org/fhir/StructureDefinition/bundleEventCount",
                Value = new Hl7.Fhir.Model.UnsignedInt(content == null ? 0 : 1)
            });

            bundle.Meta.Extension.Add(new Hl7.Fhir.Model.Extension()
            {
                Url = "http://hl7.org/fhir/StructureDefinition/subscriptionStatus",
                Value = new Hl7.Fhir.Model.FhirString(subscription.Status)
            });

            bundle.Meta.Extension.Add(new Hl7.Fhir.Model.Extension()
            {
                Url = "http://hl7.org/fhir/StructureDefinition/subscriptionTopicUrl",
                Value = new Hl7.Fhir.Model.FhirString(subscription.Topic.reference)
            });

            bundle.Meta.Extension.Add(new Hl7.Fhir.Model.Extension()
            {
                Url = "http://hl7.org/fhir/StructureDefinition/subscriptionUrl",
                Value = new Hl7.Fhir.Model.FhirString(UrlForSubscription(subscription.Id))
            });

            // **** add the entry node ****

            bundle.Entry = new List<Hl7.Fhir.Model.Bundle.EntryComponent>();

            // **** check if we are adding contents ****

            if ((content != null) && (subscription.Channel.Payload.Content != fhir.SubscriptionChannelPayloadContentCodes.EMPTY))
            {
                // **** add depending on type ****

                if (subscription.Channel.Payload.Content == fhir.SubscriptionChannelPayloadContentCodes.ID_ONLY)
                {
                    // **** add the URL, but no resource ****
                    
                    bundle.AddResourceEntry(null, Program.UrlForResourceId(content.TypeName, content.Id));
                }
                else
                {
                    // **** add the URL and the resource ****

                    bundle.AddResourceEntry(content, Program.UrlForResourceId(content.TypeName, content.Id));
                }
            }
        }

        private bool TryNotifyRestHook(fhir.Subscription subscription, Hl7.Fhir.Model.Bundle bundle)
        {
            // **** send the request to the endpoint ****

            try
            {
                // **** serialize using the Firely serialization engine ****

                Hl7.Fhir.Serialization.FhirJsonSerializer serializer = new Hl7.Fhir.Serialization.FhirJsonSerializer();

                // **** build our request ****

                HttpRequestMessage request = new HttpRequestMessage()
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(subscription.Channel.Endpoint),
                    Content = new StringContent(serializer.SerializeToString(bundle), Encoding.UTF8, "application/fhir+json")
                };

                // **** check for additional headers ****

                if ((subscription.Channel.Header != null) && (subscription.Channel.Header.Length > 0))
                {
                    // **** add headers ****

                    foreach (string header in subscription.Channel.Header)
                    {
                        // **** parse the existing header ****

                        int seperatorLoc = header.IndexOf(':');

                        if (seperatorLoc < 1)
                        {
                            continue;
                        }

                        // **** add this header (skip the seperator and the following space) ****

                        request.Headers.Add(header.Substring(0, seperatorLoc), header.Substring(seperatorLoc + 2));
                    }
                }

                // **** send our request ****

                HttpResponseMessage response = Program.RestClient.SendAsync(request).Result;

                //// **** send the request ****

                //HttpResponseMessage response = Program.RestClient.PostAsync(
                //    subscription.Channel.Endpoint,
                //    new StringContent(serializer.SerializeToString(bundle), Encoding.UTF8, "application/fhir+json")
                //    ).Result;

                // **** check the status code ****

                if ((response.StatusCode != System.Net.HttpStatusCode.OK) &&
                    (response.StatusCode != System.Net.HttpStatusCode.Accepted) &&
                    (response.StatusCode != System.Net.HttpStatusCode.NoContent))
                {
                    // **** failure ****

                    Console.WriteLine($"SubscriptionManager.TryNotifySubscription <<< request to" +
                        $" {subscription.Channel.Endpoint}" +
                        $" returned: {response.StatusCode}");

                    // **** done ****

                    _idSubscriptionDict[subscription.Id].Status = fhir.SubscriptionStatusCodes.ERROR;

                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SubscriptionManager.TryNotifySubscription <<< request to" +
                    $" {subscription.Channel.Endpoint}" +
                    $" caused exception: {ex.Message}");

                _idSubscriptionDict[subscription.Id].Status = fhir.SubscriptionStatusCodes.ERROR;
                _idSubscriptionDict[subscription.Id].Error = new fhir.CodeableConcept[]
                {
                    new fhir.CodeableConcept()
                    {
                        Text = ex.Message,
                        Coding = new fhir.Coding[] 
                        {
                            new fhir.Coding()
                            {
                                Code = "1",
                                System = "http://example.org/primary/code/system/is/not/yet/defined",
                                Display = "Placeholder code system - will be defined Soon(TM)"
                            }
                        }
                    }
                };

                return false;
            }

            return true;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Attempts to notify subscription a Resource from the given string.</summary>
        ///
        /// <remarks>Gino Canessa, 8/2/2019.</remarks>
        ///
        /// <param name="subscriptionId">The subscription id.</param>
        /// <param name="content">       (Optional) The content.</param>
        ///
        /// <returns>True if it succeeds, false if it fails.</returns>
        ///-------------------------------------------------------------------------------------------------

        private bool TryNotifySubscription(string subscriptionId, Hl7.Fhir.Model.Resource content = null)
        {
            // **** sanity checks ****

            if ((string.IsNullOrEmpty(subscriptionId)) ||
                (!_idSubscriptionDict.ContainsKey(subscriptionId)))
            {
                // **** fail ****

                return false;
            }

            // **** get the subscription ****

            fhir.Subscription subscription = _idSubscriptionDict[subscriptionId];

            // **** get our bundle we want to send ****

            BundleForSubscriptionNotification(
                subscription, 
                content, 
                out Hl7.Fhir.Model.Bundle bundle, 
                out int eventCount
                );

            // **** check for a rest-hook ****

            if (subscription.Channel.Type.Coding[0].Code == fhir.SubscriptionChannelTypeCodes.rest_hook.Code)
            {
                TryNotifyRestHook(subscription, bundle);
            }

            // **** look for websocket connections ****

            WebsocketManager.QueueMessagesForSubscription(subscription, content);

            // **** tell the user ****

            if (content == null)
            {
                string messageType = (eventCount == 0) ? "handshake" : "heartbeat";

                Console.WriteLine($" <<< sent" +
                    $" {subscription.Id} ({subscription.Channel.Endpoint})" +
                    $" a {messageType} message");
            }
            else
            {
                Console.WriteLine($" <<< sent" +
                    $" {subscription.Id} ({subscription.Channel.Endpoint})" +
                    $" notification for: {Program.UrlForResourceId(content.TypeName, content.Id)}");
            }

            // **** done ****

            return true;
        }



        ///-------------------------------------------------------------------------------------------------
        /// <summary>Check or create instance.</summary>
        ///
        /// <remarks>Gino Canessa, 7/2/2019.</remarks>
        ///-------------------------------------------------------------------------------------------------

        private static void CheckOrCreateInstance()
        {
            if (_instance == null)
            {
                _instance = new SubscriptionManager();
            }
        }


        #endregion Internal Functions . . .

    }
}
