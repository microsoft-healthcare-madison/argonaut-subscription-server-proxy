using argonaut_subscription_server_proxy.Managers;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using ProxyKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    public class ResourceProcessor
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>Process the request.</summary>
        ///
        /// <remarks>Gino Canessa, 8/26/2019.</remarks>
        ///
        /// <param name="appInner">     The application inner.</param>
        /// <param name="fhirServerUrl">URL of the fhir server.</param>
        ///-------------------------------------------------------------------------------------------------

        public static void ProcessRequest(IApplicationBuilder appInner, string fhirServerUrl)
        {
            // **** run the proxy for this request ****

            appInner.RunProxy(async context =>
            {
                // **** determine the type of resource this request is for ****


                // **** determine if we need to ask the server for a current version of the resource ****

                switch (context.Request.Method)
                {
                    case "PUT":
                    case "POST":
                    case "DELETE":

                        // **** figure out if we need to ask the server about this ****



                        break;

                    default:
                        // **** don't need to check for existing copy ****
                        break;
                }

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

                        SubscriptionManager.ProcessEncounter(responseContent, response.Headers.Location);

                        break;

                    default:

                    // **** just proxy ****

                    break;
                }

                // **** return the results of the proxied call ****

                return response;
            });
        }
    }
}
