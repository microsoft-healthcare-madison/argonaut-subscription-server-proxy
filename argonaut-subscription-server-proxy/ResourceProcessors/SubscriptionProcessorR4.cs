// <copyright file="SubscriptionProcessorR4.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir4;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using argonaut_subscription_server_proxy.Backport;
using argonaut_subscription_server_proxy.Managers;
using argonaut_subscription_server_proxy.Models;
using fhir4.Hl7.Fhir.Model;
using fhir4.Hl7.Fhir.Serialization;
using Hl7.Fhir.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProxyKit;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>A subscription processor.</summary>
    public abstract class SubscriptionProcessorR4
    {
        /// <summary>The FHIR serializer.</summary>
        private static FhirJsonSerializer _fhirSerializer = new FhirJsonSerializer(new Hl7.Fhir.Serialization.SerializerSettings()
        {
            AppendNewLine = false,
            Pretty = false,
        });

        /// <summary>The FHIR parser.</summary>
        private static FhirJsonParser _fhirParser = new FhirJsonParser(new Hl7.Fhir.Serialization.ParserSettings()
        {
            AcceptUnknownMembers = true,
            AllowUnrecognizedEnums = true,
            PermissiveParsing = true,
        });

        /// <summary>Process the request.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result that yields a HttpResponseMessage.</returns>
        internal static async Task<HttpResponseMessage> Process(HttpContext context)
        {
            // create our response objects
            HttpResponseMessage response = new HttpResponseMessage();

            if (ProcessorUtils.IsOperation(context.Request, out string operationName, out string prevComponent))
            {
                ProcessOperation(ref context, ref response, operationName, prevComponent);
                return response;
            }

            // get copies of data when we care
            switch (context.Request.Method.ToUpperInvariant())
            {
                case "GET":
                    ProcessGet(ref context, ref response);

                    break;

                case "PUT":
                    response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

                    break;

                case "POST":
                    ProcessPost(ref context, ref response);

                    break;

                case "DELETE":
                    // ask the subscription manager to deal with this
                    if (SubscriptionManagerR5.HandleDelete(context.Request))
                    {
                        response.StatusCode = System.Net.HttpStatusCode.NoContent;
                    }
                    else
                    {
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
        /// <param name="operationName">    Name of the operation.</param>
        /// <param name="previousComponent">The previous component.</param>
        internal static void ProcessOperation(
            ref HttpContext context,
            ref HttpResponseMessage response,
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
                        ProcessOperationStatus(ref context, ref response, previousComponent);

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
                        ProcessOperationTopicList(ref response);

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

            if (operationName == "$get-ws-binding-token")
            {
                // act on the method
                switch (context.Request.Method.ToUpperInvariant())
                {
                    case "POST":
                    case "GET":
                        ProcessOperationGetWsBindingToken(ref context, ref response, previousComponent);

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

        /// <summary>Process the operation get ws binding token described by response.</summary>
        /// <param name="context">          [in,out] The context.</param>
        /// <param name="response">         [in,out] The response.</param>
        /// <param name="previousComponent">The previous component.</param>
        internal static void ProcessOperationGetWsBindingToken(
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
                try
                {
                    using (TextReader reader = new StreamReader(context.Request.Body))
                    {
                        string requestContent = reader.ReadToEndAsync().Result;

                        Parameters opParams = _fhirParser.Parse<Parameters>(requestContent);

                        foreach (Parameters.ParameterComponent param in opParams.Parameter)
                        {
                            if (param.Name == "ids")
                            {
                                ids.Add((param.Value as Id).ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    response.StatusCode = HttpStatusCode.BadRequest;
                    response.Content = new StringContent("Caught exception: " + ex.Message);
                    return;
                }
            }

            foreach (string id in ids)
            {
                if (!SubscriptionManagerR4.Exists(id))
                {
                    response.StatusCode = HttpStatusCode.BadRequest;
                    response.Content = new StringContent($"Invalid subscription id: {id}");
                    return;
                }
            }

            SubscriptionWsBindingToken token = SubscriptionWsBindingToken.GetTokenR4(ids);

            WebsocketManager.RegisterToken(token);

            Parameters parameters = new Parameters();

            parameters.Add("token", new FhirString(token.Token.ToString()));
            parameters.Add("expiration", new FhirDateTime(new DateTimeOffset(token.ExpiresAt)));
            parameters.Add("subscriptions", new FhirString(string.Join(',', ids)));

            ProcessorUtils.SerializeR4(ref response, parameters);
        }

        /// <summary>Process the operation topic list R4.</summary>
        /// <param name="response">[in,out] The response.</param>
        internal static void ProcessOperationTopicList(
            ref HttpResponseMessage response)
        {
            Parameters topics = new Parameters();

            foreach (string topicUrl in SubscriptionTopicManagerR5.GetTopicUrlList())
            {
                topics.Add("subscription-topic-canonical", new Canonical(topicUrl));
            }

            ProcessorUtils.SerializeR4(ref response, topics);
        }

        /// <summary>Process the operation status R4.</summary>
        /// <param name="context">          [in,out] The context.</param>
        /// <param name="response">         [in,out] The response.</param>
        /// <param name="previousComponent">The previous component.</param>
        internal static void ProcessOperationStatus(
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

            // create a bundle for this response
            fhirCsR4.Models.Bundle bundle = new fhirCsR4.Models.Bundle()
            {
                Type = fhirCsR4.Models.BundleTypeCodes.SEARCHSET,
                Timestamp = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK"),
                Meta = new fhirCsR4.Models.Meta(),
                Entry = new List<fhirCsR4.Models.BundleEntry>(),
            };

            foreach (string id in ids)
            {
                if (SubscriptionManagerR4.TryGetSubscriptionStatus(id, out fhirCsR4.Models.SubscriptionStatus status, 0, true))
                {
                    bundle.Entry.Add(new fhirCsR4.Models.BundleEntry()
                    {
                        FullUrl = Program.UrlForR4ResourceId("Subscription", id) + "/$status",
                        Resource = status,
                        Search = new fhirCsR4.Models.BundleEntrySearch()
                        {
                            Mode = fhirCsR4.Models.BundleEntrySearchModeCodes.MATCH,
                        },
                    });
                }
            }

            ProcessorUtils.SerializeR4(ref response, bundle);
        }

        /// <summary>Process an HTTP POST for FHIR R4</summary>
        /// <param name="context"> [in,out] The context.</param>
        /// <param name="response">[in,out] The response.</param>
        internal static void ProcessPost(ref HttpContext context, ref HttpResponseMessage response)
        {
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

            string requestContent;

            // grab the message body to look at
            using (System.IO.StreamReader requestReader = new System.IO.StreamReader(context.Request.Body))
            {
                requestContent = requestReader.ReadToEndAsync().Result;
            }

            // check to see if the manager does anything with this text
            SubscriptionManagerR4.HandlePost(
                requestContent,
                out Subscription subscription,
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
                                },
                            },
                        };
                        localResponse = new StringContent(
                            _fhirSerializer.SerializeToString(outcome),
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
            string url = Program.UrlForR4ResourceId("Subscription", subscription.Id);

            switch (preferredResponse)
            {
                case "return=minimal":
                    localResponse = new StringContent(string.Empty, Encoding.UTF8, "text/plain");
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
                            },
                        },
                    };
                    localResponse = new StringContent(
                        _fhirSerializer.SerializeToString(outcome),
                        Encoding.UTF8,
                        "application/fhir+json");

                    break;
                default:
                    localResponse = new StringContent(
                        _fhirSerializer.SerializeToString(subscription),
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
        internal static void ProcessGet(ref HttpContext context, ref HttpResponseMessage response)
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
                ProcessorUtils.SerializeR4(ref response, SubscriptionManagerR4.GetSubscriptionsBundle());
            }
            else if (SubscriptionManagerR4.TryGetSubscription(id, out Subscription foundSub))
            {
                ProcessorUtils.SerializeR4(ref response, foundSub);
            }
            else
            {
                response.StatusCode = HttpStatusCode.NotFound;
            }
        }
    }
}
