using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace argonaut_subscription_server_proxy.Models
{
    public class Subscription
    {
        /// <summary>Type of the resource.</summary>
        public readonly string resourceType = "Subscription";

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Inherited from Resource</summary>
        ///
        /// <value>The identifier.</value>
        ///-------------------------------------------------------------------------------------------------

        public string id { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Gets or sets the identifier.</summary>
        ///
        /// <value>The identifier.</value>
        ///-------------------------------------------------------------------------------------------------

        public List<Identifier> identifier { get; set; }

        public string name { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Status of Subscription: requested | active | error | off</summary>
        ///
        /// <value>The status.</value>
        ///-------------------------------------------------------------------------------------------------

        public Code status { get; set; }

        public List<ContactPoint> contact { get; set; }

        public Instant end { get; set; }

        public string reason { get; set; }

        public string topic { get; set; }

        public List<FilterParameter> filterBy { get; set; }

        public List<CodeableConcept> error { get; set; }

        public PositiveInt eventCount { get; set; }

        public Channel channel { get; set; }
    }
}
