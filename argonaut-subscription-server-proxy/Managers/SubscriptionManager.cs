using argonaut_subscription_server_proxy.Models;
using Hl7.Fhir.ElementModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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

        #endregion Instance Variables . . .

        #region Constructors . . .

        private SubscriptionManager()
        {
            // **** create our index objects ****

            _idSubscriptionDict = new Dictionary<string, Subscription>();
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

        #endregion Class Interface . . .

        #region Instance Interface . . .

        #endregion Instance Interface . . .

        #region Internal Functions . . .

        private void _HandlePost(string content, out Subscription subscription)
        {
            subscription = null;

            // **** attempt to parse our content into a subscription request ****
            
            try
            {
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
                    subscription.id = $"Sub-{DateTime.Now.ToString("yyyyMMddHHmmss")}";
                }

                // **** add or update internally ****

                _AddOrUpdate(subscription);
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
