using argonaut_subscription_server_proxy.Managers;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProxyKit;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    public class BasicProcessor
    {
        private static CamelCasePropertyNamesContractResolver _contractResolver = new CamelCasePropertyNamesContractResolver();

        private static FhirJsonSerializer _firelySerializer = new FhirJsonSerializer();


        public static void ProcessRequest(IApplicationBuilder appInner, string fhirServerUrl)
        {
            string serialized;

            // **** run the proxy for this request ****

            appInner.RunProxy(async context =>
            {
                // **** look for a FHIR server header ****

                if ((context.Request.Headers.ContainsKey(Program._proxyHeaderKey)) &&
                    (context.Request.Headers[Program._proxyHeaderKey].Count > 0))
                {
                    fhirServerUrl = context.Request.Headers[Program._proxyHeaderKey][0];
                }

                // **** create some response objects ****

                HttpResponseMessage response = new HttpResponseMessage();
                StringContent localResponse;

                // **** default to returning the representation if not specified ****

                string preferredResponse = "return=representation";

                // **** check for headers we are interested int ****

                foreach (KeyValuePair<string, StringValues> kvp in context.Request.Headers)
                {
                    if (kvp.Key.ToLower() == "prefer")
                    {
                        preferredResponse = kvp.Value;
                    }
                }

                // **** act depending on request type ****

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

                        // **** check for a subscription ****

                        if (SubscriptionManager.TryGetBasicSerialized(id, out serialized))
                        {
                            // **** build our response ****

                            response.Content = new StringContent(
                                serialized,
                                Encoding.UTF8,
                                "application/fhir+json"
                                );
                            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
                            response.StatusCode = System.Net.HttpStatusCode.OK;

                            // **** done ****

                            return response;
                        }

                        // **** check for a topic ****

                        if (TopicManager.TryGetBasicSerialized(id, out serialized))
                        {
                            // **** build our response ****

                            response.Content = new StringContent(
                                serialized,
                                Encoding.UTF8,
                                "application/fhir+json"
                                );
                            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
                            response.StatusCode = System.Net.HttpStatusCode.OK;

                            // **** done ****

                            return response;
                        }

                        // **** look for query parameters for a search we are interested in ****

                        if (context.Request.Query.ContainsKey("code"))
                        {
                            // **** check for topic ****

                            if (context.Request.Query["code"] == "R5Topic")
                            {
                                // **** serialize the bundle of topics ****

                                response.Content = new StringContent(
                                    JsonConvert.SerializeObject(
                                        TopicManager.GetTopicsBundle(true),
                                        new JsonSerializerSettings()
                                        {
                                            NullValueHandling = NullValueHandling.Ignore,
                                            ContractResolver = _contractResolver,
                                        })
                                    );
                                response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
                                response.StatusCode = System.Net.HttpStatusCode.OK;

                                return response;
                            }

                            // **** check for basic ****

                            if (context.Request.Query["code"] == "R5Subscription")
                            {
                                // **** serialize the bundle of subscriptions ****

                                response.Content = new StringContent(
                                    JsonConvert.SerializeObject(
                                        SubscriptionManager.GetSubscriptionsBundle(true),
                                        new JsonSerializerSettings()
                                        {
                                            NullValueHandling = NullValueHandling.Ignore,
                                            ContractResolver = _contractResolver,
                                        })
                                    );
                                response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
                                response.StatusCode = System.Net.HttpStatusCode.OK;

                                return response;
                            }
                        }

                        break;

                    case "PUT":

                        // **** don't deal with PUT yet ****

                        response.StatusCode = System.Net.HttpStatusCode.NotImplemented;
                        return response;

                        //break;

                    case "POST":

                        try
                        {
                            // **** grab the message body to look at ****

                            System.IO.StreamReader requestReader = new System.IO.StreamReader(context.Request.Body);
                            string requestContent = requestReader.ReadToEnd();

                            // **** parse the basic resource ****

                            fhir.Basic basic = JsonConvert.DeserializeObject<fhir.Basic>(requestContent);

                            // **** check to see if this is a something we are interested in ****

                            if ((basic.Code != null) &&
                                (basic.Code.Coding != null) &&
                                (basic.Code.Coding.Length > 0))
                            {
                                // **** look for codes we want ****

                                foreach (fhir.Coding coding in basic.Code.Coding)
                                {
                                    if ((coding.System.Equals("http://hl7.org/fhir/resource-types", StringComparison.Ordinal)) &&
                                        (coding.Code.Equals("R5Topic", StringComparison.Ordinal)))
                                    {
                                        // **** posting topics is not yet implemented ****

                                        response.StatusCode = HttpStatusCode.NotImplemented;
                                        return response;
                                    }

                                    if ((coding.System.Equals("http://hl7.org/fhir/resource-types", StringComparison.Ordinal)) &&
                                        (coding.Code.Equals("R5Subscription", StringComparison.Ordinal)))
                                    {
                                        // **** check for having the required resource ****

                                        if ((basic.Extension == null) || 
                                            (basic.Extension.Length == 0) ||
                                            (!basic.Extension[0].Url.Equals("http://hl7.org/fhir/StructureDefinition/json-embedded-resource", StringComparison.Ordinal)))
                                        {
                                            response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                                            return response;
                                        }

                                        // **** check to see if the manager does anything with this text ****

                                        SubscriptionManager.HandlePost(
                                            basic.Extension[0].ValueString,
                                            out fhir.Subscription subscription,
                                            out HttpStatusCode statusCode,
                                            out string failureContent,
                                            true
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
                                                        Issue = new List<OperationOutcome.IssueComponent>()
                                                        {
                                                            new OperationOutcome.IssueComponent()
                                                            {
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

                                        string url = Program.UrlForResourceId("Basic", subscription.Id);

                                        switch (preferredResponse)
                                        {
                                            case "return=minimal":
                                                localResponse = new StringContent("", Encoding.UTF8, "text/plain");
                                                break;
                                            case "return=OperationOutcome":
                                                OperationOutcome outcome = new OperationOutcome()
                                                {
                                                    Id = Guid.NewGuid().ToString(),
                                                    Issue = new List<OperationOutcome.IssueComponent>()
                                                    {
                                                        new OperationOutcome.IssueComponent()
                                                        {
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
                                                        SubscriptionManager.WrapInBasic(subscription),
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

                                        return response;
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {

                        }


                        break;

                    case "DELETE":


                        try
                        {
                            // **** check to see if this is a subscription ****

                            if (SubscriptionManager.HandleDelete(context.Request))
                            {
                                // **** deleted ****

                                response.StatusCode = System.Net.HttpStatusCode.NoContent;
                                return response;
                            }

                            // **** fall through to proxy ****
                        }
                        catch (Exception)
                        {

                        }

                        break;
                }

                // **** if we're still here, proxy this call ****

                ForwardContext proxiedContext = context.ForwardTo(fhirServerUrl);

                // **** send to server and await response ****

                return await proxiedContext.Send();
            });
        }

    }
}
