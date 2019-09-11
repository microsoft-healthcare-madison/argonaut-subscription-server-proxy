using System;
using System.Collections.Generic;
using System.Text;

namespace argonaut_subscription_server_proxy.Models
{
    public class SubscriptionFilterNode
    {
        public List<fhir.Subscription> Subscriptions { get; set; }

        public Dictionary<string, SubscriptionFilterNode> Inclusions { get; set; }

        public Dictionary<string, SubscriptionFilterNode> Exclusions { get; set; }
    }
}
