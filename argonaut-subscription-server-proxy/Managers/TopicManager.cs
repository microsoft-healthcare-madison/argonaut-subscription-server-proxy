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
        private Dictionary<string, fhir.Topic> _nameTopicDict;
        private Dictionary<string, string> _urlNameDict;
        private Dictionary<string, string> _idNameDict;

        #endregion Instance Variables . . .

        #region Constructors . . .

        private TopicManager()
        {
            // **** create our index objects ****

            _nameTopicDict = new Dictionary<string, fhir.Topic>();
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

        public static List<fhir.Topic> GetTopicList()
        {
            // **** return our list of known topics ****

            return _instance._nameTopicDict.Values.ToList<fhir.Topic>();
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

        public static fhir.Topic GetTopic(string name)
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

        private void _AddOrUpdate(fhir.Topic topic)
        {
            // **** check for an existing topic (may need to remove URL for cleanup) ****

            if (_nameTopicDict.ContainsKey(topic.Title))
            {
                // **** look for the old URL ****

                if (_urlNameDict.ContainsKey(_nameTopicDict[topic.Title].Url.ToString()))
                {
                    // **** remove ****

                    _urlNameDict.Remove(_nameTopicDict[topic.Title].Url.ToString());
                }

                if (_idNameDict.ContainsKey(_nameTopicDict[topic.Title].Id))
                {
                    // **** remove ****

                    _idNameDict.Remove(_nameTopicDict[topic.Title].Id);
                }

                // **** remove from the main dict ****

                _nameTopicDict.Remove(topic.Title);
            }

            // **** check for this new url already existing ****

            if (_urlNameDict.ContainsKey(topic.Url.ToString()))
            {
                // **** check for the old URL's record in the main dict ****

                if (_nameTopicDict.ContainsKey(_urlNameDict[topic.Url.ToString()]))
                {
                    _nameTopicDict.Remove(_urlNameDict[topic.Url.ToString()]);
                }

                // **** remove from URL dictionary ****

                _urlNameDict.Remove(topic.Url.ToString());
            }

            // **** check for this id already existing ****

            if (_idNameDict.ContainsKey(topic.Id))
            {
                // **** check for the old id's record in the main dict ****

                if (_nameTopicDict.ContainsKey(_idNameDict[topic.Id]))
                {
                    _nameTopicDict.Remove(_idNameDict[topic.Id]);
                }

                // **** remove from id dictionary ****

                _idNameDict.Remove(topic.Url.ToString());
            }

            // **** add to the main dictionary ****

            _nameTopicDict.Add(topic.Title, topic);

            // **** add to url dictionary ****

            _urlNameDict.Add(topic.Url.ToString(), topic.Title);

            // **** add to id dictionary ****

            _idNameDict.Add(topic.Id, topic.Title);
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

            fhir.Topic topic = new fhir.Topic()
            {
                Title = "admissions",
                Id = "1",
                Url = "http://argonautproject.org/subscription-ig/Topic/admission",
                Version = "0.2",
                Status = "draft",
                Experimental = true,
                Description = "Admissions Topic for testing framework and behavior",
                Date = "2019-07-01",
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
                    new TopicCanFilterBy() {Name = "Patient", Documentation = "Patient involved in the encounter"},
                    new TopicCanFilterBy() {Name = "Practitioner", Documentation ="Practitioner"},
                    new TopicCanFilterBy() {Name = "patient.birthDate", Documentation="Birthdate of admitted patient"}
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
