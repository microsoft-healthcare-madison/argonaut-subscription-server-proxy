// <copyright file="SubscriptionConverter.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir4;
extern alias fhir5;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using argonaut_subscription_server_proxy.Managers;
using Hl7.Fhir.Model;
using r4 = fhir4.Hl7.Fhir.Model;
using r4s = fhir4.Hl7.Fhir.Serialization;
using r5 = fhir5.Hl7.Fhir.Model;
using r5s = fhir5.Hl7.Fhir.Serialization;

namespace argonaut_subscription_server_proxy.Backport
{
    /// <summary>A subscription converter.</summary>
    public abstract class SubscriptionConverter
    {
        private const string ExtensionUrlFilterCriteria = "http://hl7.org/fhir/uv/subscriptions-backport/StructureDefinition/backport-filter-criteria";

        private const string ExtensionUrlHeartbeat = "http://hl7.org/fhir/uv/subscriptions-backport/StructureDefinition/backport-heartbeat-period";
        private const string ExtensionUrlTimeout = "http://hl7.org/fhir/uv/subscriptions-backport/StructureDefinition/backport-timeout";
        private const string ExtensionUrlContent = "http://hl7.org/fhir/uv/subscriptions-backport/StructureDefinition/backport-payload-content";

        private const string ExtensionNotificationUrlLocaltion = "http://hl7.org/fhir/uv/subscriptions-backport/StructureDefinition/backport-notification-url-location";
        private const string ExtensionMaxCount = "http://hl7.org/fhir/uv/subscriptions-backport/StructureDefinition/backport-max-count";

        private const string CanonicalChannelType = "http://hl7.org/fhir/ValueSet/subscription-channel-type";

