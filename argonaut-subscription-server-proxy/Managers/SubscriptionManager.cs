using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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

        private Dictionary<string, List<fhir.Subscription>> _filterSubscriptionListDict;

        private HashSet<string> _trackedResources;

        #endregion Instance Variables . . .

        #region Constructors . . .

        private SubscriptionManager()
        {
            // **** create our index objects ****

            _idSubscriptionDict = new Dictionary<string, fhir.Subscription>();
            _idLockDict = new Dictionary<string, object>();
            _filterSubscriptionListDict = new Dictionary<string, List<fhir.Subscription>>();
            _trackedResources = new HashSet<string>();
            _rand = new Random();
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
        /// <param name="content">     The content.</param>
        /// <param name="subscription">[out] The subscription.</param>
        ///-------------------------------------------------------------------------------------------------

        public static void HandlePost(string content, out fhir.Subscription subscription)
        {
            _instance._HandlePost(content, out subscription);
        }
        
        public static void ProcessEncounter(string content)
        {
            // **** run this async and return immediately, we don't care about results ****

            _ = System.Threading.Tasks.Task.Run((Action)(() => _instance._ProcessEncounter(content)));
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
                new Uri(Program.Configuration["Server_Listen_Url"], UriKind.Absolute),
                new Uri($"Subscription/{subscriptionId}", UriKind.Relative))
                ).ToString();
        }

        #endregion Class Interface . . .

        #region Instance Interface . . .

        #endregion Instance Interface . . .

        #region Internal Functions . . .

        private void _ProcessEncounter(string content)
        {
            // **** check to see if this is a valid encounter ****

            FhirJsonParser parser = new FhirJsonParser();

            List<fhir.Subscription> subscriptions = new List<fhir.Subscription>();

            try
            {
                // **** attempt to parse this ****

                Encounter encounter = parser.Parse<Encounter>(content);

                // **** check for generic subscriptions ****

                if (_filterSubscriptionListDict.ContainsKey("*:*"))
                {
                    subscriptions.AddRange(_filterSubscriptionListDict["*:*"]);
                }

                // **** check for generic Encounter subscriptions ****

                if (_filterSubscriptionListDict.ContainsKey("Encounter:*"))
                {
                    subscriptions.AddRange(_filterSubscriptionListDict["Encounter:*"]);
                }

                // **** build our filter match key ****

                string matchKey = $"Encounter:Patient:{encounter.Subject.Reference}";

                // **** check for matching filter subscriptions ****

                if (_filterSubscriptionListDict.ContainsKey(matchKey))
                {
                    subscriptions.AddRange(_filterSubscriptionListDict[matchKey]);
                }

                // **** notify all subscriptions ****

                foreach (fhir.Subscription subscription in subscriptions)
                {
                    TryNotifySubscription(subscription.Id, encounter);
                }

            }
            catch (Exception) { /* ignore */ }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Handles a POST of a Subscription object.</summary>
        ///
        /// <remarks>Gino Canessa, 7/30/2019.</remarks>
        ///
        /// <param name="content">     The content.</param>
        /// <param name="subscription">[out] The subscription.</param>
        ///-------------------------------------------------------------------------------------------------

        private void _HandlePost(string content, out fhir.Subscription subscription)
        {
            subscription = null;

            // **** attempt to parse our content into a subscription request ****
            
            try
            {
                // **** parse the subscription ****

                subscription = JsonConvert.DeserializeObject<fhir.Subscription>(content);

                // **** check for no result ****

                if (subscription == null)
                {
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

                if (subscription.Channel.Type.Text == "rest-hook")
                {
                    string id = subscription.Id;

                    // **** attempt to validate the endpoint ****

                    _ = System.Threading.Tasks.Task.Run((Action)(() => HandshakeRestHook(id)));
                }
                else
                {
                    // **** just mark active ****

                    _idSubscriptionDict[subscription.Id].Status = "active";
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

        private void _AddOrUpdate(fhir.Subscription subscription)
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

            // **** get the topic for this subscription ****

            fhir.Topic topic = TopicManager.GetTopic(subscription.Topic.reference);

            // **** check for unknown topic ****

            if (topic == null)
            {
                Console.WriteLine($"SubscriptionManager._AddOrUpdate <<< could not find topic: {subscription.Topic.reference}");
                return;
            }

            // **** check for unfiltered subscriptions ****

            if ((subscription.FilterBy == null) || (subscription.FilterBy.Length == 0))
            {
                // **** check for resource types ****

                if ((topic.ResourceTrigger.ResourceType == null) || 
                    (topic.ResourceTrigger.ResourceType.Length == 0))
                {
                    // **** all resources, all events ****

                    TrackSubscriptionFilter("*:*", subscription);

                    // **** flag tracking 'all' resource ****

                    TrackResource("*");
                }
                else
                {
                    // **** loop over resource types ****

                    foreach (string resourceName in topic.ResourceTrigger.ResourceType)
                    {
                        // **** all events on this resource ****

                        TrackSubscriptionFilter($"{resourceName}:*", subscription);

                        // **** flag tracking this resource ****

                        TrackResource(resourceName);
                    }
                }
            }
            else
            {
                // **** traverse filters ****

                foreach (fhir.SubscriptionFilterBy filterBy in subscription.FilterBy)
                {
                    // **** loop over resource types ****

                    foreach (string resourceName in topic.ResourceTrigger.ResourceType)
                    {
                        // **** check for no value ****

                        if (string.IsNullOrEmpty(filterBy.Value))
                        {
                            // **** all events on this resource ****

                            TrackSubscriptionFilter($"{resourceName}:{filterBy.Name}:*", subscription);

                            // **** flag tracking this resource ****

                            TrackResource(resourceName);

                            // **** go to next loop ****

                            continue;
                        }
                        
                        // **** split possible values ****

                        string[] filterValues = filterBy.Value.Split(',');
                        
                        foreach (string filterValue in filterValues)
                        {
                            // **** all events on this resource ****

                            TrackSubscriptionFilter($"{resourceName}:{filterBy.Name}:{filterValue}", subscription);

                            // **** flag tracking this resource ****

                            TrackResource(resourceName);
                        }
                    }
                }
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Track resource.</summary>
        ///
        /// <remarks>Gino Canessa, 8/2/2019.</remarks>
        ///
        /// <param name="resourceName">Name of the resource.</param>
        ///-------------------------------------------------------------------------------------------------

        private void TrackResource(string resourceName)
        {
            if (!_trackedResources.Contains(resourceName))
            {
                _trackedResources.Add(resourceName);
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Track subscription filter.</summary>
        ///
        /// <remarks>Gino Canessa, 8/2/2019.</remarks>
        ///
        /// <param name="key">         The key.</param>
        /// <param name="subscription">The subscription.</param>
        ///-------------------------------------------------------------------------------------------------

        private void TrackSubscriptionFilter(string key, fhir.Subscription subscription)
        {
            // **** check to see if this key doesn't exist ****

            if (!_filterSubscriptionListDict.ContainsKey(key))
            {
                _filterSubscriptionListDict.Add(key, new List<fhir.Subscription>());
            }

            // **** add our subscription ****

            _filterSubscriptionListDict[key].Add(subscription);

            Console.WriteLine($" <<< tracking {key} for {subscription.Id}");
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

                _idSubscriptionDict[subscription.Id].Status = "error";

                return false;
            }

            // **** attempt to send the notification ****

            if (TryNotifySubscription(subscriptionId, null))
            {
                // **** update in the manager ****

                _idSubscriptionDict[subscriptionId].Status = "active";
            }

            // **** tell the user ****

            Console.WriteLine($" <<< Subscription {subscription.Id} set to active!");

            // **** done ****

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

        private bool TryNotifySubscription(string subscriptionId, Resource content = null)
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

            if ((subscription.Channel == null) ||
                (subscription.Channel.Endpoint == null) ||
                (string.IsNullOrEmpty(subscription.Channel.Endpoint)))
            {
                // **** flag we are in an error state ****

                _idSubscriptionDict[subscription.Id].Status = "error";

                // **** fail ****

                return false;
            }

            // **** check our event count ****

            int eventCount;

            lock (_idLockDict[subscription.Id])
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

            Hl7.Fhir.Model.Bundle bundle = new Hl7.Fhir.Model.Bundle()
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

            // **** check if we are adding contents ****

            if ((content != null) && (subscription.Channel.Payload.Content != "empty"))
            {
                // **** set contents ****

                bundle.Entry = new List<Bundle.EntryComponent>();

                // **** add depending on type ****

                if (subscription.Channel.Payload.Content == "id-only")
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

                    _idSubscriptionDict[subscription.Id].Status = "error";

                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SubscriptionManager.TryNotifySubscription <<< request to" +
                    $" {subscription.Channel.Endpoint}" +
                    $" caused exception: {ex.Message}");

                _idSubscriptionDict[subscription.Id].Status = "error";

                return false;
            }

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
