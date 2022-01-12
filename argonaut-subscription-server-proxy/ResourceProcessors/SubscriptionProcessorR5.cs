// <copyright file="SubscriptionProcessorR5.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

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
using fhirCsModels5 = fhirCsR5.Models;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>A subscription processor.</summary>
    public abstract class SubscriptionProcessorR5
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
                    if (SubscriptionManagerR5.HandleDelete(context.Request))
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.NoContent;
                    }
                    else
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    }

                    break;

                case "PUT":
                default:
                    // tell client this isn't supported
                    context.Response.StatusCode = (int)HttpStatusCode.NotImplemented;
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
                        context.Response.StatusCode = (int)HttpStatusCode.NotImplemented;
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
                        context.Response.StatusCode = (int)HttpStatusCode.NotImplemented;
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
                        context.Response.StatusCode = (int)HttpStatusCode.NotImplemented;
                        break;
                }

                return;
            }

            // tell client this isn't supported
            context.Response.StatusCode = (int)HttpStatusCode.NotImplemented;
        }

        /// <summary>Process the operation get ws binding token described by response.</summary>
        /// <param name="context">          The context.</param>
        /// <param name="previousComponent">The previous component.</param>
        /// <returns>An asynchronous result.</returns>
        internal static async Task ProcessOperationGetWsBindingToken(
            HttpContext context,
            string previousComponent)
        {
            List<string> ids = new ();

            if (previousComponent != "Subscription")
            {
                ids.Add(previousComponent);
            }
            else
            {
                try
                {
                    string requestContent;

                    using (StreamReader reader = new StreamReader(context.Request.Body))
                    {
                        requestContent = reader.ReadToEndAsync().Result;
                    }

                    fhirCsModels5.Parameters opParams = JsonSerializer.Deserialize<fhirCsModels5.Parameters>(requestContent);

                    foreach (fhirCsModels5.ParametersParameter param in opParams.Parameter)
                    {
                        if (param.Name == "ids")
                        {
                            if (!string.IsNullOrEmpty(param.ValueString))
                            {
                                ids.Add(param.ValueString);
                            }

                            if (!string.IsNullOrEmpty(param.ValueId))
                            {
                                ids.Add(param.ValueId);
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
                if (!SubscriptionManagerR5.Exists(id))
                {
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    context.Response.ContentType = "text/plain";
                    await context.Response.WriteAsync($"Invalid subscription id: {id}");
                    return;
                }
            }

            SubscriptionWsBindingToken token = SubscriptionWsBindingToken.GetTokenR5(ids);

            WebsocketManager.RegisterToken(token);

            fhirCsModels5.Parameters parameters = new ();

            parameters.Parameter = new ()
            {
                new ()
                {
                    Name = "token",
                    ValueString = token.Token.ToString(),
                },
                new ()
                {
                    Name = "expiration",
                    ValueDateTime = token.ExpiresAt.ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK"),
                },
                new ()
                {
                    Name = "subscriptions",
                    ValueString = string.Join(',', ids),
                },
                new ()
                {
                    Name = "websocket-url",
                    ValueString = Program.WebsocketUriR5.AbsoluteUri,
                },
            };

            await ProcessorUtils.SerializeR5(context, parameters);
        }

        /// <summary>Process the operation status R5.</summary>
        /// <param name="context">          The context.</param>
        /// <param name="previousComponent">The previous component.</param>
        /// <returns>An asynchronous result.</returns>
        internal static async Task ProcessOperationStatus(
            HttpContext context,
            string previousComponent)
        {
            List<string> ids = new ();

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
            fhirCsModels5.Bundle bundle = new ()
            {
                Type = fhirCsModels5.BundleTypeCodes.SEARCHSET,
                Timestamp = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK"),
                Meta = new ()
                {
                    LastUpdated = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK"),
                },
                Entry = new (),
            };

            foreach (string id in ids)
            {
                if (SubscriptionManagerR5.TryGetSubscriptionStatus(
                        id,
                        out fhirCsModels5.SubscriptionStatus status,
                        0,
                        true,
                        false))
                {
                    bundle.Entry.Add(new fhirCsModels5.BundleEntry()
                    {
                        FullUrl = Program.UrlForR5ResourceId("Subscription", id) + "/$status",
                        Resource = status,
                        Search = new fhirCsModels5.BundleEntrySearch()
                        {
                            Mode = fhirCsModels5.BundleEntrySearchModeCodes.MATCH,
                        },
                    });
                }
            }

            await ProcessorUtils.SerializeR5(context, bundle);
        }

        /// <summary>Process the operation events R5.</summary>
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

            if (SubscriptionManagerR5.TryGetBundleForEvents(
                    subscriptionId,
                    eventLow,
                    eventHigh,
                    contentHint,
                    out fhirCsModels5.Bundle bundle))
            {
                // serialize and write back to the caller
                await ProcessorUtils.SerializeR5(context, bundle);
            }
            else
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return;
            }
        }

        /// <summary>Process an HTTP POST for FHIR R5.</summary>
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

            using (StreamReader requestReader = new System.IO.StreamReader(context.Request.Body))
            {
                // grab the message body to look at
                requestContent = requestReader.ReadToEndAsync().Result;
            }

            // check to see if the manager does anything with this text
            SubscriptionManagerR5.HandlePost(
                requestContent,
                out fhirCsModels5.Subscription subscription,
                out HttpStatusCode statusCode,
                out string failureContent);

            if (statusCode == HttpStatusCode.Created)
            {
                await ProcessorUtils.SerializeR5(
                    context,
                    subscription,
                    (int)statusCode,
                    Program.UrlForR5ResourceId("Subscription", subscription.Id),
                    preferredResponse,
                    failureContent);
            }
            else
            {
                await ProcessorUtils.SerializeR5(
                    context,
                    subscription,
                    (int)statusCode,
                    string.Empty,
                    preferredResponse,
                    failureContent);
            }
        }

        /// <summary>Process an HTTP GET in FHIR R5.</summary>
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
                await ProcessorUtils.SerializeR5(context, SubscriptionManagerR5.GetSubscriptionsBundle());
            }
            else if (SubscriptionManagerR5.TryGetSubscription(id, out fhirCsModels5.Subscription foundSub))
            {
                await ProcessorUtils.SerializeR5(context, foundSub);
            }
            else
            {
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }
        }
    }
}
