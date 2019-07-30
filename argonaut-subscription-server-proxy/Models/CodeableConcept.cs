using System;
using System.Collections.Generic;
using System.Text;

namespace argonaut_subscription_server_proxy.Models
{
    public class CodeableConcept
    {
        public Coding[] coding { get; set; }
        public string text { get; set; }
    }
}
