using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace argonaut_subscription_server_proxy.Models
{
    public class CriteriaByQuery
    {
        public string previous { get; set; }

        public string current { get; set; }

        public bool requireBoth { get; set; }
    }
}
