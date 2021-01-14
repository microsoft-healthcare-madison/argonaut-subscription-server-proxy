// <copyright file="SubscriptionProcessorR5.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir5;

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using argonaut_subscription_server_proxy.Backport;
using argonaut_subscription_server_proxy.Managers;
using argonaut_subscription_server_proxy.Models;
using fhir5.Hl7.Fhir.Model;
using fhir5.Hl7.Fhir.Serialization;
using Hl7.Fhir.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using ProxyKit;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>A subscription processor.</summary>
    public abstract class SubscriptionProcessorR5
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
                        // *** failed ****
                        response.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                    }

                    break;

                default:
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
                        string requestContent = reader.ReadToEnd();

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
                catch (Exception)
                {
                    response.StatusCode = HttpStatusCode.BadRequest;
                    return;
                }
            }

            foreach (string id in ids)
            {
                if (!SubscriptionManagerR5.Exists(id))
                {
                    response.StatusCode = HttpStatusCode.BadRequest;
                    response.Content = new StringContent($"Invalid subscription id: {id}");
                    return;
                }
            }

            SubscriptionWsBindingToken token = SubscriptionWsBindingToken.GetTokenR5(ids);

            WebsocketManager.RegisterToken(token);

            Parameters parameters = new Parameters();

            parameters.Add("token", new FhirString(token.Token.ToString()));
            parameters.Add("expiration", new FhirDateTime(new DateTimeOffset(token.ExpiresAt)));
            parameters.Add("subscriptions", new FhirString(string.Join(',', ids)));

            ProcessorUtils.SerializeR5(ref response, parameters);
        }

        /// <summary>Process the operation status R5.</summary>
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

            // create a bundle for this message message
            Bundle bundle = new Bundle()
            {
                Type = Bundle.BundleType.Searchset,
                Timestamp = new DateTimeOffset(DateTime.Now),
                Meta = new Meta(),
                Entry = new List<Bundle.EntryComponent>(),
            };

            foreach (string id in ids)
            {
                if (SubscriptionManagerR5.TryGetSubscriptionStatus(id, out SubscriptionStatus status, 0, true))
                {
                    bundle.Entry.Add(new Bundle.EntryComponent()
                    {
                        FullUrl = Program.UrlForR5ResourceId(status.TypeName, status.Id),
                        Resource = status,
                        Search = new Bundle.SearchComponent()
                        {
                            Mode = Bundle.SearchEntryMode.Match,
                        },
                    });
                }
            }

            ProcessorUtils.SerializeR5(ref response, bundle);
        }

        /// <summary>Process an HTTP POST for FHIR R5.</summary>
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

            using (StreamReader requestReader = new System.IO.StreamReader(context.Request.Body))
            {
                // grab the message body to look at
                requestContent = requestReader.ReadToEndAsync().Result;
            }

            // check to see if the manager does anything with this text
            SubscriptionManagerR5.HandlePost(
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
            string url = Program.UrlForR5ResourceId("Subscription", subscription.Id);

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

        /// <summary>Process an HTTP GET in FHIR R5</summary>
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
                ProcessorUtils.SerializeR5(ref response, SubscriptionManagerR5.GetSubscriptionsBundle());
            }
            else if (SubscriptionManagerR5.TryGetSubscription(id, out Subscription foundSub))
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
