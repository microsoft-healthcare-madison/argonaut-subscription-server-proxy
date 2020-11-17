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
using System.Threading.Tasks;
using argonaut_subscription_server_proxy.Backport;
using argonaut_subscription_server_proxy.Managers;
using Hl7.Fhir.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
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
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result that yields a HttpResponseMessage.</returns>
        internal static async Task<HttpResponseMessage> Process(HttpContext context)
        {
            bool isR4 = ProcessorUtils.IsR4(context.Request);

            // create our response objects
            HttpResponseMessage response = new HttpResponseMessage();

            if (ProcessorUtils.IsOperation(context.Request, out string operationName, out string prevComponent))
            {
                ProcessOperation(ref context, ref response, isR4, operationName, prevComponent);
                return response;
            }

            // get copies of data when we care
            switch (context.Request.Method.ToUpperInvariant())
            {
                case "GET":
                    if (isR4)
                    {
                        ProcessGetR4(ref context, ref response);
                    }
                    else
                    {
                        ProcessGetR5(ref context, ref response);
                    }

                    break;

                case "PUT":

                    // *** not implemented ****
                    response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

                    break;

                case "POST":
                    if (isR4)
                    {
                        ProcessPostR4(ref context, ref response);
                    }
                    else
                    {
                        ProcessPostR5(ref context, ref response);
                    }

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

            // return the originator response, plus any modifications we've done
            return response;
        }

        /// <summary>Process the operation.</summary>
        /// <param name="context">          [in,out] The context.</param>
        /// <param name="response">         [in,out] The response.</param>
        /// <param name="isR4">             True if is R4, false if not.</param>
        /// <param name="operationName">    Name of the operation.</param>
        /// <param name="previousComponent">The previous component.</param>
        internal static void ProcessOperation(
            ref HttpContext context,
            ref HttpResponseMessage response,
            bool isR4,
            string operationName,
            string previousComponent)
        {
            if (operationName == "$status")
            {
                // act on the method
                switch (context.Request.Method.ToUpperInvariant())
                {
                    case "POST":
                    case "GET":
                        if (isR4)
                        {
                            ProcessOperationStatusR4(ref context, ref response, previousComponent);
                        }
                        else
                        {
                            ProcessOperationStatusR5(ref context, ref response, previousComponent);
                        }

                        break;

                    case "PUT":
                    case "DELETE":
                    default:
                        // tell client we didn't understand
                        response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

                        break;
                }

                return;
            }

            if (operationName == "$topic-list")
            {
                // act on the method
                switch (context.Request.Method.ToUpperInvariant())
                {
                    case "POST":
                    case "GET":
                        if (isR4)
                        {
                            ProcessOperationTopicListR4(ref response);
                        }
                        else
                        {
                            // this is not implemented in R5
                            response.StatusCode = System.Net.HttpStatusCode.NotImplemented;
                        }

                        break;

                    case "PUT":
                    case "DELETE":
                    default:
                        // tell client we didn't understand
                        response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

                        break;
                }

                return;
            }
        }

        /// <summary>Process the operation topic list R4.</summary>
        /// <param name="response">[in,out] The response.</param>
        internal static void ProcessOperationTopicListR4(
            ref HttpResponseMessage response)
        {
            r4.Parameters topics = new r4.Parameters();

            foreach (r5.SubscriptionTopic topic in SubscriptionTopicManager.GetTopicList())
            {
                topics.Add("subscription-topic-canonical", new Canonical(topic.Url));
            }

            ProcessorUtils.SerializeR4(ref response, topics);
        }

        /// <summary>Process the operation status R4.</summary>
        /// <param name="context">          [in,out] The context.</param>
        /// <param name="response">         [in,out] The response.</param>
        /// <param name="previousComponent">The previous component.</param>
        internal static void ProcessOperationStatusR4(
            ref HttpContext context,
            ref HttpResponseMessage response,
            string previousComponent)
        {
            List<string> ids = new List<string>();

            if (previousComponent != "Subscription")
            {
                ids.Add(previousComponent);
            }
            else
            {
                foreach (KeyValuePair<string, StringValues> query in context.Request.Query)
                {
                    if (query.Key == "ids")
                    {
                        ids.AddRange(query.Value);
                    }
                }
            }

            // create a bundle for this message message
            r4.Bundle bundle = new r4.Bundle()
            {
                Type = r4.Bundle.BundleType.Searchset,
                Timestamp = new DateTimeOffset(DateTime.Now),
                Meta = new Meta(),
                Entry = new List<r4.Bundle.EntryComponent>(),
            };

            foreach (string id in ids)
            {
                if (SubscriptionManager.TryGetSubscriptionStatusR4(id, out r4.Parameters status))
                {
                    bundle.Entry.Add(new r4.Bundle.EntryComponent()
                    {
                        FullUrl = Program.UrlForResourceId(status.TypeName, status.Id),
                        Resource = status,
                        Search = new r4.Bundle.SearchComponent()
                        {
                            Mode = r4.Bundle.SearchEntryMode.Match,
                        },
                    });
                }
            }

            ProcessorUtils.SerializeR4(ref response, bundle);
        }

        /// <summary>Process the operation status R5.</summary>
        /// <param name="context">          [in,out] The context.</param>
        /// <param name="response">         [in,out] The response.</param>
        /// <param name="previousComponent">The previous component.</param>
        internal static void ProcessOperationStatusR5(
            ref HttpContext context,
            ref HttpResponseMessage response,
            string previousComponent)
        {
            List<string> ids = new List<string>();

            if (previousComponent != "Subscription")
            {
                ids.Add(previousComponent);
            }
            else
            {
                foreach (KeyValuePair<string, StringValues> query in context.Request.Query)
                {
                    if (query.Key == "ids")
                    {
                        ids.AddRange(query.Value);
                    }
                }
            }

            // create a bundle for this message message
            r5.Bundle bundle = new r5.Bundle()
            {
                Type = r5.Bundle.BundleType.Searchset,
                Timestamp = new DateTimeOffset(DateTime.Now),
                Meta = new Meta(),
                Entry = new List<r5.Bundle.EntryComponent>(),
            };

            foreach (string id in ids)
            {
                if (SubscriptionManager.TryGetSubscriptionStatus(id, out r5.SubscriptionStatus status))
                {
                    bundle.Entry.Add(new r5.Bundle.EntryComponent()
                    {
                        FullUrl = Program.UrlForResourceId(status.TypeName, status.Id),
                        Resource = status,
                        Search = new r5.Bundle.SearchComponent()
                        {
                            Mode = r5.Bundle.SearchEntryMode.Match,
                        },
                    });
                }
            }

            ProcessorUtils.SerializeR5(ref response, bundle);
        }

        /// <summary>Process an HTTP POST for FHIR R4</summary>
        /// <param name="context"> [in,out] The context.</param>
        /// <param name="response">[in,out] The response.</param>
        internal static void ProcessPostR4(ref HttpContext context, ref HttpResponseMessage response)
        {
            r4s.FhirJsonSerializer serializer = new r4s.FhirJsonSerializer(null);

            StringContent localResponse;

            // default to returning the representation if not specified
            string preferredResponse = "return=representation";

            // check for headers we are interested in
            foreach (KeyValuePair<string, StringValues> kvp in context.Request.Headers)
            {
                if (kvp.Key.ToLowerInvariant() == "prefer")
                {
                    preferredResponse = kvp.Value;
                }
            }

            // grab the message body to look at
            System.IO.StreamReader requestReader = new System.IO.StreamReader(context.Request.Body);
            string requestContent = requestReader.ReadToEnd();

            // check to see if the manager does anything with this text
            SubscriptionManager.HandlePost(
                requestContent,
                out r5.Subscription subscription,
                out HttpStatusCode statusCode,
                out string failureContent,
                false,
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
                        r4.OperationOutcome outcome = new r4.OperationOutcome()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Issue = new List<r4.OperationOutcome.IssueComponent>()
                            {
                                new r4.OperationOutcome.IssueComponent()
                                {
                                    Severity = r4.OperationOutcome.IssueSeverity.Error,
                                    Code = r4.OperationOutcome.IssueType.Unknown,
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

                return;
            }

            // figure out our link to this resource
            string url = Program.UrlForResourceId("Subscription", subscription.Id);

            switch (preferredResponse)
            {
                case "return=minimal":
                    localResponse = new StringContent(string.Empty, Encoding.UTF8, "text/plain");
                    break;
                case "return=OperationOutcome":
                    r4.OperationOutcome outcome = new r4.OperationOutcome()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Issue = new List<r4.OperationOutcome.IssueComponent>()
                        {
                            new r4.OperationOutcome.IssueComponent()
                            {
                                Severity = r4.OperationOutcome.IssueSeverity.Information,
                                Code = r4.OperationOutcome.IssueType.Value,
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
                        serializer.SerializeToString(SubscriptionConverter.ToR4(subscription)),
                        Encoding.UTF8,
                        "application/fhir+json");
                    break;
            }

            response.Headers.Add("Location", url);
            response.Headers.Add("Access-Control-Expose-Headers", "Location,ETag");
            response.Content = localResponse;
            response.StatusCode = HttpStatusCode.Created;
        }

        /// <summary>Process an HTTP POST for FHIR R5.</summary>
        /// <param name="context"> [in,out] The context.</param>
        /// <param name="response">[in,out] The response.</param>
        internal static void ProcessPostR5(ref HttpContext context, ref HttpResponseMessage response)
        {
            r5s.FhirJsonSerializer serializer = new r5s.FhirJsonSerializer(null);

            StringContent localResponse;

            // default to returning the representation if not specified
            string preferredResponse = "return=representation";

            // check for headers we are interested in
            foreach (KeyValuePair<string, StringValues> kvp in context.Request.Headers)
            {
                if (kvp.Key.ToLowerInvariant() == "prefer")
                {
                    preferredResponse = kvp.Value;
                }
            }

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

                return;
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
        }

        /// <summary>Process an HTTP GET in FHIR R4</summary>
        /// <param name="context"> [in,out] The context.</param>
        /// <param name="response">[in,out] The response.</param>
        internal static void ProcessGetR4(ref HttpContext context, ref HttpResponseMessage response)
        {
            // check for an ID
            string requestUrl = context.Request.Path;
            if (requestUrl.EndsWith('/'))
            {
                requestUrl = requestUrl.Substring(0, requestUrl.Length - 1);
            }

            string id = requestUrl.Substring(requestUrl.LastIndexOf('/') + 1);

            if (id.ToLowerInvariant() == "subscription")
            {
                ProcessorUtils.SerializeR4(ref response, SubscriptionManager.GetSubscriptionsBundleR4());
            }
            else if (SubscriptionManager.TryGetSubscriptionR4(id, out r4.Subscription foundSub))
            {
                ProcessorUtils.SerializeR4(ref response, foundSub);
            }
            else
            {
                response.StatusCode = HttpStatusCode.NotFound;
            }
        }

        /// <summary>Process an HTTP GET in FHIR R5</summary>
        /// <param name="context"> [in,out] The context.</param>
        /// <param name="response">[in,out] The response.</param>
        internal static void ProcessGetR5(ref HttpContext context, ref HttpResponseMessage response)
        {
            // check for an ID
            string requestUrl = context.Request.Path;
            if (requestUrl.EndsWith('/'))
            {
                requestUrl = requestUrl.Substring(0, requestUrl.Length - 1);
            }

            string id = requestUrl.Substring(requestUrl.LastIndexOf('/') + 1);

            if (id.ToLowerInvariant() == "subscription")
            {
                ProcessorUtils.SerializeR5(ref response, SubscriptionManager.GetSubscriptionsBundle());
            }
            else if (SubscriptionManager.TryGetSubscription(id, out r5.Subscription foundSub))
            {
                ProcessorUtils.SerializeR5(ref response, foundSub);
            }
            else
            {
                response.StatusCode = HttpStatusCode.NotFound;
            }
        }


    }
}
