// <copyright file="BackportedSubscription.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir4;
extern alias fhir5;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using r4 = fhir4.Hl7.Fhir.Model;
using r4s = fhir4.Hl7.Fhir.Serialization;
using r5 = fhir5.Hl7.Fhir.Model;
using r5s = fhir5.Hl7.Fhir.Serialization;

namespace argonaut_subscription_server_proxy.Backport
{
    /// <summary>
    /// Class with Subscription extensions for R5 Backported R4 Subscriptions.
    /// </summary>
    public static class BackportedSubscription
    {
        /// <summary>URL of the profile.</summary>
        public const string ProfileUrl = "http://hl7.org/fhir/uv/subscriptions-backport";

        /// <summary>The extension URL filter criteria.</summary>
        public const string ExtensionUrlFilterCriteria = "http://hl7.org/fhir/uv/subscriptions-backport/StructureDefinition/backport-filter-criteria";

        /// <summary>The extension URL heartbeat.</summary>
        public const string ExtensionUrlHeartbeat = "http://hl7.org/fhir/uv/subscriptions-backport/StructureDefinition/backport-heartbeat-period";

        /// <summary>The extension URL timeout.</summary>
        public const string ExtensionUrlTimeout = "http://hl7.org/fhir/uv/subscriptions-backport/StructureDefinition/backport-timeout";

        /// <summary>The extension URL content.</summary>
        public const string ExtensionUrlContent = "http://hl7.org/fhir/uv/subscriptions-backport/StructureDefinition/backport-payload-content";

        /// <summary>The extension notification URL localtion.</summary>
        public const string ExtensionUrlNotificationUrlLocaltion = "http://hl7.org/fhir/uv/subscriptions-backport/StructureDefinition/backport-notification-url-location";

        /// <summary>Number of extension maximums.</summary>
        public const string ExtensionUrlMaxCount = "http://hl7.org/fhir/uv/subscriptions-backport/StructureDefinition/backport-max-count";

        /// <summary>The extension URL for a notification focus resource.</summary>
        public const string ExtensionUrlNotificationFocus = "http://hl7.org/fhir/uv/subscriptions-backport/StructureDefinition/subscription-notification-focus-resource";

        /// <summary>The extension URL for notification additional resource.</summary>
        public const string ExtensionUrlNotificationIncluded = "http://hl7.org/fhir/uv/subscriptions-backport/StructureDefinition/subscription-notification-included-resource";

        /// <summary>Type of the canonical channel.</summary>
        public const string CanonicalChannelType = "http://hl7.org/fhir/ValueSet/subscription-channel-type";

        /// <summary>The content code empty.</summary>
        public const string ContentCodeEmpty = "empty";

        /// <summary>The content code identifier only.</summary>
        public const string ContentCodeIdOnly = "id-only";

        /// <summary>The content code full resource.</summary>
        public const string ContentCodeFullResource = "full-resource";

        /// <summary>A r4.Subscription extension method that backport filters get.</summary>
        /// <param name="resource">The resource.</param>
        /// <returns>A List&lt;string&gt;</returns>
        public static List<FilterByComponent> BackportFiltersGet(this r4.Subscription resource)
        {
            List<FilterByComponent> filters = new List<FilterByComponent>();

            if (!resource.CriteriaElement.HasExtensions())
            {
                return filters;
            }

            foreach (Extension ext in resource.CriteriaElement.GetExtensions(ExtensionUrlFilterCriteria))
            {
                if (!(ext.Value is FhirString))
                {
                    continue;
                }

                FilterByComponent filter;

                string filterString = ((FhirString)ext.Value).Value;
                string resourceName;

                int delimterIndex = filterString.IndexOf('?');

                if (delimterIndex != -1)
                {
                    resourceName = filterString.Substring(delimterIndex);
                    filterString = filterString.Substring(delimterIndex + 1);
                }
                else
                {
                    resourceName = string.Empty;
                }

                if (TryExpandFilter(filterString, out filter))
                {
                    filter.Resource = resourceName;
                    filters.Add(filter);
                }
            }

            return filters;
        }

        /// <summary>
        /// Attempts to expand filter a r5.Subscription.FilterByComponent from the given string.
        /// </summary>
        /// <param name="filter">Specifies the filter.</param>
        /// <param name="value"> [out] The value.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        private static bool TryExpandFilter(string filter, out FilterByComponent value)
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

            value = new FilterByComponent()
            {
                FilterParameter = searchParam,
                Modifier = searchModifier,
                Value = searchValue,
            };

            return true;
        }

        /// <summary>A r4.Subscription extension method that backport heartbeat get.</summary>
        /// <param name="resource">The resource.</param>
        /// <returns>An int.</returns>
        public static int BackportChannelHeartbeatGet(this r4.Subscription resource)
        {
            Extension ext = resource.Channel.GetExtension(ExtensionUrlHeartbeat);

            if ((ext == null) || (ext.Value == null))
            {
                return -1;
            }

            switch (ext.Value)
            {
                case UnsignedInt valueUnsignedInt:
                    return (int)valueUnsignedInt.Value;
                case Integer valueInt:
                    return (int)valueInt.Value;
            }

            return -1;
        }

        /// <summary>A r4.Subscription extension method that backport channel timeout get.</summary>
        /// <param name="resource">The resource.</param>
        /// <returns>An int.</returns>
        public static int BackportChannelTimeoutGet(this r4.Subscription resource)
        {
            Extension ext = resource.Channel.GetExtension(ExtensionUrlTimeout);

            if ((ext == null) || (ext.Value == null))
            {
                return -1;
            }

            switch (ext.Value)
            {
                case UnsignedInt valueUnsignedInt:
                    return (int)valueUnsignedInt.Value;
                case Integer valueInt:
                    return (int)valueInt.Value;
            }

            return -1;
        }

        /// <summary>A r4.Subscription extension method that backport content get.</summary>
        /// <param name="resource">The resource.</param>
        /// <returns>A string.</returns>
        public static string BackportContentGet(this r4.Subscription resource)
        {
            Extension ext = resource.Channel.PayloadElement.GetExtension(ExtensionUrlContent);

            if ((ext == null) || (ext.Value == null))
            {
                return null;
            }

            if ((ext.Url == ExtensionUrlContent) && (ext.Value is Code))
            {
                switch (((Code)ext.Value).Value)
                {
                    case "empty":
                        return ContentCodeEmpty;
                    case "id-only":
                        return ContentCodeIdOnly;
                    case "full-resource":
                        return ContentCodeFullResource;
                    default:
                        Console.WriteLine($"Invalid Subscription.Channel.Payload Content: {((Code)ext.Value).Value}");
                        return null;
                }
            }

            return null;
        }

        /// <summary>A r4.Subscription extension method that backport topic get.</summary>
        /// <param name="resource">The resource.</param>
        /// <returns>A string.</returns>
        public static string BackportTopicGet(this r4.Subscription resource) => resource.Criteria;

        /// <summary>A filter by component.</summary>
        public class FilterByComponent
        {
            /// <summary>Gets or sets the resource.</summary>
            public string Resource { get; set; }

            /// <summary>Gets or sets the filter parameter.</summary>
            public string FilterParameter { get; set; }

            /// <summary>Gets or sets the modifier.</summary>
            public r5.SubscriptionSearchModifier Modifier { get; set; }

            /// <summary>Gets or sets the value.</summary>
            public string Value { get; set; }
        }
    }
}
