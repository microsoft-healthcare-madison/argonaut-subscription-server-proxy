// <copyright file="BackportedSubscriptionCs.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using fhirCsModels4B = fhirCsR4B.Models;
using fhirCsModels5 = fhirCsR5.Models;
using fhirCsValueSets4B = fhirCsR4B.ValueSets;
using fhirCsValueSets5 = fhirCsR5.ValueSets;

namespace argonaut_subscription_server_proxy.Backport
{
    /// <summary>
    /// Class with Subscription extensions for R5 Backported R4 Subscriptions.
    /// </summary>
    public static class BackportedSubscriptionCs
    {
        /// <summary>URL of the profile.</summary>
        public const string ProfileUrl = "http://hl7.org/fhir/uv/subscriptions-backport";

        /// <summary>Type of the extension URL additional channel.</summary>
        public const string ExtensionUrlAdditionalChannelType = "http://hl7.org/fhir/uv/subscriptions-backport/StructureDefinition/backport-channel-type";

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

        /// <summary>
        /// A fhirCsModels4B.Subscription extension method that attempts to backport additional channel type get a
        /// string from the given r4.Subscription.
        /// </summary>
        /// <param name="resource">   The resource.</param>
        /// <param name="channelType">[out] Type of the channel.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        public static bool BackportAdditionalChannelTypeTryGet(this fhirCsModels4B.Subscription resource, out string channelType)
        {
            if (resource == null)
            {
                channelType = null;
                return false;
            }

            if ((resource.Channel.Extension == null) ||
                (!resource.Channel.Extension.Any()))
            {
                channelType = null;
                return false;
            }

            foreach (fhirCsModels4B.Extension ext in resource.Channel.Extension)
            {
                if (ext.Url != ExtensionUrlAdditionalChannelType)
                {
                    continue;
                }

                if ((ext != null) &&
                    (ext.ValueCoding != null) &&
                    (!string.IsNullOrWhiteSpace(ext.ValueCoding.Code)))
                {
                    channelType = $"{ext.ValueCoding.System}#{ext.ValueCoding.Code}";
                    return true;
                }
            }

            channelType = null;
            return false;
        }

        /// <summary>A fhirCsModels4B.Subscription extension method that backport filters get.</summary>
        /// <param name="resource">The resource.</param>
        /// <returns>A List of Filter By Components.</returns>
        public static List<FilterByComponent> BackportFiltersGet(this fhirCsModels4B.Subscription resource)
        {
            List<FilterByComponent> filters = new ();

            if ((resource._Criteria == null) ||
                (resource._Criteria.Extension == null) ||
                (resource._Criteria.Extension.Count == 0))
            {
                return filters;
            }

            foreach (fhirCsModels4B.Extension ext in
                resource._Criteria.Extension.Where(ext => ext.Url.Equals(ExtensionUrlFilterCriteria, StringComparison.Ordinal)))
            {
                if (string.IsNullOrEmpty(ext.ValueString))
                {
                    continue;
                }

                FilterByComponent filter;

                string filterString = ext.ValueString;
                string resourceName;

                int delimterIndex = filterString.IndexOf('?');

                if (delimterIndex != -1)
                {
                    resourceName = filterString.Substring(0, delimterIndex);
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
            string searchModifier = "=";        // default to equality

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

            if (fhirCsModels5.SubscriptionFilterBySearchModifierCodes.Values.Contains(modifier))
            {
                searchModifier = modifier;
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
        public static int BackportChannelHeartbeatGet(this fhirCsModels4B.Subscription resource)
        {
            if ((resource.Channel == null) ||
                (resource.Channel.Extension == null) ||
                (resource.Channel.Extension.Count == 0))
            {
                return -1;
            }

            fhirCsModels4B.Extension ext = resource.Channel.Extension.First(ext => ext.Url.Equals(ExtensionUrlHeartbeat, StringComparison.Ordinal));

            if (ext == null)
            {
                return -1;
            }

            if (ext.ValueUnsignedInt != null)
            {
                return (int)ext.ValueUnsignedInt;
            }

            if (ext.ValueInteger != null)
            {
                return (int)ext.ValueInteger;
            }

            return -1;
        }

        /// <summary>A fhirCsModels4B.Subscription extension method that gets the backport channel timeout.</summary>
        /// <param name="resource">The resource.</param>
        /// <returns>An int.</returns>
        public static int BackportChannelTimeoutGet(this fhirCsModels4B.Subscription resource)
        {
            if ((resource.Channel == null) ||
                (resource.Channel.Extension == null) ||
                (resource.Channel.Extension.Count == 0))
            {
                return -1;
            }

            fhirCsModels4B.Extension ext = resource.Channel.Extension.First(ext => ext.Url.Equals(ExtensionUrlTimeout, StringComparison.Ordinal));

            if (ext == null)
            {
                return -1;
            }

            if (ext.ValueUnsignedInt != null)
            {
                return (int)ext.ValueUnsignedInt;
            }

            if (ext.ValueInteger != null)
            {
                return (int)ext.ValueInteger;
            }

            return -1;
        }

        /// <summary>A fhirCsModels4B.Subscription extension method that backport content get.</summary>
        /// <param name="resource">The resource.</param>
        /// <returns>A string.</returns>
        public static string BackportContentGet(this fhirCsModels4B.Subscription resource)
        {
            if ((resource.Channel == null) ||
                (resource.Channel._Payload == null) ||
                (resource.Channel._Payload.Extension == null) ||
                (resource.Channel._Payload.Extension.Count == 0))
            {
                return null;
            }

            fhirCsModels4B.Extension ext = resource.Channel._Payload.Extension.First(ext => ext.Url.Equals(ExtensionUrlContent, StringComparison.Ordinal));

            if (ext == null)
            {
                return null;
            }

            if ((!string.IsNullOrEmpty(ext.ValueCode)) &&
                fhirCsModels5.SubscriptionContentCodes.Values.Contains(ext.ValueCode))
            {
                return ext.ValueCode;
            }

            Console.WriteLine($"BackportContentGet <<< Invalid Payload Content: {ext.ValueCode}");
            return null;
        }

        /// <summary>A r4.Subscription extension method that backport topic get.</summary>
        /// <param name="resource">The resource.</param>
        /// <returns>A string.</returns>
        public static string BackportTopicGet(this fhirCsModels4B.Subscription resource) => resource.Criteria;

        /// <summary>A filter by component.</summary>
        public class FilterByComponent
        {
            /// <summary>Gets or sets the resource.</summary>
            public string Resource { get; set; }

            /// <summary>Gets or sets the filter parameter.</summary>
            public string FilterParameter { get; set; }

            /// <summary>Gets or sets the modifier.</summary>
            public string Modifier { get; set; }

            /// <summary>Gets or sets the value.</summary>
            public string Value { get; set; }

            /// <summary>Returns a string that represents the current object.</summary>
            /// <returns>A string that represents the current object.</returns>
            public override string ToString()
            {
                if (string.IsNullOrEmpty(Modifier) ||
                    (Modifier == fhirCsModels5.SubscriptionFilterBySearchModifierCodes.EQUALS) ||
                    (Modifier == fhirCsModels5.SubscriptionFilterBySearchModifierCodes.EQ))
                {
                    return $"{Resource}?{FilterParameter}={Value}";
                }

                return $"{Resource}?{FilterParameter}:{Modifier}={Value}";
            }
        }
    }
}
