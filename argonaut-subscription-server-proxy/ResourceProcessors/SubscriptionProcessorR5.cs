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
using System.Text.Json;
using System.Threading.Tasks;
using argonaut_subscription_server_proxy.Managers;
using argonaut_subscription_server_proxy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

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
                        context.Response.StatusCode = (int)System.Net.HttpStatusCode.NoContent;
                    }
                    else
                    {
                        context.Response.StatusCode = (int)System.Net.HttpStatusCode.NotFound;
                    }

                    break;

                case "PUT":
                default:
                    // tell client this isn't supported
                    context.Response.StatusCode = (int)System.Net.HttpStatusCode.NotImplemented;
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

                        fhirCsR5.Models.Parameters opParams = JsonSerializer.Deserialize<fhirCsR5.Models.Parameters>(requestContent);

                        foreach (fhirCsR5.Models.ParametersParameter param in opParams.Parameter)
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

            fhirCsR5.Models.Parameters parameters = new fhirCsR5.Models.Parameters();

            parameters.Parameter = new List<fhirCsR5.Models.ParametersParameter>()
            {
                new fhirCsR5.Models.ParametersParameter()
                {
                    Name = "token",
                    ValueString = token.Token.ToString(),
                },
                new fhirCsR5.Models.ParametersParameter()
                {
                    Name = "expiration",
                    ValueDateTime = token.ExpiresAt.ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK"),
                },
                new fhirCsR5.Models.ParametersParameter()
                {
                    Name = "subscriptions",
                    ValueString = string.Join(',', ids),
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
            fhir5.Hl7.Fhir.Model.Bundle bundle = new fhir5.Hl7.Fhir.Model.Bundle()
            {
                Type = fhir5.Hl7.Fhir.Model.Bundle.BundleType.Searchset,
                Timestamp = new DateTimeOffset(DateTime.Now),
                Meta = new Hl7.Fhir.Model.Meta(),
                Entry = new List<fhir5.Hl7.Fhir.Model.Bundle.EntryComponent>(),
            };

            foreach (string id in ids)
            {
                if (SubscriptionManagerR5.TryGetSubscriptionStatus(id, out fhir5.Hl7.Fhir.Model.SubscriptionStatus status, 0, true))
                {
                    bundle.Entry.Add(new fhir5.Hl7.Fhir.Model.Bundle.EntryComponent()
                    {
                        FullUrl = Program.UrlForR5ResourceId(status.TypeName, status.Id),
                        Resource = status,
                        Search = new fhir5.Hl7.Fhir.Model.Bundle.SearchComponent()
                        {
                            Mode = fhir5.Hl7.Fhir.Model.Bundle.SearchEntryMode.Match,
                        },
                    });
                }
            }

            await ProcessorUtils.SerializeR5(context, bundle);
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
                out fhir5.Hl7.Fhir.Model.Subscription subscription,
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
            else if (SubscriptionManagerR5.TryGetSubscription(id, out fhir5.Hl7.Fhir.Model.Subscription foundSub))
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
