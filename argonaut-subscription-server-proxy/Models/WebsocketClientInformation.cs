using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace argonaut_subscription_server_proxy.Models
{
    public class WebsocketClientInformation
    {
        /// <summary>Client payload types.</summary>
        public sealed class WebsocketPayloadTypes
        {
            public const string R4 = "r4";
            public const string EMPTY = "empty";
            public const string ID_ONLY = "id-only";
            public const string FULL_RESOURCE = "full-resource";
        }

        /// <summary>Gets or sets the UID.</summary>
        /// <value>The UID.</value>
        public Guid Uid { get; set; }

        /// <summary>Gets or sets the type of the payload.</summary>
        /// <value>The type of the payload.</value>
        public string PayloadType { get; set; }

        /// <summary>Gets or sets the message q.</summary>
        /// <value>The message q.</value>
        public ConcurrentQueue<string> MessageQ { get; set; }

        /// <summary>Gets or sets the set the subscription identifiers belongs to.</summary>
        /// <value>The subscription identifiers set.</value>
        public HashSet<string> SubscriptionIdSet { get; set; }

                                                                            }
}