        /// <summary>Converts a FHIR R4 Subscription to FHIR R5.</summary>
        /// <param name="s4">The fourth Subscription.</param>
        /// <returns>S4 as a r5.Subscription.</returns>
        public static r5.Subscription ToR5(r4.Subscription s4)
        {
            if (s4 == null)
            {
                return null;
            }

            r5.Subscription s5 = new r5.Subscription()
            {
                Id = s4.Id,
                ImplicitRules = s4.ImplicitRules,
                Language = s4.Language,
                End = s4.End,
                Reason = s4.Reason,
                Endpoint = s4.Channel.Endpoint,
                Header = s4.Channel.Header,
                ContentType = s4.Channel.Payload,
            };

            if (s4.Meta != null)
            {
                s5.Meta = new Meta();

                if (s4.Meta.LastUpdated != null)
                {
                    s5.Meta.LastUpdated = s4.Meta.LastUpdated;
                }

                if (s4.Meta.Profile != null)
                {
                    s5.Meta.Profile = s4.Meta.Profile;
                }

                if (s4.Meta.Security != null)
                {
                    s5.Meta.Security = new List<Coding>();
                    foreach (Coding c4 in s4.Meta.Security)
                    {
                        s5.Meta.Security.Add((Coding)c4.DeepCopy());
                    }
                }

                if (s4.Meta.Source != null)
                {
                    s5.Meta.Source = s4.Meta.Source;
                }

                if (s4.Meta.Tag != null)
                {
                    s5.Meta.Tag = new List<Coding>();
                    foreach (Coding c4 in s4.Meta.Tag)
                    {
                        s5.Meta.Tag.Add((Coding)c4.DeepCopy());
                    }
                }
            }

            switch (s4.Status)
            {
                case r4.Subscription.SubscriptionStatus.Active:
                    s5.Status = r5.SubscriptionState.Active;
                    break;

                case r4.Subscription.SubscriptionStatus.Error:
                    s5.Status = r5.SubscriptionState.Error;
                    break;

                case r4.Subscription.SubscriptionStatus.Off:
                    s5.Status = r5.SubscriptionState.Off;
                    break;

                case r4.Subscription.SubscriptionStatus.Requested:
                    s5.Status = r5.SubscriptionState.Requested;
                    break;

                default:
                    Console.WriteLine($"Invalid R4 Subscription.Status: {s4.Status}");
                    return null;
            }

            switch (s4.Channel.Type)
            {
                case r4.Subscription.SubscriptionChannelType.Email:
                    s5.ChannelType = new Coding()
                    {
                        System = CanonicalChannelType,
                        Code = "email",
                    };
                    break;

                case r4.Subscription.SubscriptionChannelType.Message:
                    s5.ChannelType = new Coding()
                    {
                        System = CanonicalChannelType,
                        Code = "message",
                    };
                    break;

                case r4.Subscription.SubscriptionChannelType.RestHook:
                    s5.ChannelType = new Coding()
                    {
                        System = CanonicalChannelType,
                        Code = "rest-hook",
                    };
                    break;

                case r4.Subscription.SubscriptionChannelType.Websocket:
                    s5.ChannelType = new Coding()
                    {
                        System = CanonicalChannelType,
                        Code = "websocket",
                    };
                    break;

                default:
                    Console.WriteLine($"Invalid R4 Subscription.Channel.Type: {s4.Channel.Type}");
                    return null;
            }

            if (!string.IsNullOrEmpty(s4.Criteria))
            {
                s5.Topic = new ResourceReference(s4.Criteria);
            }

            if (s5.Topic == null)
            {
                Console.WriteLine($"R4 Subscription requires a Topic in criteria: {s4.Criteria}");
                return null;
            }

            if (!SubscriptionTopicManagerR5.TryGetTopic(s5.Topic.Reference, out r5.SubscriptionTopic topic))
            {
                Console.WriteLine($"Unknown R4 SubscriptionTopic: {s5.Topic.Reference}");
                return null;
            }

            if (topic.ResourceTrigger == null)
            {
                Console.WriteLine($"SubscriptionTopic: {topic.Url} requires resourceTrigger");
                return null;
            }

            if ((topic.ResourceTrigger.ResourceType == null) ||
                (!topic.ResourceTrigger.ResourceType.Any()))
            {
                Console.WriteLine($"SubscriptionTopic: {topic.Url} requires resourceTrigger.resourceType");
                return null;
            }

            if (s4.Channel.Extension != null)
            {
                foreach (Extension ext in s4.Channel.Extension)
                {
                    switch (ext.Url)
                    {
                        case ExtensionUrlHeartbeat:
                            if ((ext.Value != null) && (ext.Value is UnsignedInt))
                            {
                                s5.HeartbeatPeriod = ((UnsignedInt)ext.Value).Value;
                            }

                            break;

                        case ExtensionUrlTimeout:
                            if ((ext.Value != null) && (ext.Value is UnsignedInt))
                            {
                                s5.Timeout = ((UnsignedInt)ext.Value).Value;
                            }

                            break;

                        case ExtensionMaxCount:
                            if ((ext.Value != null) && (ext.Value is PositiveInt))
                            {
                                // TODO: Need December 2020 R5 Build
                            }

                            break;
                    }
                }
            }

            if ((s4.Channel.PayloadElement.Extension != null) &&
                (s4.Channel.PayloadElement.Extension.Count > 0))
            {
                foreach (Extension ext in s4.Channel.PayloadElement.Extension)
                {
                    if ((ext.Url == ExtensionUrlContent) && (ext.Value is Code))
                    {
                        switch (((Code)ext.Value).Value)
                        {
                            case "empty":
                                s5.Content = r5.Subscription.SubscriptionPayloadContent.Empty;
                                break;

                            case "id-only":
                                s5.Content = r5.Subscription.SubscriptionPayloadContent.IdOnly;
                                break;

                            case "full-resource":
                                s5.Content = r5.Subscription.SubscriptionPayloadContent.FullResource;
                                break;

                            default:
                                Console.WriteLine($"Invalid R4 Subscription.Channel.Payload Content: {((Code)ext.Value).Value}");
                                return null;
                        }
                    }
                }
            }

            if (s4.CriteriaElement.HasExtensions())
            {
                foreach (Extension ext in s4.CriteriaElement.Extension)
                {
                    if (ext.Url != ExtensionUrlFilterCriteria)
                    {
                        continue;
                    }

                    if (!(ext.Value is FhirString))
                    {
                        continue;
                    }

                    string filter = ext.Value.ToString();

                    string resource = topic.ResourceTrigger.ResourceType.First().Value.ToString();
                    if (!filter.StartsWith(resource, StringComparison.Ordinal))
                    {
                        Console.WriteLine(
                            $"R4 Subscription Filter: {filter}" +
                            $" must match SubscriptionTopic.resourceTrigger.resourceType: {resource}");
                        return null;
                    }

                    // remove initial resource type plus the ?
                    filter = filter.Substring(resource.Length + 1);

                    string[] components = filter.Split('&');

                    if (components.Length > 0)
                    {
                        s5.FilterBy = new List<r5.Subscription.FilterByComponent>();
                    }

                    foreach (string component in components)
                    {
                        if (TryExpandFilter(component, out r5.Subscription.FilterByComponent filterComponent))
                        {
                            s5.FilterBy.Add(filterComponent);
                        }
                    }
                }
            }

            return s5;
        }

