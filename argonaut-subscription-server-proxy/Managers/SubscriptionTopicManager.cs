// <copyright file="SubscriptionTopicManager.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir5;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using fhir5.Hl7.Fhir.Model;
using fhir5.Hl7.Fhir.Serialization;
using Hl7.Fhir.ElementModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace argonaut_subscription_server_proxy.Managers
{
    /// <summary>Manager for topics.</summary>
    public class SubscriptionTopicManager
    {
        /// <summary>The instance for singleton pattern.</summary>
        private static SubscriptionTopicManager _instance;

        /// <summary>Dictionary of topic names to indicies in _topics.</summary>
        private Dictionary<string, SubscriptionTopic> _titleTopicDict;
        private Dictionary<string, SubscriptionTopic> _canonicalUrlTopicDict;
        private Dictionary<string, SubscriptionTopic> _localUrlTopicDict;
        private Dictionary<string, SubscriptionTopic> _idTopicDict;

        private CamelCasePropertyNamesContractResolver _contractResolver;

        private FhirJsonSerializer _firelySerializer;

        /// <summary>
        /// Prevents a default instance of the
        /// <see cref="SubscriptionTopicManager"/> class from being
        /// created.
        /// </summary>
        private SubscriptionTopicManager()
        {
            // create our index objects
            _titleTopicDict = new Dictionary<string, SubscriptionTopic>();
            _canonicalUrlTopicDict = new Dictionary<string, SubscriptionTopic>();
            _localUrlTopicDict = new Dictionary<string, SubscriptionTopic>();
            _idTopicDict = new Dictionary<string, SubscriptionTopic>();

            // serialization related
            _firelySerializer = new FhirJsonSerializer();
            _contractResolver = new CamelCasePropertyNamesContractResolver();
        }

        /// <summary>Initializes this object.</summary>
        public static void Init()
        {
            // make an instance
            CheckOrCreateInstance();

            // setup our list of known topics
            _instance.CreateTopics();
        }

        /// <summary>Gets a list of all currently known topics.</summary>
        /// <returns>The topic list.</returns>
        public static List<SubscriptionTopic> GetTopicList()
        {
            // return our list of known topics
            return _instance._titleTopicDict.Values.ToList<SubscriptionTopic>();
        }

        /// <summary>Gets topics bundle.</summary>
        /// <param name="wrapInBasic">(Optional) True to wrap in basic.</param>
        /// <returns>The topics bundle.</returns>
        public static Bundle GetTopicsBundle(bool wrapInBasic = false)
        {
            return _instance._GetTopicsBundle(wrapInBasic);
        }

        /// <summary>Adds or updates a Topic</summary>
        /// <param name="topic">The topic.</param>
        public static void AddOrUpdate(SubscriptionTopic topic)
        {
            if (topic == null)
            {
                return;
            }

            _instance._AddOrUpdate(topic);
        }

        /// <summary>Query if 'canonical' is subscription topic implemented.</summary>
        /// <param name="url">The URL for the topic.</param>
        /// <returns>True if subscription topic implemented, false if not.</returns>
#pragma warning disable CA1054 // Uri parameters should not be strings
        public static bool IsImplemented(string url)
#pragma warning restore CA1054 // Uri parameters should not be strings
        {
            if (string.IsNullOrEmpty(url))
            {
                return false;
            }

            if (_instance._localUrlTopicDict.ContainsKey(url))
            {
                return true;
            }

            if (_instance._canonicalUrlTopicDict.ContainsKey(url))
            {
                return true;
            }

            return false;
        }

        /// <summary>Gets a topic.</summary>
        /// <param name="key">The key (Title, ID, URL)</param>
        /// <returns>The topic.</returns>
        public static SubscriptionTopic GetTopic(string key)
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

            // not found
            return null;
        }

        /// <summary>Attempts to get topic a SubscriptionTopic from the given string.</summary>
        /// <param name="key">  The key for the topic</param>
        /// <param name="topic">[out] The topic.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        public static bool TryGetTopic(string key, out SubscriptionTopic topic)
        {
            topic = GetTopic(key);

            return topic != null;
        }

        /// <summary>Attempts to get serialized a string from the given string.</summary>
        /// <param name="key">       The key for the topic</param>
        /// <param name="serialized">[out] The serialized.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        public static bool TryGetSerialized(string key, out string serialized)
        {
            if (TryGetTopic(key, out SubscriptionTopic subscription))
            {
                serialized = _instance._firelySerializer.SerializeToString(subscription);

                return true;
            }

            serialized = null;
            return false;
        }

        /// <summary>Attempts to get basic serialized a string from the given string.</summary>
        /// <param name="key">       The key for the topic.</param>
        /// <param name="serialized">[out] The serialized.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        public static bool TryGetBasicSerialized(string key, out string serialized)
        {
            if (TryGetTopic(key, out SubscriptionTopic topic))
            {
                Basic basic = _instance.WrapInBasic(topic);
                serialized = _instance._firelySerializer.SerializeToString(basic);

                return true;
            }

            serialized = null;
            return false;
        }

        /// <summary>Wrap in basic.</summary>
        /// <param name="topic">The topic.</param>
        /// <returns>A Basic.</returns>
        private Basic WrapInBasic(SubscriptionTopic topic)
        {
            return new Basic()
            {
                Id = topic.Id,
                Code = new CodeableConcept(
                    "http://hl7.org/fhir/resource-types",
                    "R5SubscriptionTopic",
                    "Backported R5 SubscriptionTopic"),
                Extension = new List<Extension>()
                {
                    new Extension()
                    {
                        Url = "http://hl7.org/fhir/StructureDefinition/json-embedded-resource",
                        Value = new FhirString(_firelySerializer.SerializeToString(topic)),
                    },
                },
            };
        }

        /// <summary>Gets topics bundle.</summary>
        /// <param name="wrapInBasic">(Optional) True to wrap in basic.</param>
        /// <returns>The topics bundle.</returns>
        private Bundle _GetTopicsBundle(bool wrapInBasic = false)
        {
            Bundle bundle = new Bundle()
            {
                Type = Bundle.BundleType.Searchset,
                Total = _titleTopicDict.Count,
                Meta = new Meta()
                {
                    LastUpdated = new DateTimeOffset(DateTime.Now.ToUniversalTime()),
                },
                Entry = new List<Bundle.EntryComponent>(),
            };

            foreach (SubscriptionTopic topic in _idTopicDict.Values)
            {
                bundle.Entry.Add(new Bundle.EntryComponent()
                {
                    FullUrl = Program.UrlForResourceId("SubscriptionTopic", topic.Id),
                    Resource = wrapInBasic ? (Resource)WrapInBasic(topic) : (Resource)topic,
                    Search = new Bundle.SearchComponent()
                    {
                        Mode = Bundle.SearchEntryMode.Match,
                    },
                });
            }

            // return our bundle
            return bundle;
        }

        /// <summary>Adds or updates a Topic</summary>
        /// <param name="topic">The topic.</param>
        private void _AddOrUpdate(SubscriptionTopic topic)
        {
            string localUrl = Program.UrlForResourceId("SubscriptionTopic", topic.Title);

            // check for local url already existing
            if (_localUrlTopicDict.ContainsKey(localUrl))
            {
                SubscriptionTopic oldTopic = _localUrlTopicDict[localUrl];

                // remove if this topic exists in other dictionaries
                RemoveIfExists(_canonicalUrlTopicDict, oldTopic.Url);
                RemoveIfExists(_titleTopicDict, localUrl);
                RemoveIfExists(_idTopicDict, oldTopic.Title);

                // remove from this dict
                _localUrlTopicDict.Remove(topic.Title);
            }

            // check for this canonical url already existing
            if (_canonicalUrlTopicDict.ContainsKey(topic.Url))
            {
                SubscriptionTopic oldTopic = _canonicalUrlTopicDict[topic.Url];

                // remove if this topic exists in other dictionaries
                RemoveIfExists(_localUrlTopicDict, localUrl);
                RemoveIfExists(_titleTopicDict, oldTopic.Url);
                RemoveIfExists(_idTopicDict, oldTopic.Title);

                // remove from this dict
                _canonicalUrlTopicDict.Remove(topic.Url);
            }

            // check for title already existing
            if (_titleTopicDict.ContainsKey(topic.Title))
            {
                SubscriptionTopic oldTopic = _titleTopicDict[topic.Title];

                // remove if this topic exists in other dictionaries
                RemoveIfExists(_localUrlTopicDict, localUrl);
                RemoveIfExists(_canonicalUrlTopicDict, oldTopic.Url);
                RemoveIfExists(_idTopicDict, oldTopic.Title);

                // remove from this dict
                _titleTopicDict.Remove(topic.Title);
            }

            // check for this id already existing
            if (_idTopicDict.ContainsKey(topic.Id))
            {
                SubscriptionTopic oldTopic = _idTopicDict[topic.Id];

                // remove if this topic exists in other dictionaries
                RemoveIfExists(_localUrlTopicDict, localUrl);
                RemoveIfExists(_canonicalUrlTopicDict, oldTopic.Url);
                RemoveIfExists(_titleTopicDict, oldTopic.Title);

                // remove from this dict
                _idTopicDict.Remove(topic.Id);
            }

            // add to local url dictionary
            _localUrlTopicDict.Add(localUrl, topic);

            // add to canonical url dictionary
            _canonicalUrlTopicDict.Add(topic.Url, topic);

            // add to the title dictionary
            _titleTopicDict.Add(topic.Title, topic);

            // add to id dictionary
            _idTopicDict.Add(topic.Id, topic);
        }

        /// <summary>Removes if exists.</summary>
        /// <param name="dict">The dictionary.</param>
        /// <param name="key"> The key (Title, ID, URL).</param>
        private void RemoveIfExists(Dictionary<string, SubscriptionTopic> dict, string key)
        {
            if (dict.ContainsKey(key))
            {
                dict.Remove(key);
            }
        }

        /// <summary>Dumps a node.</summary>
        /// <param name="node">The node.</param>
        private void DumpNode(ISourceNode node)
        {
            Console.WriteLine(
                string.Format(
                    CultureInfo.InvariantCulture,
                    "{0,70} {1,20} {2}",
                    "Location",
                    "Name",
                    "Text"));
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

        /// <summary>Creates the topics.</summary>
        private void CreateTopics()
        {
            // make sure our lists are clear
            _titleTopicDict.Clear();
            _canonicalUrlTopicDict.Clear();
            _idTopicDict.Clear();

            // create our known topics
            SubscriptionTopic topic = new SubscriptionTopic()
            {
                Title = "encounter-start",
                Id = "encounter-start",
                Url = "http://argonautproject.org/encounters-ig/SubscriptionTopic/encounter-start",
                Version = "1.1",
                Status = PublicationStatus.Draft,
                Experimental = true,
                Description = new Markdown("Beginning of a clinical encounter"),
                Date = "2020-05-11",
                ResourceTrigger = new SubscriptionTopic.ResourceTriggerComponent()
                {
                    Description = "Beginning of a clinical encounter",
                    ResourceType = new ResourceType?[]
                    {
                        ResourceType.Encounter,
                    },
                    QueryCriteria = new SubscriptionTopic.QueryCriteriaComponent()
                    {
                        Previous = "status:not=in-progress",
                        Current = "status:in-progress",
                        RequireBoth = true,
                    },
                    FhirPathCriteria = new string[]
                    {
                        "%previous.status!='in-progress' and %current.status='in-progress'",
                    },
                },
                CanFilterBy = new List<SubscriptionTopic.CanFilterByComponent>()
                {
                    new SubscriptionTopic.CanFilterByComponent()
                    {
                        SearchParamName = "patient",
                        SearchModifier = new SubscriptionSearchModifier?[]
                        {
                            SubscriptionSearchModifier.Equal,
                            SubscriptionSearchModifier.In,
                        },
                        Documentation = new Markdown("Exact match to a patient resource (reference)"),
                    },
                },
            };

            // add this topic
            _AddOrUpdate(topic);
        }

        /// <summary>Check or create instance.</summary>
        private static void CheckOrCreateInstance()
        {
            if (_instance == null)
            {
                _instance = new SubscriptionTopicManager();
            }
        }
    }
}
