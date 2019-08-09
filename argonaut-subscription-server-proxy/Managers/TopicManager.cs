using fhir;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
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
        private Dictionary<string, fhir.Topic> _titleTopicDict;
        private Dictionary<string, fhir.Topic> _canonicalUrlTopicDict;
        private Dictionary<string, fhir.Topic> _localUrlTopicDict;
        private Dictionary<string, fhir.Topic> _idTopicDict;

        #endregion Instance Variables . . .

        #region Constructors . . .

        private TopicManager()
        {
            // **** create our index objects ****

            _titleTopicDict = new Dictionary<string, fhir.Topic>();
            _canonicalUrlTopicDict = new Dictionary<string, fhir.Topic>();
            _localUrlTopicDict = new Dictionary<string, Topic>();
            _idTopicDict = new Dictionary<string, fhir.Topic>();
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

        public static List<fhir.Topic> GetTopicList()
        {
            // **** return our list of known topics ****

            return _instance._titleTopicDict.Values.ToList<fhir.Topic>();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Adds or updates a Topic</summary>
        ///
        /// <remarks>Gino Canessa, 6/6/2019.</remarks>
        ///
        /// <param name="topic">The topic.</param>
        ///-------------------------------------------------------------------------------------------------

        public static void AddOrUpdate(fhir.Topic topic)
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

        public static fhir.Topic GetTopic(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return null;
            }

            if (_instance._localUrlTopicDict.ContainsKey(key))
            {
                return _instance._localUrlTopicDict[key];
            }

            if (_instance._titleTopicDict.ContainsKey(key))
            {
                return _instance._titleTopicDict[key];
            }

            if (_instance._idTopicDict.ContainsKey(key))
            {
                return _instance._idTopicDict[key];
            }

            if (_instance._canonicalUrlTopicDict.ContainsKey(key))
            {
                return _instance._canonicalUrlTopicDict[key];
            }

            // **** not found ****

            return null;
        }

        #endregion Class Interface . . .

        #region Instance Interface . . .

        #endregion Instance Interface . . .

        #region Internal Functions . . .

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Adds or updates a Topic</summary>
        ///
        /// <remarks>Gino Canessa, 6/6/2019.</remarks>
        ///
        /// <param name="topic">The topic.</param>
        ///-------------------------------------------------------------------------------------------------

        private void _AddOrUpdate(fhir.Topic topic)
        {
            string localUrl = Program.UrlForResourceId("Topic", topic.Title);

            // **** check for local url already existing ****

            if (_localUrlTopicDict.ContainsKey(localUrl))
            {
                fhir.Topic oldTopic = _localUrlTopicDict[localUrl];

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
                fhir.Topic oldTopic = _canonicalUrlTopicDict[topic.Url];

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
                fhir.Topic oldTopic = _titleTopicDict[topic.Title];

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
                fhir.Topic oldTopic = _idTopicDict[topic.Id];

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

        private void RemoveIfExists(Dictionary<string, fhir.Topic> dict, string key)
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

            fhir.Topic topic = new fhir.Topic()
            {
                ResourceType = "Topic",
                Title = "admission",
                Id = "636b348b-e2fa-4b76-98d3-0375ba1e886b",
                Url = "http://argonautproject.org/subscription-ig/Topic/admission",
                Version = "0.3",
                Status = "draft",
                Experimental = true,
                Description = "Admissions Topic for testing framework and behavior",
                Date = "2019-08-01",
                ResourceTrigger = new fhir.TopicResourceTrigger()
                {
                    Description = "Beginning of a clinical encounter",
                    ResourceType = new string[] {"Encounter"},
                    QueryCriteria = new TopicResourceTriggerQueryCriteria()
                    {
                        Previous = "status:not=in-progress",
                        Current = "status:in-progress",
                        RequireBoth = true,
                    },
                    FhirPathCriteria = "%previous.status!='in-progress' and %current.status='in-progress'",
                },
                CanFilterBy = new TopicCanFilterBy[]
                {
                    new TopicCanFilterBy() {Name = "patient", Documentation = "Exact match to a patient resource (reference)"},
                    //new TopicCanFilterBy() {Name = "Practitioner", Documentation ="Practitioner"},
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
