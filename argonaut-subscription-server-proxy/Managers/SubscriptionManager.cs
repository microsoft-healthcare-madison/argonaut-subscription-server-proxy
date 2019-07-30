using argonaut_subscription_server_proxy.Models;
using Hl7.Fhir.ElementModel;
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
        private Dictionary<string, Subscription> _idSubscriptionDict;

        private Random _rand;

        #endregion Instance Variables . . .

        #region Constructors . . .

        private SubscriptionManager()
        {
            // **** create our index objects ****

            _idSubscriptionDict = new Dictionary<string, Subscription>();
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

        public static List<Subscription> GetSubscriptionList()
        {
            // **** return our list of known subscriptions ****

            return _instance._idSubscriptionDict.Values.ToList<Subscription>();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Adds or updates a Subscription.</summary>
        ///
        /// <remarks>Gino Canessa, 7/2/2019.</remarks>
        ///
        /// <param name="subscription">The subscription.</param>
        ///-------------------------------------------------------------------------------------------------

        public static void AddOrUpdate(Subscription subscription)
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

        public static Subscription GetSubscription(string id)
        {
            if ((string.IsNullOrEmpty(id)) || (!_instance._idSubscriptionDict.ContainsKey(id)))
            {
                return null;
            }

            return _instance._idSubscriptionDict[id];
        }

        public static void HandlePost(string content, out Subscription subscription)
        {
            _instance._HandlePost(content, out subscription);
        }

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

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Handles the post.</summary>
        ///
        /// <remarks>Gino Canessa, 7/30/2019.</remarks>
        ///
        /// <param name="content">     The content.</param>
        /// <param name="subscription">[out] The subscription.</param>
        ///-------------------------------------------------------------------------------------------------

        private void _HandlePost(string content, out Subscription subscription)
        {
            subscription = null;

            // **** attempt to parse our content into a subscription request ****
            
            try
            {
                //Hl7.Fhir.Serialization.FhirJsonSerializer parser = new Hl7.Fhir.Serialization.FhirJsonSerializer();

                // **** parse the subscription ****

                subscription = JsonConvert.DeserializeObject<Subscription>(content);

                // **** check for no result ****

                if (subscription == null)
                {
                    return;
                }

                // **** create an id (if necessary) ****

                if (string.IsNullOrEmpty(subscription.id))
                {
                    subscription.id = $"S-{_rand.Next(100, 999)}-{DateTime.Now.ToString("yyyyMMddHHmmss")}";
                }

                // **** add or update internally ****

                _AddOrUpdate(subscription);

                // **** check for rest-hook ****

                if (subscription.channel.type.text == "rest-hook")
                {
                    string id = subscription.id;

                    // **** attempt to validate the endpoint ****

                    _ = Task.Run((Action)(() => HandshakeRestHook(id)));
                }
                else
                {
                    // **** just mark active ****

                    _idSubscriptionDict[subscription.id].status = "active"; // new Hl7.Fhir.Model.Code("active");
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

        private void _AddOrUpdate(Subscription subscription)
        {
            // **** check for an existing topic (may need to remove URL for cleanup) ****

            if (_idSubscriptionDict.ContainsKey(subscription.id))
            {
                // **** remove from the main dict ****

                _idSubscriptionDict.Remove(subscription.id);
            }

            // **** add to the main dictionary ****

            _idSubscriptionDict.Add(subscription.id, subscription);
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

            Subscription subscription = _idSubscriptionDict[subscriptionId];

            if ((subscription.channel == null) ||
                (subscription.channel.endpoint == null) ||
                (string.IsNullOrEmpty(subscription.channel.endpoint.ToString())))
            {
                // **** nothing to do ****

                _idSubscriptionDict[subscription.id].status = "error";      // new Hl7.Fhir.Model.Code("error");

                return false;
            }

            // **** create a bundle to send the handshake message ****

            Hl7.Fhir.Model.Bundle handshake = new Hl7.Fhir.Model.Bundle()
            {
                Identifier = new Hl7.Fhir.Model.Identifier("GUID", Guid.NewGuid().ToString()),
                Type = Hl7.Fhir.Model.Bundle.BundleType.History,
                Timestamp = new DateTimeOffset(DateTime.Now),
                Meta = new Hl7.Fhir.Model.Meta()
            };

            // **** setup our extensions for the bundle ****

            handshake.Meta.Extension.Add(new Hl7.Fhir.Model.Extension()
            {
                Url = "http://hl7.org/fhir/StructureDefinition/subscriptionEventCount",
                Value = new Hl7.Fhir.Model.PositiveInt(0)
            });

            handshake.Meta.Extension.Add(new Hl7.Fhir.Model.Extension()
            {
                Url = "http://hl7.org/fhir/StructureDefinition/subscriptionStatus",
                Value = new Hl7.Fhir.Model.FhirString(subscription.status)
            });

            handshake.Meta.Extension.Add(new Hl7.Fhir.Model.Extension()
            {
                Url = "http://hl7.org/fhir/StructureDefinition/subscriptionTopicUrl",
                Value = new Hl7.Fhir.Model.FhirString(subscription.topic.Reference)
            });

            handshake.Meta.Extension.Add(new Hl7.Fhir.Model.Extension()
            {
                Url = "http://hl7.org/fhir/StructureDefinition/subscriptionUrl",
                Value = new Hl7.Fhir.Model.FhirString(UrlForSubscription(subscription.id))
            });

            // **** send the request to the endpoint ****

            try
            {
                HttpResponseMessage response = Program.RestClient.PostAsync(
                    subscription.channel.endpoint,
                    new StringContent(JsonConvert.SerializeObject(handshake), Encoding.UTF8, "application/fhir+json")
                    ).Result;

                // **** check the status code ****

                if ((response.StatusCode != System.Net.HttpStatusCode.OK) &&
                    (response.StatusCode != System.Net.HttpStatusCode.Accepted) &&
                    (response.StatusCode != System.Net.HttpStatusCode.NoContent))
                {
                    // **** failure ****

                    Console.WriteLine($"SubscriptionManager.HandshakeRestHook <<<" +
                        $" request to {subscription.channel.endpoint}" +
                        $" returned: {response.StatusCode}");

                    // **** done ****

                    _idSubscriptionDict[subscription.id].status = "error";      // new Hl7.Fhir.Model.Code("error");

                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SubscriptionManager.HandshakeRestHook <<<" +
                    $" request to {subscription.channel.endpoint}" + 
                    $" caused exception: {ex.Message}");

                _idSubscriptionDict[subscription.id].status = "error";      // new Hl7.Fhir.Model.Code("error");

                return false;
            }

            // **** update in the manager ****

            _idSubscriptionDict[subscriptionId].status = "active";      // new Hl7.Fhir.Model.Code("active");

            // **** tell the user ****

            Console.WriteLine($" Subscription {subscription.id} set to active!");

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
