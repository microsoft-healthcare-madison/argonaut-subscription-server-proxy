using argonaut_subscription_server_proxy.Managers;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using ProxyKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    public class TopicProcessor
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>Process the request described by appInner.</summary>
        ///
        /// <remarks>Gino Canessa, 7/2/2019.</remarks>
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

                switch (context.Request.Method.ToLower())
                {
                    case "get":

                        // *** success ****

                        response.Content = new StringContent(JsonConvert.SerializeObject(TopicManager.GetTopicList()));
                        response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                        response.StatusCode = System.Net.HttpStatusCode.OK;

                        break;

                    case "put":

                        // *** success ****

                        response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

                        break;

                    case "post":

                        // **** grab the message body to look at ****

                        System.IO.StreamReader requestReader = new System.IO.StreamReader(context.Request.Body);
                        string requestContent = requestReader.ReadToEnd();

                        response.Content = new StringContent(requestContent);

                        // *** not implemented yet ****

                        response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

                        break;

                    case "delete":

                        // *** success ****

                        response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

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
