﻿// <copyright file="SubscriptionTopicProcessorR5.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using System.Net;
using System.Threading.Tasks;
using argonaut_subscription_server_proxy.Managers;
using Microsoft.AspNetCore.Http;
using fhirCsModels5 = fhirCsR5.Models;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>A topic processor.</summary>
    public abstract class SubscriptionTopicProcessorR5
    {
        /// <summary>Process the given context.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result that yields a HttpResponseMessage.</returns>
        internal static async Task Process(HttpContext context)
        {
            if (ProcessorUtils.IsOperation(context.Request, out _, out string _))
            {
                context.Response.StatusCode = (int)System.Net.HttpStatusCode.NotImplemented;
                return;
            }

            // get copies of data when we care
            switch (context.Request.Method.ToUpperInvariant())
            {
                case "GET":
                    await ProcessGet(context);
                    break;

                default:
                    // tell client this isn't supported
                    context.Response.StatusCode = (int)System.Net.HttpStatusCode.NotImplemented;
                    break;
            }
        }

        /// <summary>Process the get.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result.</returns>
        internal static async Task ProcessGet(HttpContext context)
        {
            // check for an ID
            string requestUrl = context.Request.Path;
            if (requestUrl.EndsWith('/'))
            {
                requestUrl = requestUrl.Substring(0, requestUrl.Length - 1);
            }

            string id = requestUrl.Substring(requestUrl.LastIndexOf('/') + 1);

            if (id.ToLowerInvariant() == "subscriptiontopic")
            {
                await ProcessorUtils.SerializeR5(context, SubscriptionTopicManagerR5.GetTopicsBundle());
            }
            else if (SubscriptionTopicManagerR5.TryGetTopic(id, out fhirCsModels5.SubscriptionTopic foundST))
            {
                await ProcessorUtils.SerializeR5(context, foundST);
            }
            else
            {
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }

        }
    }
}
