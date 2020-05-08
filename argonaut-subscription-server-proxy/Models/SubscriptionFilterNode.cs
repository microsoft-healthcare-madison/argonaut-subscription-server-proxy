// <copyright file="SubscriptionFilterNode.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir5;

using System.Collections.Generic;
using r5 = fhir5.Hl7.Fhir.Model;

namespace argonaut_subscription_server_proxy.Models
{
    /// <summary>A subscription filter node.</summary>
    public class SubscriptionFilterNode
    {
        /// <summary>Gets or sets the subscriptions.</summary>
        /// <value>The subscriptions.</value>
        public List<r5.Subscription> Subscriptions { get; set; }

        /// <summary>Gets or sets the inclusions.</summary>
        /// <value>The inclusions.</value>
        public Dictionary<string, SubscriptionFilterNode> Inclusions { get; set; }

        /// <summary>Gets or sets the exclusions.</summary>
        /// <value>The exclusions.</value>
        public Dictionary<string, SubscriptionFilterNode> Exclusions { get; set; }
    }
}
