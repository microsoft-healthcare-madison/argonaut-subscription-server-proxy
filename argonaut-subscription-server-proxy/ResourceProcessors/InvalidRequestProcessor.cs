// <copyright file="InvalidRequestProcessor.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>
using System.Net.Http;
using System.Threading.Tasks;
using argonaut_subscription_server_proxy.Managers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using ProxyKit;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>Invalid request processor.</summary>
    public abstract class InvalidRequestProcessor
    {
        /// <summary>Process the request.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result that yields a HttpResponseMessage.</returns>
        internal static async Task<HttpResponseMessage> Process(HttpContext context)
        {
            HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);

            return response;
        }
    }
}
