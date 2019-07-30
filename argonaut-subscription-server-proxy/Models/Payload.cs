using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace argonaut_subscription_server_proxy.Models
{
    public class Payload
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>MIME type to send, omit for no payload</summary>
        ///
        /// <value>The type of the content.</value>
        ///-------------------------------------------------------------------------------------------------

        //public Code contentType { get; set; }
        public string contentType { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Payload type to send:  empty | id-only | full-resource</summary>
        ///
        /// <value>The content.</value>
        ///-------------------------------------------------------------------------------------------------

        //public Code content { get; set; }
        public string content { get; set; }
    }
}
