using System;
using System.Collections.Generic;
using System.Text;

namespace argonaut_subscription_server_proxy.Models
{
    public class SubscriptionTestNode
    {
        public string Resource { get; set; }

        public List<fhir.Subscription> Subscriptions { get; set; }

        public Dictionary<string, SubscriptionTestNode> ChainedInclusions { get; set; }

        public Dictionary<string, SubscriptionTestNode> ChanedExclusions { get; set; }
    }
}
