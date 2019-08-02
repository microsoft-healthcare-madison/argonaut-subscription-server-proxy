﻿using argonaut_subscription_server_proxy.Managers;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using ProxyKit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    public class EncounterProcessor
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>Process the request.</summary>
        ///
        /// <remarks>Gino Canessa, 8/1/2019.</remarks>
        ///
        /// <param name="appInner">     The application inner.</param>
        /// <param name="fhirServerUrl">URL of the fhir server.</param>
        ///-------------------------------------------------------------------------------------------------

        public static void ProcessRequest(IApplicationBuilder appInner, string fhirServerUrl)
        {
            // **** run the proxy for this request ****

            appInner.RunProxy(async context =>
            {
                // **** proxy this call ****

                ForwardContext proxiedContext = context.ForwardTo(fhirServerUrl);

                // **** send to server and await response ****

                HttpResponseMessage response = await proxiedContext.Send();

                // **** get copies of data when we care ****

                switch (context.Request.Method.ToUpper())
                {
                    case "PUT":
                    case "POST":

                        // **** grab the message body to look at ****
                        
                        string responseContent = await response.Content.ReadAsStringAsync();

                        // **** run this Encounter through our Subscription Manager ****

                        SubscriptionManager.ProcessEncounter(responseContent);

                        break;

                    default:

                        // **** ignore ****

                        break;
                }

                // **** return the results of the proxied call ****

                return response;
            });
        }
    }
}
