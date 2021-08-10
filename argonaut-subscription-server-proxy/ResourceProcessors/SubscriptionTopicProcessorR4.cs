// <copyright file="SubscriptionTopicProcessorR4.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using System.Threading.Tasks;
using argonaut_subscription_server_proxy.Managers;
using Microsoft.AspNetCore.Http;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>A topic processor.</summary>
    public abstract class SubscriptionTopicProcessorR4
    {
        /// <summary>Process the given context.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result that yields a HttpResponseMessage.</returns>
        internal static async Task Process(HttpContext context)
        {
            if (ProcessorUtils.IsOperation(context.Request, out string _, out string _))
            {
                context.Response.StatusCode = (int)System.Net.HttpStatusCode.NotImplemented;
                return;
            }

            // get copies of data when we care
            switch (context.Request.Method.ToUpperInvariant())
            {
                case "GET":
                    await ProcessGetAndRespond(context);
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
        internal static async Task ProcessGetAndRespond(HttpContext context)
        {
            await ProcessorUtils.SerializeR4(context, SubscriptionTopicManagerR4.GetTopicsBundle());
        }
    }
}
