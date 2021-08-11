// <copyright file="ResourceProcessorR4.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using System.Threading.Tasks;
using argonaut_subscription_server_proxy.Managers;
using argonaut_subscription_server_proxy.Models;
using Microsoft.AspNetCore.Http;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>A resource processor.</summary>
    public abstract class ResourceProcessorR4
    {
        /// <summary>Process the request.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result that yields a HttpResponseMessage.</returns>
        internal static async Task Process(HttpContext context)
        {
            // remove our path prefix
            if (context.Request.Path.Value.Length > 4)
            {
                context.Request.Path = new PathString(context.Request.Path.Value.Substring(3));
            }

            ForwarderResponse forwarderResponse = await FhirForwardingService.Current.RequestR4(context.Request);

            await FhirForwardingService.Current.SendResponse(context, forwarderResponse);
        }
    }
}
