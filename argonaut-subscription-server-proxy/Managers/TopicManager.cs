using fhir;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace argonaut_subscription_server_proxy.Managers
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>Manager for topics.</summary>
    ///
    /// <remarks>Gino Canessa, 7/2/2019.</remarks>
    ///-------------------------------------------------------------------------------------------------

    public class TopicManager
    {
        #region Class Types . . .

        #endregion Class Types . . .

        #region Class Variables . . .

        /// <summary>The instance for singleton pattern.</summary>
        private static TopicManager _instance;

        #endregion Class Variables . . .

        #region Instance Variables . . .

        /// <summary>Dictionary of topic names to indicies in _topics.</summary>
        private Dictionary<string, fhir.SubscriptionTopic> _titleTopicDict;
        private Dictionary<string, fhir.SubscriptionTopic> _canonicalUrlTopicDict;
        private Dictionary<string, fhir.SubscriptionTopic> _localUrlTopicDict;
        private Dictionary<string, fhir.SubscriptionTopic> _idTopicDict;

        private CamelCasePropertyNamesContractResolver _contractResolver;

        #endregion Instance Variables . . .

        #region Constructors . . .

        private TopicManager()
        {
            // **** create our index objects ****

            _titleTopicDict = new Dictionary<string, fhir.SubscriptionTopic>();
            _canonicalUrlTopicDict = new Dictionary<string, fhir.SubscriptionTopic>();
            _localUrlTopicDict = new Dictionary<string, fhir.SubscriptionTopic>();
            _idTopicDict = new Dictionary<string, fhir.SubscriptionTopic>();

            // **** serialization related ****

            _contractResolver = new CamelCasePropertyNamesContractResolver();
        }

        #endregion Constructors . . .

        #region Class Interface . . .

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Initializes this object.</summary>
        ///
        /// <remarks>Gino Canessa, 6/4/2019.</remarks>
        ///-------------------------------------------------------------------------------------------------

        public static void Init()
        {
            // **** make an instance ****

            CheckOrCreateInstance();

            // **** setup our list of known topics ****

            _instance.CreateTopics();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Gets a list of all currently known topics.</summary>
        ///
        /// <remarks>Gino Canessa, 6/6/2019.</remarks>
        ///
        /// <returns>The topic list.</returns>
        ///-------------------------------------------------------------------------------------------------

        public static List<fhir.SubscriptionTopic> GetTopicList()
        {
            // **** return our list of known topics ****

            return _instance._titleTopicDict.Values.ToList<fhir.SubscriptionTopic>();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Gets topics bundle.</summary>
        ///
        /// <remarks>Gino Canessa, 11/6/2019.</remarks>
        ///
        /// <param name="wrapInBasic">(Optional) True to wrap in basic.</param>
        ///
        /// <returns>The topics bundle.</returns>
        ///-------------------------------------------------------------------------------------------------

        public static fhir.Bundle GetTopicsBundle(bool wrapInBasic = false)
        {
            return _instance._GetTopicsBundle(wrapInBasic);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Adds or updates a Topic</summary>
        ///
        /// <remarks>Gino Canessa, 6/6/2019.</remarks>
        ///
        /// <param name="topic">The topic.</param>
        ///-------------------------------------------------------------------------------------------------

        public static void AddOrUpdate(fhir.SubscriptionTopic topic)
        {
            _instance._AddOrUpdate(topic);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Gets a topic.</summary>
        ///
        /// <remarks>Gino Canessa, 8/2/2019.</remarks>
        ///
        /// <param name="key">The key (Title, ID, URL)</param>
        ///
        /// <returns>The topic.</returns>
        ///-------------------------------------------------------------------------------------------------

        public static fhir.SubscriptionTopic GetTopic(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return null;
            }

            if (_instance._titleTopicDict.ContainsKey(key))
            {
                return _instance._titleTopicDict[key];
            }

            if (_instance._idTopicDict.ContainsKey(key))
            {
                return _instance._idTopicDict[key];
            }

            if (_instance._localUrlTopicDict.ContainsKey(key))
            {
                return _instance._localUrlTopicDict[key];
            }

            if (_instance._canonicalUrlTopicDict.ContainsKey(key))
            {
                return _instance._canonicalUrlTopicDict[key];
            }

            // **** not found ****

            return null;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Attempts to get topic a fhir.SubscriptionTopic from the given string.</summary>
        ///
        /// <remarks>Gino Canessa, 11/5/2019.</remarks>
        ///
        /// <param name="key">  The key for the topic</param>
        /// <param name="topic">[out] The topic.</param>
        ///
        /// <returns>True if it succeeds, false if it fails.</returns>
        ///-------------------------------------------------------------------------------------------------

        public static bool TryGetTopic(string key, out fhir.SubscriptionTopic topic)
        {
            topic = GetTopic(key);

            return (topic != null);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Attempts to get serialized a string from the given string.</summary>
        ///
        /// <remarks>Gino Canessa, 11/6/2019.</remarks>
        ///
        /// <param name="key">       The key for the topic</param>
        /// <param name="serialized">[out] The serialized.</param>
        ///
        /// <returns>True if it succeeds, false if it fails.</returns>
        ///-------------------------------------------------------------------------------------------------

        public static bool TryGetSerialized(string key, out string serialized)
        {
            if (TryGetTopic(key, out fhir.SubscriptionTopic subscription))
            {
                serialized = JsonConvert.SerializeObject(
                    subscription,
                    new JsonSerializerSettings()
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        ContractResolver = _instance._contractResolver,
                    });

                return true;
            }

            serialized = null;
            return false;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Attempts to get basic serialized a string from the given string.</summary>
        ///
        /// <remarks>Gino Canessa, 11/6/2019.</remarks>
        ///
        /// <param name="key">       The key for the topic.</param>
        /// <param name="serialized">[out] The serialized.</param>
        ///
        /// <returns>True if it succeeds, false if it fails.</returns>
        ///-------------------------------------------------------------------------------------------------

        public static bool TryGetBasicSerialized(string key, out string serialized)
        {
            if (TryGetTopic(key, out fhir.SubscriptionTopic topic))
            {
                fhir.Basic basic = _instance.WrapInBasic(topic);
                serialized = JsonConvert.SerializeObject(
                    basic,
                    new JsonSerializerSettings()
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        ContractResolver = _instance._contractResolver,
                    });

                return true;
            }

            serialized = null;
            return false;
        }

        #endregion Class Interface . . .

        #region Instance Interface . . .

        #endregion Instance Interface . . .

        #region Internal Functions . . .

        private fhir.Basic WrapInBasic(fhir.SubscriptionTopic topic)
        {
            return new fhir.Basic()
            {
                Id = topic.Id,
                Code = new fhir.CodeableConcept()
                {
                    Coding = new fhir.Coding[]
                    {
                        new fhir.Coding()
                        {
                            Code = "R5SubscriptionTopic",
                            System = "http://hl7.org/fhir/resource-types",
                            Display = "Backported R5 SubscriptionTopic"
                        }
                    }
                },
                Extension = new fhir.Extension[]
                {
                    new fhir.Extension()
                    {
                        Url = "http://hl7.org/fhir/StructureDefinition/json-embedded-resource",
                        ValueString = JsonConvert.SerializeObject(
                            topic,
                            new JsonSerializerSettings()
                            {
                                NullValueHandling = NullValueHandling.Ignore,
                                ContractResolver = _contractResolver,
                            })
                    }
                }
            };
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Gets topics bundle.</summary>
        ///
        /// <remarks>Gino Canessa, 11/6/2019.</remarks>
        ///
        /// <param name="wrapInBasic">(Optional) True to wrap in basic.</param>
        ///
        /// <returns>The topics bundle.</returns>
        ///-------------------------------------------------------------------------------------------------

        private fhir.Bundle _GetTopicsBundle(bool wrapInBasic = false)
        {
            fhir.Bundle bundle = new fhir.Bundle()
            {
                Type = "searchset",
                Total = (uint)_titleTopicDict.Count,
                Meta = new fhir.Meta() {
                    LastUpdated = string.Format("{0:o}", DateTime.Now.ToUniversalTime())
                },
                Entry = new BundleEntry[_idTopicDict.Count]
            };

            fhir.SubscriptionTopic[] topics = _idTopicDict.Values.ToArray<fhir.SubscriptionTopic>();

            if (wrapInBasic)
            {
                for (int index = 0; index < topics.Length; index++)
                {
                    // **** add this topic ****

                    bundle.Entry[index] = new BundleEntry()
                    {
                        FullUrl = Program.UrlForResourceId("Topic", topics[index].Id),
                        Resource = WrapInBasic(topics[index]),
                        Search = new BundleEntrySearch() { Mode = "match" },
                        //Response = new BundleEntryResponse() { Status = "201 Created"}
                    };

                }
            }
            else
            {
                for (int index = 0; index < topics.Length; index++)
                {
                    // **** add this topic ****

                    bundle.Entry[index] = new BundleEntry()
                    {
                        FullUrl = Program.UrlForResourceId("Topic", topics[index].Id),
                        Resource = topics[index],
                        Search = new BundleEntrySearch() { Mode = "match" },
                        //Response = new BundleEntryResponse() { Status = "201 Created"}
                    };

                }
            }

            // **** return our bundle ****

            return bundle;
        }


        ///-------------------------------------------------------------------------------------------------
        /// <summary>Adds or updates a Topic</summary>
        ///
        /// <remarks>Gino Canessa, 6/6/2019.</remarks>
        ///
        /// <param name="topic">The topic.</param>
        ///-------------------------------------------------------------------------------------------------

        private void _AddOrUpdate(fhir.SubscriptionTopic topic)
        {
            string localUrl = Program.UrlForResourceId("Topic", topic.Title);

            // **** check for local url already existing ****

            if (_localUrlTopicDict.ContainsKey(localUrl))
            {
                fhir.SubscriptionTopic oldTopic = _localUrlTopicDict[localUrl];

                // **** remove if this topic exists in other dictionaries ****

                RemoveIfExists(_canonicalUrlTopicDict, oldTopic.Url);
                RemoveIfExists(_titleTopicDict, localUrl);
                RemoveIfExists(_idTopicDict, oldTopic.Title);

                // **** remove from this dict ****

                _localUrlTopicDict.Remove(topic.Title);
            }

            // **** check for this canonical url already existing ****

            if (_canonicalUrlTopicDict.ContainsKey(topic.Url))
            {
                fhir.SubscriptionTopic oldTopic = _canonicalUrlTopicDict[topic.Url];

                // **** remove if this topic exists in other dictionaries ****

                RemoveIfExists(_localUrlTopicDict, localUrl);
                RemoveIfExists(_titleTopicDict, oldTopic.Url);
                RemoveIfExists(_idTopicDict, oldTopic.Title);

                // **** remove from this dict ****

                _canonicalUrlTopicDict.Remove(topic.Url);
            }

            // **** check for title already existing ****

            if (_titleTopicDict.ContainsKey(topic.Title))
            {
                fhir.SubscriptionTopic oldTopic = _titleTopicDict[topic.Title];

                // **** remove if this topic exists in other dictionaries ****

                RemoveIfExists(_localUrlTopicDict, localUrl);
                RemoveIfExists(_canonicalUrlTopicDict, oldTopic.Url);
                RemoveIfExists(_idTopicDict, oldTopic.Title);

                // **** remove from this dict ****

                _titleTopicDict.Remove(topic.Title);
            }

            // **** check for this id already existing ****

            if (_idTopicDict.ContainsKey(topic.Id))
            {
                fhir.SubscriptionTopic oldTopic = _idTopicDict[topic.Id];

                // **** remove if this topic exists in other dictionaries ****

                RemoveIfExists(_localUrlTopicDict, localUrl);
                RemoveIfExists(_canonicalUrlTopicDict, oldTopic.Url);
                RemoveIfExists(_titleTopicDict, oldTopic.Title);

                // **** remove from this dict ****

                _idTopicDict.Remove(topic.Id);
            }

            // **** add to local url dictionary ***

            _localUrlTopicDict.Add(localUrl, topic);

            // **** add to canonical url dictionary ****

            _canonicalUrlTopicDict.Add(topic.Url, topic);

            // **** add to the title dictionary ****

            _titleTopicDict.Add(topic.Title, topic);

            // **** add to id dictionary ****

            _idTopicDict.Add(topic.Id, topic);
        }

        private void RemoveIfExists(Dictionary<string, fhir.SubscriptionTopic> dict, string key)
        {
            if (dict.ContainsKey(key))
            {
                dict.Remove(key);
            }
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
        /// <summary>Creates the topics.</summary>
        ///
        /// <remarks>Gino Canessa, 6/4/2019.</remarks>
        ///-------------------------------------------------------------------------------------------------

        private void CreateTopics()
        {
            // **** make sure our lists are clear ****

            _titleTopicDict.Clear();
            _canonicalUrlTopicDict.Clear();
            _idTopicDict.Clear();

            // **** create our known topics ****

            fhir.SubscriptionTopic topic = new fhir.SubscriptionTopic()
            {
                Title = "admission",
                Id = "1",
                Url = "http://argonautproject.org/subscription-ig/Topic/admission",
                Version = "0.4",
                Status = "draft",
                Experimental = true,
                Description = "Admission Topic for testing framework and behavior",
                Date = "2019-08-01",
                ResourceTrigger = new fhir.SubscriptionTopicResourceTrigger()
                {
                    Description = "Beginning of a clinical encounter",
                    ResourceType = new string[] {"Encounter"},
                    QueryCriteria = new SubscriptionTopicResourceTriggerQueryCriteria()
                    {
                        Previous = "status:not=in-progress",
                        Current = "status:in-progress",
                        RequireBoth = true,
                    },
                    FhirPathCriteria = "%previous.status!='in-progress' and %current.status='in-progress'",
                },
                CanFilterBy = new SubscriptionTopicCanFilterBy[]
                {
                    new SubscriptionTopicCanFilterBy()
                    {
                        SearchParamName = "patient", 
                        Documentation = "Exact match to a patient resource (reference)", 
                        MatchType = new string[] { "=", "in", "not-in" }
                    },
                },
            };

            // **** add this topic ****

            _AddOrUpdate(topic);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Check or create instance.</summary>
        ///
        /// <remarks>Gino Canessa, 6/4/2019.</remarks>
        ///-------------------------------------------------------------------------------------------------

        private static void CheckOrCreateInstance()
        {
            if (_instance == null)
            {
                _instance = new TopicManager();
            }
        }


        #endregion Internal Functions . . .

    }
}
