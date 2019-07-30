using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace argonaut_subscription_server_proxy.Models
{
    public class Channel
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>Channel type: rest-hook | websocket | email | sms | message</summary>
        ///
        /// <value>The type.</value>
        ///-------------------------------------------------------------------------------------------------

        public CodeableConcept type { get; set; }

        public FhirUrl endpoint { get; set; }

        public List<string> header { get; set; }

        public PositiveInt heartbeatPeriod { get; set; }

        public Payload payload { get; set; }
    }
}