        /// <summary>Converts a FHIR R5 Subscription to FHIR R4.</summary>
        /// <param name="s5">The fifth Subscription.</param>
        /// <returns>S5 as a r4.Subscription.</returns>
        public static r4.Subscription ToR4(r5.Subscription s5)
        {
            if (s5 == null)
            {
                return null;
            }

            if (s5.Topic == null)
            {
                return null;
            }

            if (!SubscriptionTopicManagerR5.TryGetTopic(s5.Topic.Reference, out r5.SubscriptionTopic topic))
            {
                Console.WriteLine($"Unknown R5 SubscriptionTopic: {s5.Topic.Reference}");
                return null;
            }

            if (topic.ResourceTrigger == null)
            {
                Console.WriteLine($"SubscriptionTopic: {topic.Url} requires resourceTrigger");
                return null;
            }

            if ((topic.ResourceTrigger.ResourceType == null) ||
                (!topic.ResourceTrigger.ResourceType.Any()))
            {
                Console.WriteLine($"SubscriptionTopic: {topic.Url} requires resourceTrigger.resourceType");
                return null;
            }

            r4.Subscription s4 = new r4.Subscription()
            {
                Id = s5.Id,
                ImplicitRules = s5.ImplicitRules,
                Language = s5.Language,
                End = s5.End,
                Reason = s5.Reason,
                Channel = new r4.Subscription.ChannelComponent()
                {
                    Endpoint = s5.Endpoint,
                    Header = s5.Header,
                    Payload = s5.ContentType,
                },
            };

            if (s5.Meta != null)
            {
                s4.Meta = new Meta();

                if (s5.Meta.LastUpdated != null)
                {
                    s4.Meta.LastUpdated = s5.Meta.LastUpdated;
                }

                if (s5.Meta.Profile != null)
                {
                    s4.Meta.Profile = s5.Meta.Profile;
                }

                if (s5.Meta.Security != null)
                {
                    s4.Meta.Security = new List<Coding>();
                    foreach (Coding c5 in s5.Meta.Security)
                    {
                        s4.Meta.Security.Add((Coding)c5.DeepCopy());
                    }
                }

                if (s5.Meta.Source != null)
                {
                    s4.Meta.Source = s5.Meta.Source;
                }

                if (s5.Meta.Tag != null)
                {
                    s4.Meta.Tag = new List<Coding>();
                    foreach (Coding c5 in s5.Meta.Tag)
                    {
                        s4.Meta.Tag.Add((Coding)c5.DeepCopy());
                    }
                }
            }

            switch (s5.Status)
            {
                case r5.SubscriptionState.Active:
                    s4.Status = r4.Subscription.SubscriptionStatus.Active;
                    break;

                case r5.SubscriptionState.Error:
                    s4.Status = r4.Subscription.SubscriptionStatus.Error;
                    break;

                case r5.SubscriptionState.Off:
                    s4.Status = r4.Subscription.SubscriptionStatus.Off;
                    break;

                case r5.SubscriptionState.Requested:
                    s4.Status = r4.Subscription.SubscriptionStatus.Requested;
                    break;
            }

            switch (s5.ChannelType.Code)
            {
                case "email":
                    s4.Channel.Type = r4.Subscription.SubscriptionChannelType.Email;
                    break;

                case "message":
                    s4.Channel.Type = r4.Subscription.SubscriptionChannelType.Message;
                    break;

                case "rest-hook":
                    s4.Channel.Type = r4.Subscription.SubscriptionChannelType.RestHook;
                    break;

                case "websocket":
                    s4.Channel.Type = r4.Subscription.SubscriptionChannelType.Websocket;
                    break;
            }

            s4.Criteria = s5.Topic.Url.ToString();

            if (s5.HeartbeatPeriod != null)
            {
                s4.Channel.Extension.Add(new Extension()
                {
                    Url = ExtensionUrlHeartbeat,
                    Value = new UnsignedInt(s5.HeartbeatPeriod),
                });
            }

            if (s5.Timeout != null)
            {
                s4.Channel.Extension.Add(new Extension()
                {
                    Url = ExtensionUrlTimeout,
                    Value = new UnsignedInt(s5.Timeout),
                });
            }

            switch (s5.Content)
            {
                case r5.Subscription.SubscriptionPayloadContent.Empty:
                    s4.Channel.PayloadElement.Extension = new List<Extension>()
                    {
                        new Extension()
                        {
                            Url = ExtensionUrlContent,
                            Value = new Code("empty"),
                        },
                    };
                    break;

                case r5.Subscription.SubscriptionPayloadContent.IdOnly:
                    s4.Channel.PayloadElement.Extension = new List<Extension>()
                    {
                        new Extension()
                        {
                            Url = ExtensionUrlContent,
                            Value = new Code("id-only"),
                        },
                    };
                    break;

                case r5.Subscription.SubscriptionPayloadContent.FullResource:
                    s4.Channel.PayloadElement.Extension = new List<Extension>()
                    {
                        new Extension()
                        {
                            Url = ExtensionUrlContent,
                            Value = new Code("full-resource"),
                        },
                    };
                    break;
            }

            if ((s5.FilterBy != null) && (s5.FilterBy.Count > 0))
            {
                StringBuilder sb = new StringBuilder();

                sb.Append($"{topic.ResourceTrigger.ResourceType.First().Value}");

                int addedCount = 0;
                foreach (r5.Subscription.FilterByComponent filter in s5.FilterBy)
                {
                    if (TryCondenseFilter(filter, out string value))
                    {
                        if (addedCount++ == 0)
                        {
                            sb.Append('?');
                        }
                        else
                        {
                            sb.Append('&');
                        }

                        sb.Append(value);
                    }
                }

                s4.CriteriaElement.AddExtension(ExtensionUrlFilterCriteria, new FhirString(sb.ToString()));
            }

            // TODO: Need December 2020 R5 build to add NotificationUrlLocation
            s4.Channel.AddExtension(ExtensionNotificationUrlLocaltion, new Code("full-url"));

            // TODO: Need December 2020 R5 build to add MaxCount
            s4.Channel.AddExtension(ExtensionMaxCount, new PositiveInt(10));

            return s4;
        }

