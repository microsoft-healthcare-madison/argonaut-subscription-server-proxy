// <copyright file="SubscriptionProcessorR4.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir4;

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using argonaut_subscription_server_proxy.Managers;
using argonaut_subscription_server_proxy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>A subscription processor.</summary>
    public abstract class SubscriptionProcessorR4
    {
        /// <summary>Process the request.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result that yields a HttpResponseMessage.</returns>
        internal static async Task Process(HttpContext context)
        {
            if (ProcessorUtils.IsOperation(context.Request, out string operationName, out string prevComponent))
            {
                await ProcessOperationAndRespond(context, operationName, prevComponent);
                return;
            }

            // get copies of data when we care
            switch (context.Request.Method.ToUpperInvariant())
            {
                case "GET":
                    await ProcessGetAndRespond(context);
                    break;

                case "POST":
                    await ProcessPostAndRespond(context);
                    break;

                case "DELETE":
                    // ask the subscription manager to deal with this
                    if (SubscriptionManagerR4.HandleDelete(context.Request))
                    {
                        context.Response.StatusCode = (int)System.Net.HttpStatusCode.NoContent;
                    }
                    else
                    {
                        context.Response.StatusCode = (int)System.Net.HttpStatusCode.NotFound;
                    }

                    _ = context.Response.CompleteAsync();
                    break;

                case "PUT":
                default:
                    // tell client this isn't supported
                    context.Response.StatusCode = (int)System.Net.HttpStatusCode.NotImplemented;
                    _ = context.Response.CompleteAsync();
                    break;
            }
        }

        /// <summary>Process the operation.</summary>
        /// <param name="context">          The context.</param>
        /// <param name="operationName">    Name of the operation.</param>
        /// <param name="previousComponent">The previous component.</param>
        /// <returns>An asynchronous result.</returns>
        internal static async Task ProcessOperationAndRespond(
            HttpContext context,
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
                        await ProcessOperationStatus(context, previousComponent);
                        break;

                    case "PUT":
                    case "DELETE":
                    default:
                        // tell client this isn't supported
                        context.Response.StatusCode = (int)System.Net.HttpStatusCode.NotImplemented;
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
                        await ProcessOperationGetWsBindingToken(context, previousComponent);

                        break;

                    case "PUT":
                    case "DELETE":
                    default:
                        // tell client this isn't supported
                        context.Response.StatusCode = (int)System.Net.HttpStatusCode.NotImplemented;
                        break;
                }

                return;
            }

            if (operationName == "$events")
            {
                // act on the method
                switch (context.Request.Method.ToUpperInvariant())
                {
                    case "POST":
                    case "GET":
                        await ProcessOperationEvents(context, previousComponent);

                        break;

                    case "PUT":
                    case "DELETE":
                    default:
                        // tell client this isn't supported
                        context.Response.StatusCode = (int)System.Net.HttpStatusCode.NotImplemented;
                        break;
                }

                return;
            }

            // tell client this isn't supported
            context.Response.StatusCode = (int)System.Net.HttpStatusCode.NotImplemented;
        }

        /// <summary>Process the operation get ws binding token described by response.</summary>
        /// <param name="context">          The context.</param>
        /// <param name="previousComponent">The previous component.</param>
        /// <returns>An asynchronous result.</returns>
        internal static async Task ProcessOperationGetWsBindingToken(
            HttpContext context,
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

                        fhirCsR4.Models.Parameters opParams = JsonSerializer.Deserialize<fhirCsR4.Models.Parameters>(requestContent);

                        foreach (fhirCsR4.Models.ParametersParameter param in opParams.Parameter)
                        {
                            if (param.Name == "ids")
                            {
                                ids.Add(param.ValueString);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    context.Response.ContentType = "text/plain";
                    await context.Response.WriteAsync("Caught exception: " + ex.Message);
                    return;
                }
            }

            foreach (string id in ids)
            {
                if (!SubscriptionManagerR4.Exists(id))
                {
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    context.Response.ContentType = "text/plain";
                    await context.Response.WriteAsync($"Invalid subscription id: {id}");
                    return;
                }
            }

            SubscriptionWsBindingToken token = SubscriptionWsBindingToken.GetTokenR4(ids);

            WebsocketManager.RegisterToken(token);

            fhirCsR4.Models.Parameters parameters = new fhirCsR4.Models.Parameters();

            parameters.Parameter = new List<fhirCsR4.Models.ParametersParameter>()
            {
                new fhirCsR4.Models.ParametersParameter()
                {
                    Name = "token",
                    ValueString = token.Token.ToString(),
                },
                new fhirCsR4.Models.ParametersParameter()
                {
                    Name = "expiration",
                    ValueDateTime = token.ExpiresAt.ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK"),
                },
                new fhirCsR4.Models.ParametersParameter()
                {
                    Name = "subscriptions",
                    ValueString = string.Join(',', ids),
                },
            };

            await ProcessorUtils.SerializeR4(context, parameters);
        }

        /// <summary>Process the operation status R4.</summary>
        /// <param name="context">          The context.</param>
        /// <param name="previousComponent">The previous component.</param>
        /// <returns>An asynchronous result.</returns>
        internal static async Task ProcessOperationStatus(
            HttpContext context,
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

            // serialize and write back to the caller
            await ProcessorUtils.SerializeR4(context, bundle);
        }

        /// <summary>Process the operation events R4.</summary>
        /// <param name="context">          The context.</param>
        /// <param name="previousComponent">The previous component.</param>
        /// <returns>An asynchronous result.</returns>
        internal static async Task ProcessOperationEvents(
            HttpContext context,
            string previousComponent)
        {
            string subscriptionId;

            if (previousComponent != "Subscription")
            {
                subscriptionId = previousComponent;
            }
            else
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return;
            }

            long eventLow = -1;
            long eventHigh = -1;
            string contentHint = string.Empty;

            foreach (KeyValuePair<string, StringValues> query in context.Request.Query)
            {
                switch (query.Key)
                {
                    case "eventsSinceNumber":
                        if (!long.TryParse(query.Value[0], out eventLow))
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                            return;
                        }

                        break;

                    case "eventsUntilNumber":
                        if (!long.TryParse(query.Value[0], out eventHigh))
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                            return;
                        }

                        break;

                    case "content":
                        contentHint = query.Value[0];
                        break;
                }
            }

            if (SubscriptionManagerR4.TryGetBundleForEvents(
                    subscriptionId,
                    eventLow,
                    eventHigh,
                    contentHint,
                    out fhirCsR4.Models.Bundle bundle))
            {
                // serialize and write back to the caller
                await ProcessorUtils.SerializeR4(context, bundle);
            }
            else
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return;
            }
        }

        /// <summary>Process an HTTP POST for FHIR R4.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result.</returns>
        internal static async Task ProcessPostAndRespond(HttpContext context)
        {
            // default to returning the representation if not specified
            ProcessorUtils.ReturnPref preferredResponse = ProcessorUtils.ReturnPref.Representation;

            // check for headers we are interested in
            foreach (KeyValuePair<string, StringValues> kvp in context.Request.Headers)
            {
                if (kvp.Key.ToUpperInvariant() == "PREFER")
                {
                    switch (kvp.Value[0].ToUpperInvariant())
                    {
                        case "RETURN=MINIMAL":
                            preferredResponse = ProcessorUtils.ReturnPref.Minimal;
                            break;

                        case "RETURN=OPERATIONOUTCOME":
                            preferredResponse = ProcessorUtils.ReturnPref.OperationOutcome;
                            break;

                        case "RETURN=REPRESENTATION":
                        default:
                            preferredResponse = ProcessorUtils.ReturnPref.Representation;
                            break;
                    }
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
                out fhir4.Hl7.Fhir.Model.Subscription subscription,
                out HttpStatusCode statusCode,
                out string failureContent);

            if (statusCode == HttpStatusCode.Created)
            {
                await ProcessorUtils.SerializeR4(
                    context,
                    subscription,
                    (int)statusCode,
                    Program.UrlForR4ResourceId("Subscription", subscription.Id),
                    preferredResponse,
                    failureContent);
            }
            else
            {
                await ProcessorUtils.SerializeR4(
                    context,
                    subscription,
                    (int)statusCode,
                    string.Empty,
                    preferredResponse,
                    failureContent);
            }
        }

        /// <summary>Process an HTTP GET in FHIR R4.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result.</returns>
        internal static async Task ProcessGetAndRespond(HttpContext context)
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
                await ProcessorUtils.SerializeR4(context, SubscriptionManagerR4.GetSubscriptionsBundle());
            }
            else if (SubscriptionManagerR4.TryGetSubscription(id, out fhir4.Hl7.Fhir.Model.Subscription foundSub))
            {
                await ProcessorUtils.SerializeR4(context, foundSub);
            }
            else
            {
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }
        }
    }
}
