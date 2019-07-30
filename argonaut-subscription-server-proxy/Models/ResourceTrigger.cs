using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hl7.Fhir.Model;

namespace argonaut_subscription_server_proxy.Models
{
    public class ResourceTrigger
    {
        public string description { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Candidate resource types for this topic</summary>
        ///
        /// <value>The type of the resource.</value>
        ///-------------------------------------------------------------------------------------------------

        public List<Code> resourceType { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Method criteria: create | update | delete</summary>
        ///
        /// <value>The method criteria.</value>
        ///-------------------------------------------------------------------------------------------------

        public List<Code> methodCriteria { get; set; }

        public Criteria criteria { get; set; }

    }
}