        /// <summary>
        /// Attempts to expand filter a r5.Subscription.FilterByComponent from the given string.
        /// </summary>
        /// <param name="filter">Specifies the filter.</param>
        /// <param name="value"> [out] The value.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        private static bool TryExpandFilter(string filter, out r5.Subscription.FilterByComponent value)
        {
            if (string.IsNullOrEmpty(filter))
            {
                value = null;
                return false;
            }

            string[] components = filter.Split('=');
            if (components.Length != 2)
            {
                Console.WriteLine($"Failed to parse filter: {filter}");
                value = null;
                return false;
            }

            string searchParam = components[0];
            string searchValue = components[1];
            string modifier = string.Empty;
            r5.SubscriptionSearchModifier searchModifier;

            if (searchParam.Contains(':', StringComparison.Ordinal))
            {
                string[] parts = searchParam.Split(':');
                searchParam = parts[0];
                modifier = parts[1];
            }

            if (string.IsNullOrEmpty(modifier) && (searchValue.Length > 2))
            {
                modifier = searchValue.Substring(0, 2);
            }

            switch (modifier)
            {
                case "equal":
                    searchModifier = r5.SubscriptionSearchModifier.Equal;
                    break;

                case "above":
                    searchModifier = r5.SubscriptionSearchModifier.Above;
                    break;

                case "below":
                    searchModifier = r5.SubscriptionSearchModifier.Below;
                    break;

                case "in":
                    searchModifier = r5.SubscriptionSearchModifier.In;
                    break;

                case "not-in":
                    searchModifier = r5.SubscriptionSearchModifier.NotIn;
                    break;

                case "of-type":
                    searchModifier = r5.SubscriptionSearchModifier.OfType;
                    break;

                case "eq":
                    searchModifier = r5.SubscriptionSearchModifier.Eq;
                    searchValue = searchValue.Substring(2);
                    break;

                case "ne":
                    searchModifier = r5.SubscriptionSearchModifier.Ne;
                    searchValue = searchValue.Substring(2);
                    break;

                case "gt":
                    searchModifier = r5.SubscriptionSearchModifier.Gt;
                    searchValue = searchValue.Substring(2);
                    break;

                case "lt":
                    searchModifier = r5.SubscriptionSearchModifier.Lt;
                    searchValue = searchValue.Substring(2);
                    break;

                case "ge":
                    searchModifier = r5.SubscriptionSearchModifier.Ge;
                    searchValue = searchValue.Substring(2);
                    break;

                case "le":
                    searchModifier = r5.SubscriptionSearchModifier.Le;
                    searchValue = searchValue.Substring(2);
                    break;

                case "sa":
                    searchModifier = r5.SubscriptionSearchModifier.Sa;
                    searchValue = searchValue.Substring(2);
                    break;

                case "eb":
                    searchModifier = r5.SubscriptionSearchModifier.Eb;
                    searchValue = searchValue.Substring(2);
                    break;

                case "ap":
                    searchModifier = r5.SubscriptionSearchModifier.Ap;
                    searchValue = searchValue.Substring(2);
                    break;

                default:
                    searchModifier = r5.SubscriptionSearchModifier.Equal;
                    break;
            }

            value = new r5.Subscription.FilterByComponent()
            {
                SearchParamName = searchParam,
                SearchModifier = searchModifier,
                Value = searchValue,
            };

            return true;
        }

