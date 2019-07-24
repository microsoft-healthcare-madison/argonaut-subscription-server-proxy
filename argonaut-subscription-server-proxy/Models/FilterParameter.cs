using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace argonaut_subscription_server_proxy.Models
{
    public class FilterParameter
    {
        public string name { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Match type: = | in | above | below | member-of-group</summary>
        ///
        /// <value>The type of the match.</value>
        ///-------------------------------------------------------------------------------------------------

        public Code matchType { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Literal value or resource path</summary>
        ///
        /// <value>The value.</value>
        ///-------------------------------------------------------------------------------------------------

        public string value { get; set; }
    }
}
