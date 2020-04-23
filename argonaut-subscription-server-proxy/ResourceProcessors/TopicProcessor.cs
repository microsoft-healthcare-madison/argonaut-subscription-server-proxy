using argonaut_subscription_server_proxy.Managers;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using ProxyKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Microsoft.Extensions.Primitives;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    public class TopicProcessor
    {
        private static CamelCasePropertyNamesContractResolver _contractResolver = new CamelCasePropertyNamesContractResolver();

        /// <summary>Process the request described by appInner.</summary>
        /// <param name="appInner">     The application inner.</param>
        /// <param name="fhirServerUrl">URL of the fhir server.</param>
        public static void ProcessRequest(IApplicationBuilder appInner, string fhirServerUrl)
        {
            // run the proxy for this request

            appInner.RunProxy(async context => {
                // look for a FHIR server header

                if ((context.Request.Headers.ContainsKey(Program._proxyHeaderKey)) &&
                    (context.Request.Headers[Program._proxyHeaderKey].Count > 0))
                {
                    fhirServerUrl = context.Request.Headers[Program._proxyHeaderKey][0];
                }

                HttpResponseMessage response = new HttpResponseMessage();

                // return appropriate code to the caller

                switch (context.Request.Method.ToUpper())
                {
                    case "GET":

                        // *** success ****

                        response.Content = new StringContent(
                            JsonConvert.SerializeObject(
                                TopicManager.GetTopicsBundle(),
                                new JsonSerializerSettings()
                                {
                                    NullValueHandling = NullValueHandling.Ignore,
                                    ContractResolver = _contractResolver,
                                }
                                )
                            );
                        response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                        response.StatusCode = System.Net.HttpStatusCode.OK;

                        break;

                    case "PUT":

                        // *** success ****

                        response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

                        break;

                    case "POST":

                        // grab the message body to look at

                        System.IO.StreamReader requestReader = new System.IO.StreamReader(context.Request.Body);
                        string requestContent = requestReader.ReadToEnd();

                        response.Content = new StringContent(requestContent);

                        // *** not implemented yet ****

                        response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

                        break;

                    case "DELETE":

                        // *** success ****

                        response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

                        break;

                    default:

                        // tell client we didn't understand

                        response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

                        break;
                }

                return response;
            });
        }
    }
}
