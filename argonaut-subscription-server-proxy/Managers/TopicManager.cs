using argonaut_subscription_server_proxy.Models;
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
        private Dictionary<string, Topic> _nameTopicDict;
        private Dictionary<string, string> _urlNameDict;
        private Dictionary<string, string> _idNameDict;

        #endregion Instance Variables . . .

        #region Constructors . . .

        private TopicManager()
        {
            // **** create our index objects ****

            _nameTopicDict = new Dictionary<string, Topic>();
            _urlNameDict = new Dictionary<string, string>();
            _idNameDict = new Dictionary<string, string>();
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

        public static List<Topic> GetTopicList()
        {
            // **** return our list of known topics ****

            return _instance._nameTopicDict.Values.ToList<Topic>();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Adds or updates a Topic</summary>
        ///
        /// <remarks>Gino Canessa, 6/6/2019.</remarks>
        ///
        /// <param name="topic">The topic.</param>
        ///-------------------------------------------------------------------------------------------------

        public static void AddOrUpdate(Topic topic)
        {
            _instance._AddOrUpdate(topic);
        }

        public static Topic GetTopic(string name)
        {
            if ((string.IsNullOrEmpty(name)) || (!_instance._nameTopicDict.ContainsKey(name)))
            {
                return null;
            }

            return _instance._nameTopicDict[name];
        }

        public static string UrlForTopicName(string name)
        {
            return (new Uri(
                new Uri(Program.Configuration["Server_Listen_Url"], UriKind.Absolute),
                new Uri($"Topic/{name}", UriKind.Relative))
                ).ToString();
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

        private void _AddOrUpdate(Topic topic)
        {
            // **** check for an existing topic (may need to remove URL for cleanup) ****

            if (_nameTopicDict.ContainsKey(topic.title))
            {
                // **** look for the old URL ****

                if (_urlNameDict.ContainsKey(_nameTopicDict[topic.title].url.ToString()))
                {
                    // **** remove ****

                    _urlNameDict.Remove(_nameTopicDict[topic.title].url.ToString());
                }

                if (_idNameDict.ContainsKey(_nameTopicDict[topic.title].id))
                {
                    // **** remove ****

                    _idNameDict.Remove(_nameTopicDict[topic.title].id);
                }

                // **** remove from the main dict ****

                _nameTopicDict.Remove(topic.title);
            }

            // **** check for this new url already existing ****

            if (_urlNameDict.ContainsKey(topic.url.ToString()))
            {
                // **** check for the old URL's record in the main dict ****

                if (_nameTopicDict.ContainsKey(_urlNameDict[topic.url.ToString()]))
                {
                    _nameTopicDict.Remove(_urlNameDict[topic.url.ToString()]);
                }

                // **** remove from URL dictionary ****

                _urlNameDict.Remove(topic.url.ToString());
            }

            // **** check for this id already existing ****

            if (_idNameDict.ContainsKey(topic.id))
            {
                // **** check for the old id's record in the main dict ****

                if (_nameTopicDict.ContainsKey(_idNameDict[topic.id]))
                {
                    _nameTopicDict.Remove(_idNameDict[topic.id]);
                }

                // **** remove from id dictionary ****

                _idNameDict.Remove(topic.url.ToString());
            }

            // **** add to the main dictionary ****

            _nameTopicDict.Add(topic.title, topic);

            // **** add to url dictionary ****

            _urlNameDict.Add(topic.url.ToString(), topic.title);

            // **** add to id dictionary ****

            _idNameDict.Add(topic.id, topic.title);
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

            _nameTopicDict.Clear();
            _urlNameDict.Clear();
            _idNameDict.Clear();

            // **** create our known topics ****

            Topic topic = new Topic()
            {
                title = "admissions",
                id = "1",
                url = new Hl7.Fhir.Model.FhirUri("http://argonautproject.org/subscription-ig/Topic/admission"),
                version = "0.2",
                status = new Code("draft"),
                experimental = true,
                description = "Admissions Topic for testing framework and behavior",
                date = new FhirDateTime(2019, 07, 01, 0, 0, 0, TimeSpan.Zero),
                resourceTrigger = new ResourceTrigger()
                {
                    description = "Beginning of a clinical encounter",
                    resourceType = new List<Code>() { new Code("Encounter") },
                    criteria = new Criteria()
                    {
                        queryCriteria = new CriteriaByQuery()
                        {
                            previous = "status:not=in-progress",
                            current = "status:in-progress",
                            requireBoth = true
                        },
                        fhirPathCriteria = "%previous.status!='in-progress' and %current.status='in-progress'"
                    }
                },
                canFilterBy = new List<FilterSpecification>()
                {
                    new FilterSpecification() {name = "patient", documentation = "Patient involved in the encounter"},
                    new FilterSpecification() {name = "practitioner", documentation ="Practitioner"},
                    new FilterSpecification() {name = "patient.birthDate", documentation="Birthdate of admitted patient"}
                }
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
