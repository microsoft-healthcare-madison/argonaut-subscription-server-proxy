// <copyright file="SubscriptionFilterNode.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir4;
extern alias fhir5;

using System.Collections.Generic;
using r4 = fhir4.Hl7.Fhir.Model;
using r5 = fhir5.Hl7.Fhir.Model;

namespace argonaut_subscription_server_proxy.Models
{
    /// <summary>A subscription filter node.</summary>
    public class SubscriptionFilterNode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionFilterNode"/> class.
        /// </summary>
        public SubscriptionFilterNode()
        {
            SubscriptionsR4 = new List<r4.Subscription>();
            SubscriptionsR5 = new List<r5.Subscription>();
            Inclusions = new Dictionary<string, SubscriptionFilterNode>();
            Exclusions = new Dictionary<string, SubscriptionFilterNode>();
        }

        /// <summary>Gets or sets the subscriptions.</summary>
        /// <value>The subscriptions.</value>
        public List<r5.Subscription> SubscriptionsR5 { get; set; }

        /// <summary>Gets or sets the subscriptions.</summary>
        /// <value>The subscriptions.</value>
        public List<r4.Subscription> SubscriptionsR4 { get; set; }

        /// <summary>Gets or sets the inclusions.</summary>
        /// <value>The inclusions.</value>
        public Dictionary<string, SubscriptionFilterNode> Inclusions { get; set; }

        /// <summary>Gets or sets the exclusions.</summary>
        /// <value>The exclusions.</value>
        public Dictionary<string, SubscriptionFilterNode> Exclusions { get; set; }

        /// <summary>Removes the subscription described by ID.</summary>
        /// <param name="id">            The identifier.</param>
        /// <param name="nodeIsNowEmpty">[out] True if node is now empty.</param>
        public void RemoveSubscription(string id, out bool nodeIsNowEmpty)
        {
            List<r4.Subscription> r4ToRemove = new List<r4.Subscription>();
            foreach (r4.Subscription subscription in SubscriptionsR4)
            {
                if (subscription.Id == id)
                {
                    r4ToRemove.Add(subscription);
                }
            }

            if (r4ToRemove.Count != 0)
            {
                foreach (r4.Subscription subscription in r4ToRemove)
                {
                    SubscriptionsR4.Remove(subscription);
                }
            }

            List<r5.Subscription> r5ToRemove = new List<r5.Subscription>();
            foreach (r5.Subscription subscription in SubscriptionsR5)
            {
                if (subscription.Id == id)
                {
                    r5ToRemove.Add(subscription);
                }
            }

            if (r5ToRemove.Count != 0)
            {
                foreach (r5.Subscription subscription in r5ToRemove)
                {
                    SubscriptionsR5.Remove(subscription);
                }
            }

            List<string> nodeKeysToRemove = new List<string>();

            foreach (KeyValuePair<string, SubscriptionFilterNode> kvp in Inclusions)
            {
                kvp.Value.RemoveSubscription(id, out bool isEmpty);

                if (isEmpty)
                {
                    nodeKeysToRemove.Add(kvp.Key);
                }
            }

            if (nodeKeysToRemove.Count != 0)
            {
                foreach (string key in nodeKeysToRemove)
                {
                    Inclusions.Remove(key);
                }

                nodeKeysToRemove.Clear();
            }

            foreach (KeyValuePair<string, SubscriptionFilterNode> kvp in Exclusions)
            {
                kvp.Value.RemoveSubscription(id, out bool isEmpty);

                if (isEmpty)
                {
                    nodeKeysToRemove.Add(kvp.Key);
                }
            }

            if (nodeKeysToRemove.Count != 0)
            {
                foreach (string key in nodeKeysToRemove)
                {
                    Exclusions.Remove(key);
                }

                nodeKeysToRemove.Clear();
            }

            nodeIsNowEmpty = IsEmpty();
        }

        /// <summary>Query if this object is empty.</summary>
        /// <returns>True if empty, false if not.</returns>
        public bool IsEmpty()
        {
            if ((SubscriptionsR4.Count == 0) &&
                (SubscriptionsR5.Count == 0) &&
                (Inclusions.Count == 0) &&
                (Exclusions.Count == 0))
            {
                return true;
            }

            return false;
        }
    }
}
