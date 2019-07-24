using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace argonaut_subscription_server_proxy.Models
{
    public class Criteria
    {
        [JsonProperty(PropertyName = "byCriteria")]
        public CriteriaByQuery queryCriteria { get; set; }

        [JsonProperty(PropertyName = "byFHIRPath")]
        public string fhirPathCriteria { get; set; }
    }
}
