// <copyright file="ResourceProcessorR4.cs" company="Microsoft Corporation">
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
    /// <summary>A resource processor.</summary>
    public abstract class ResourceProcessorR4
    {
        /// <summary>Process the request.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result that yields a HttpResponseMessage.</returns>
        internal static async Task<HttpResponseMessage> Process(HttpContext context)
        {
            string fhirServerUrl = ProcessorUtils.GetFhirServerUrlR4(context.Request);

            // determine if we need to ask the server for a current version of the resource
            switch (context.Request.Method)
            {
                case "PUT":
                case "POST":
                case "DELETE":

                    // figure out if we need to ask the server about this
                    break;

                default:
                    // don't need to check for existing copy
                    break;
            }

            // remove our path prefix
            if (context.Request.Path.Value.Length > 4)
            {
                context.Request.Path = new PathString(context.Request.Path.Value.Substring(3));
            }

            // proxy this call
            ForwardContext proxiedContext = context.ForwardTo(fhirServerUrl);

            // send to server and await response
            HttpResponseMessage response = await proxiedContext.Send().ConfigureAwait(false);

            // return the results of the proxied call
            return response;
        }
    }
}