        /// <summary>Condense filter.</summary>
        /// <param name="filter">Specifies the filter.</param>
        /// <param name="value"> [out] The value.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        private static bool TryCondenseFilter(r5.Subscription.FilterByComponent filter, out string value)
        {
            if ((filter == null) ||
                (filter.SearchParamName == null))
            {
                value = null;
                return false;
            }

            if ((filter.SearchModifier == null) ||
                (filter.SearchModifier.Value == r5.SubscriptionSearchModifier.Eq) ||
                (filter.SearchModifier.Value == r5.SubscriptionSearchModifier.Equal))
            {
                value = $"{filter.SearchParamName}={filter.Value}";
                return true;
            }

            string modifier = filter.SearchModifier.Value.ToString().ToLowerInvariant();

            switch (filter.SearchModifier.Value)
            {
                case r5.SubscriptionSearchModifier.Above:
                case r5.SubscriptionSearchModifier.Below:
                case r5.SubscriptionSearchModifier.In:
                    value = $"{filter.SearchParamName}:{modifier}={filter.Value}";
                    break;

                case r5.SubscriptionSearchModifier.NotIn:
                    value = $"{filter.SearchParamName}:not-in={filter.Value}";
                    break;

                case r5.SubscriptionSearchModifier.OfType:
                    value = $"{filter.SearchParamName}:of-type={filter.Value}";
                    break;

                default:
                    value = $"{filter.SearchParamName}={modifier}{filter.Value}";
                    break;
            }

            return true;
        }
    }
}
