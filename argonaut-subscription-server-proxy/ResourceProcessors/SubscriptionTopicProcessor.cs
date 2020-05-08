// <copyright file="SubscriptionTopicProcessor.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir4;
extern alias fhir5;

using System.Net.Http;
using argonaut_subscription_server_proxy.Managers;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProxyKit;
using r4 = fhir4.Hl7.Fhir.Model;
using r4s = fhir4.Hl7.Fhir.Serialization;
using r5 = fhir5.Hl7.Fhir.Model;
using r5s = fhir5.Hl7.Fhir.Serialization;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>A topic processor.</summary>
    public abstract class SubscriptionTopicProcessor
    {
        private static CamelCasePropertyNamesContractResolver _contractResolver = new CamelCasePropertyNamesContractResolver();

        /// <summary>Process the request described by appInner.</summary>
        /// <param name="appInner">     The application inner.</param>
        /// <param name="fhirServerUrl">URL of the fhir server.</param>
        public static void ProcessRequest(IApplicationBuilder appInner, string fhirServerUrl)
        {
            // run the proxy for this request
            appInner.RunProxy(async context =>
            {
                // look for a FHIR server header
                if (context.Request.Headers.ContainsKey(Program._proxyHeaderKey) &&
                    (context.Request.Headers[Program._proxyHeaderKey].Count > 0))
                {
                    fhirServerUrl = context.Request.Headers[Program._proxyHeaderKey][0];
                }

                HttpResponseMessage response = new HttpResponseMessage();

                r5s.FhirJsonSerializer serializer = new r5s.FhirJsonSerializer(null);

                // return appropriate code to the caller
                switch (context.Request.Method.ToUpperInvariant())
                {
                    case "GET":

                        // *** success ****
                        response.Content = new StringContent(
                            serializer.SerializeToString(
                                SubscriptionTopicManager.GetTopicsBundle()));
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
