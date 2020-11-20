// <copyright file="BasicProcessor.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir4;
extern alias fhir5;

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Linq;
using System.Text;
using argonaut_subscription_server_proxy.Managers;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProxyKit;
using r4 = fhir4.Hl7.Fhir.Model;
using r4s = fhir4.Hl7.Fhir.Serialization;
using r5 = fhir5.Hl7.Fhir.Model;
using r5s = fhir5.Hl7.Fhir.Serialization;
using Hl7.Fhir.Model;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>A basic processor.</summary>
    public abstract class BasicProcessor
    {
        /// <summary>Process the request.</summary>
        /// <param name="appInner">     The application inner.</param>
        /// <param name="fhirServerUrl">URL of the fhir server.</param>
        public static void ProcessRequest(IApplicationBuilder appInner, string fhirServerUrl)
        {
            string serialized;

            // run the proxy for this request
            appInner.RunProxy(async context =>
            {
                // look for a FHIR server header
                if (context.Request.Headers.ContainsKey(Program._proxyHeaderKey) &&
                    (context.Request.Headers[Program._proxyHeaderKey].Count > 0))
                {
                    fhirServerUrl = context.Request.Headers[Program._proxyHeaderKey][0];
                }

                // create some response objects
                HttpResponseMessage response = new HttpResponseMessage();
                StringContent localResponse;
                r5s.FhirJsonSerializer serializer = new r5s.FhirJsonSerializer();

                // default to returning the representation if not specified
                string preferredResponse = "return=representation";

                // check for headers we are interested int
                foreach (KeyValuePair<string, StringValues> kvp in context.Request.Headers)
                {
                    if (kvp.Key.ToLowerInvariant() == "prefer")
                    {
                        preferredResponse = kvp.Value;
                    }
                }

                // act depending on request type
                switch (context.Request.Method.ToUpperInvariant())
                {
                    case "GET":

                        // check for an ID
                        string requestUrl = context.Request.Path;
                        if (requestUrl.EndsWith('/'))
                        {
                            requestUrl = requestUrl.Substring(0, requestUrl.Length - 1);
                        }

                        string id = requestUrl.Substring(requestUrl.LastIndexOf('/') + 1);

                        // check for a subscription
                        if (SubscriptionManager.TryGetBasicSerialized(id, out serialized))
                        {
                            // build our response
                            response.Content = new StringContent(
                                serialized,
                                Encoding.UTF8,
                                "application/fhir+json");
                            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
                            response.StatusCode = System.Net.HttpStatusCode.OK;

                            // done
                            return response;
                        }

                        // check for a topic
                        if (SubscriptionTopicManager.TryGetBasicSerialized(id, out serialized))
                        {
                            // build our response
                            response.Content = new StringContent(
                                serialized,
                                Encoding.UTF8,
                                "application/fhir+json");
                            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
                            response.StatusCode = System.Net.HttpStatusCode.OK;

                            // done
                            return response;
                        }

                        // look for query parameters for a search we are interested in
                        if (context.Request.Query.ContainsKey("code"))
                        {
                            // check for topic
                            if (context.Request.Query["code"] == "R5SubscriptionTopic")
                            {
                                // serialize the bundle of topics
                                response.Content = new StringContent(
                                    serializer.SerializeToString(SubscriptionTopicManager.GetTopicsBundle(true)));
                                response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
                                response.StatusCode = System.Net.HttpStatusCode.OK;

                                return response;
                            }

                            // check for basic
                            if (context.Request.Query["code"] == "R5Subscription")
                            {
                                // serialize the bundle of subscriptions
                                response.Content = new StringContent(
                                    serializer.SerializeToString(SubscriptionManager.GetSubscriptionsBundle(true)));
                                response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
                                response.StatusCode = System.Net.HttpStatusCode.OK;

                                return response;
                            }
                        }

                        break;

                    case "PUT":

                        // don't deal with PUT yet
                        response.StatusCode = System.Net.HttpStatusCode.NotImplemented;
                        return response;

                    case "POST":

                        try
                        {
                            // grab the message body to look at
                            System.IO.StreamReader requestReader = new System.IO.StreamReader(context.Request.Body);
                            string requestContent = requestReader.ReadToEndAsync().Result;

                            r5s.FhirJsonParser parser = new r5s.FhirJsonParser();
                            r5.Basic basic = parser.Parse<r5.Basic>(requestContent);

                            // check to see if this is a something we are interested in
                            if ((basic.Code != null) &&
                                (basic.Code.Coding != null) &&
                                basic.Code.Coding.Any())
                            {
                                // look for codes we want
                                foreach (Coding coding in basic.Code.Coding)
                                {
                                    if (coding.System.Equals("http://hl7.org/fhir/resource-types", StringComparison.Ordinal) &&
                                        coding.Code.Equals("R5SubscriptionTopic", StringComparison.Ordinal))
                                    {
                                        // posting topics is not yet implemented
                                        response.StatusCode = HttpStatusCode.NotImplemented;
                                        return response;
                                    }

                                    if (coding.System.Equals("http://hl7.org/fhir/resource-types", StringComparison.Ordinal) &&
                                        coding.Code.Equals("R5Subscription", StringComparison.Ordinal))
                                    {
                                        // check for having the required resource
                                        if ((basic.Extension == null) ||
                                            (!basic.Extension.Any()) ||
                                            (!basic.Extension[0].Url.Equals("http://hl7.org/fhir/StructureDefinition/json-embedded-resource", StringComparison.Ordinal)))
                                        {
                                            response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                                            return response;
                                        }

                                        // check to see if the manager does anything with this text
                                        SubscriptionManager.HandlePost(
                                            basic.Extension[0].Value.ToString(),
                                            out r5.Subscription subscription,
                                            out HttpStatusCode statusCode,
                                            out string failureContent,
                                            true);

                                        // check for errors
                                        if (statusCode != HttpStatusCode.Created)
                                        {
                                            switch (preferredResponse)
                                            {
                                                case "return=minimal":
                                                    localResponse = new StringContent(string.Empty, Encoding.UTF8, "text/plain");
                                                    break;
                                                case "return=OperationOutcome":
                                                    r5.OperationOutcome outcome = new r5.OperationOutcome()
                                                    {
                                                        Id = Guid.NewGuid().ToString(),
                                                        Issue = new List<r5.OperationOutcome.IssueComponent>()
                                                        {
                                                            new r5.OperationOutcome.IssueComponent()
                                                            {
                                                                Severity = r5.OperationOutcome.IssueSeverity.Error,
                                                                Code = r5.OperationOutcome.IssueType.Unknown,
                                                                Diagnostics = failureContent,
                                                            },
                                                        },
                                                    };
                                                    localResponse = new StringContent(
                                                        serializer.SerializeToString(outcome),
                                                        Encoding.UTF8,
                                                        "application/fhir+json");

                                                    break;
                                                default:
                                                    localResponse = new StringContent(failureContent, Encoding.UTF8, "text/plain");
                                                    break;
                                            }

                                            response.Content = localResponse;
                                            response.StatusCode = statusCode;

                                            return response;
                                        }

                                        // figure out our link to this resource
                                        string url = Program.UrlForResourceId("Basic", subscription.Id);

                                        switch (preferredResponse)
                                        {
                                            case "return=minimal":
                                                localResponse = new StringContent(string.Empty, Encoding.UTF8, "text/plain");
                                                break;
                                            case "return=OperationOutcome":
                                                r5.OperationOutcome outcome = new r5.OperationOutcome()
                                                {
                                                    Id = Guid.NewGuid().ToString(),
                                                    Issue = new List<r5.OperationOutcome.IssueComponent>()
                                                    {
                                                        new r5.OperationOutcome.IssueComponent()
                                                        {
                                                            Severity = r5.OperationOutcome.IssueSeverity.Information,
                                                            Code = r5.OperationOutcome.IssueType.Value,
                                                        },
                                                    },
                                                };
                                                localResponse = new StringContent(
                                                    serializer.SerializeToString(outcome),
                                                    Encoding.UTF8,
                                                    "application/fhir+json");

                                                break;
                                            default:
                                                localResponse = new StringContent(
                                                    serializer.SerializeToString(SubscriptionManager.WrapInBasic(subscription)),
                                                    Encoding.UTF8,
                                                    "application/fhir+json");
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
                            // check to see if this is a subscription
                            if (SubscriptionManager.HandleDelete(context.Request))
                            {
                                // deleted
                                response.StatusCode = System.Net.HttpStatusCode.NoContent;
                                return response;
                            }

                            // fall through to proxy
                        }
                        catch (Exception)
                        {
                        }

                        break;
                }

                // if we're still here, proxy this call
                ForwardContext proxiedContext = context.ForwardTo(fhirServerUrl);

                // send to server and await response
                return await proxiedContext.Send().ConfigureAwait(false);
            });
        }
    }
}
