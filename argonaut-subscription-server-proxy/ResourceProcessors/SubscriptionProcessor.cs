// <copyright file="SubscriptionProcessor.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir4;
extern alias fhir5;

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
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

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>A subscription processor.</summary>
    public abstract class SubscriptionProcessor
    {
        /// <summary>Process the request.</summary>
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

                // create our response objects
                HttpResponseMessage response = new HttpResponseMessage();
                StringContent localResponse;
                r5s.FhirJsonSerializer serializer = new r5s.FhirJsonSerializer(null);

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

                        if (id.ToLowerInvariant() == "subscription")
                        {
                            // serialize the bundle of subscriptions
                            response.Content = new StringContent(
                                serializer.SerializeToString(
                                    SubscriptionManager.GetSubscriptionsBundle()));
                            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
                            response.StatusCode = System.Net.HttpStatusCode.OK;
                        }
                        else if (SubscriptionManager.TryGetSubscription(id, out r5.Subscription foundSub))
                        {
                            // serialize this subscription
                            response.Content = new StringContent(
                                serializer.SerializeToString(foundSub));
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

                        // grab the message body to look at
                        System.IO.StreamReader requestReader = new System.IO.StreamReader(context.Request.Body);
                        string requestContent = requestReader.ReadToEnd();

                        // check to see if the manager does anything with this text
                        SubscriptionManager.HandlePost(
                            requestContent,
                            out r5.Subscription subscription,
                            out HttpStatusCode statusCode,
                            out string failureContent);

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
                        string url = Program.UrlForResourceId("Subscription", subscription.Id);

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
                                    serializer.SerializeToString(subscription),
                                    Encoding.UTF8,
                                    "application/fhir+json");
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

                        // tell client we didn't understand
                        response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

                        break;
                }

                return response;
            });
        }
    }
}
