using argonaut_subscription_server_proxy.Managers;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProxyKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    public class SubscriptionProcessor
    {

        private static CamelCasePropertyNamesContractResolver _contractResolver = new CamelCasePropertyNamesContractResolver();

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Process the request.</summary>
        ///
        /// <remarks>Gino Canessa, 8/7/2019.</remarks>
        ///
        /// <param name="appInner">     The application inner.</param>
        /// <param name="fhirServerUrl">URL of the fhir server.</param>
        ///-------------------------------------------------------------------------------------------------

        public static void ProcessRequest(IApplicationBuilder appInner, string fhirServerUrl)
        {
            // **** run the proxy for this request ****

            appInner.RunProxy(async context => {
            // **** grab a formatted copy of this request for proxying ****

            //ForwardContext proxiedContext = context.ForwardTo(fhirServerUrl);

            HttpResponseMessage response = new HttpResponseMessage();

            // **** return appropriate code to the caller ****

            switch (context.Request.Method.ToUpper())
            {
                case "GET":

                    // *** success ****

                    response.Content = new StringContent(
                        JsonConvert.SerializeObject(
                            SubscriptionManager.GetSubscriptionList(),
                            new JsonSerializerSettings()
                            {
                                NullValueHandling = NullValueHandling.Ignore,
                                ContractResolver = _contractResolver,
                            })
                        );
                    response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    response.StatusCode = System.Net.HttpStatusCode.OK;

                    break;

                case "PUT":

                    // *** not implemented ****

                    response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

                    break;

                case "POST":

                    // **** grab the message body to look at ****

                    System.IO.StreamReader requestReader = new System.IO.StreamReader(context.Request.Body);
                    string requestContent = requestReader.ReadToEnd();

                    // **** check to see if the manager does anything with this text ****

                    SubscriptionManager.HandlePost(requestContent, out fhir.Subscription subscription);

                    // **** serialize our response ****

                    response.Content = new StringContent(
                        JsonConvert.SerializeObject(
                            subscription,
                            new JsonSerializerSettings()
                            {
                                NullValueHandling = NullValueHandling.Ignore,
                                ContractResolver = _contractResolver,
                            })
                        );
                    response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    response.StatusCode = System.Net.HttpStatusCode.Created;

                    break;

                case "DELETE":

                    // **** ask the subscription manager to deal with this ***

                    if (SubscriptionManager.HandleDelete(context.Request))
                    {
                        response.StatusCode = System.Net.HttpStatusCode.NoContent;
                    }
                    else
                    {
                        // *** failed ****

                        response.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                    }

                    break;

                default:

                    // **** tell client we didn't understand ****

                    response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

                    break;
            }

                return response;
            });
        }

    }
}
