using argonaut_subscription_server_proxy.Managers;
using Hl7.Fhir.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProxyKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Encodings.Web;
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

            appInner.RunProxy(async context =>
            {
                // **** look for a FHIR server header ****

                if ((context.Request.Headers.ContainsKey(Program._proxyHeaderKey)) &&
                    (context.Request.Headers[Program._proxyHeaderKey].Count > 0))
                {
                    fhirServerUrl = context.Request.Headers[Program._proxyHeaderKey][0];
                }

                // **** grab a formatted copy of this request for proxying ****

                //ForwardContext proxiedContext = context.ForwardTo(fhirServerUrl);

                HttpResponseMessage response = new HttpResponseMessage();

                string preferredResponse = "return=representation";

                // **** check for headers ****

                foreach (KeyValuePair<string, StringValues> kvp in context.Request.Headers)
                {
                    if (kvp.Key.ToLower() == "prefer")
                    {
                        preferredResponse = kvp.Value;
                    }
                }

                StringContent localResponse;

                // **** return appropriate code to the caller ****

                switch (context.Request.Method.ToUpper())
                {
                    case "GET":

                        // **** check for an ID ****

                        string requestUrl = context.Request.Path;
                        if (requestUrl.EndsWith('/'))
                        {
                            requestUrl = requestUrl.Substring(0, requestUrl.Length - 1);
                        }

                        string id = requestUrl.Substring(requestUrl.LastIndexOf('/') + 1);

                        if (id.ToLower() == "subscription")
                        {
                            // *** get list of subscriptions ****

                            response.Content = new StringContent(
                                JsonConvert.SerializeObject(
                                    SubscriptionManager.GetSubscriptionsBundle(),
                                    new JsonSerializerSettings()
                                    {
                                        NullValueHandling = NullValueHandling.Ignore,
                                        ContractResolver = _contractResolver,
                                    })
                                );
                            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
                            response.StatusCode = System.Net.HttpStatusCode.OK;
                        }
                        else if (SubscriptionManager.TryGetSubscription(id, out fhir.Subscription foundSub))
                        {
                            // *** get list of subscriptions ****

                            response.Content = new StringContent(
                                JsonConvert.SerializeObject(
                                    foundSub,
                                    new JsonSerializerSettings()
                                    {
                                        NullValueHandling = NullValueHandling.Ignore,
                                        ContractResolver = _contractResolver,
                                    })
                                );
                            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
                            response.StatusCode = System.Net.HttpStatusCode.OK;
                        }
                        else
                        {
                            response.StatusCode = System.Net.HttpStatusCode.NotFound;
                        }

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

                        SubscriptionManager.HandlePost(
                            requestContent,
                            out fhir.Subscription subscription,
                            out HttpStatusCode statusCode,
                            out string failureContent
                            );


                        // **** check for errors ****

                        if (statusCode != HttpStatusCode.Created)
                        {
                            switch (preferredResponse)
                            {
                                case "return=minimal":
                                    localResponse = new StringContent("", Encoding.UTF8, "text/plain");
                                    break;
                                case "return=OperationOutcome":
                                    OperationOutcome outcome = new OperationOutcome()
                                    {
                                        Id = Guid.NewGuid().ToString(),
                                        Issue = new List<OperationOutcome.IssueComponent>() {
                                            new OperationOutcome.IssueComponent() {
                                                Severity = OperationOutcome.IssueSeverity.Error,
                                                Code = OperationOutcome.IssueType.Unknown,
                                                Diagnostics = failureContent,
                                            }
                                        }
                                    };
                                    Hl7.Fhir.Serialization.FhirJsonSerializer serializer = new Hl7.Fhir.Serialization.FhirJsonSerializer();
                                    localResponse = new StringContent(
                                        serializer.SerializeToString(outcome),
                                        Encoding.UTF8,
                                        "application/fhir+json"
                                        );

                                    break;
                                default:
                                    localResponse = new StringContent(failureContent, Encoding.UTF8, "text/plain");
                                    break;
                            }

                            response.Content = localResponse;
                            response.StatusCode = statusCode;

                            return response;
                        }

                        // **** figure out our link to this resource ****

                        string url = Program.UrlForResourceId("Subscription", subscription.Id);

                        switch (preferredResponse)
                        {
                            case "return=minimal":
                                localResponse = new StringContent("", Encoding.UTF8, "text/plain");
                                break;
                            case "return=OperationOutcome":
                                OperationOutcome outcome = new OperationOutcome()
                                {
                                    Id=Guid.NewGuid().ToString(),
                                    Issue = new List<OperationOutcome.IssueComponent>() {
                                            new OperationOutcome.IssueComponent() {
                                                Severity = OperationOutcome.IssueSeverity.Information,
                                                Code = OperationOutcome.IssueType.Value,
                                            }
                                        }
                                };
                                Hl7.Fhir.Serialization.FhirJsonSerializer serializer = new Hl7.Fhir.Serialization.FhirJsonSerializer();
                                localResponse = new StringContent(
                                    serializer.SerializeToString(outcome),
                                    Encoding.UTF8,
                                    "application/fhir+json"
                                    );

                                break;
                            default:
                                localResponse = new StringContent(
                                    JsonConvert.SerializeObject(
                                        subscription,
                                        new JsonSerializerSettings()
                                        {
                                            NullValueHandling = NullValueHandling.Ignore,
                                            ContractResolver = _contractResolver,
                                        }),
                                    Encoding.UTF8,
                                    "application/fhir+json"
                                    );
                                break;
                        }

                        response.Headers.Add("Location", url);
                        response.Headers.Add("Access-Control-Expose-Headers", "Location,ETag");
                        response.Content = localResponse;
                        response.StatusCode = HttpStatusCode.Created;

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
