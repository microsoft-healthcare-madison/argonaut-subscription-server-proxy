// <copyright file="ResourceProcessor.cs" company="Microsoft Corporation">
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
    public abstract class ResourceProcessor
    {
        /// <summary>Process the request.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result that yields a HttpResponseMessage.</returns>
        internal static async Task<HttpResponseMessage> Process(HttpContext context)
        {
            bool isR4 = ProcessorUtils.IsR4(context.Request);
            string fhirServerUrl = ProcessorUtils.GetFhirServerUrl(context.Request);

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

            // proxy this call
            ForwardContext proxiedContext = context.ForwardTo(fhirServerUrl);

            // send to server and await response
            HttpResponseMessage response = await proxiedContext.Send().ConfigureAwait(false);

            //// get copies of data when we care
            //switch (context.Request.Method.ToUpperInvariant())
            //{
            //    case "PUT":
            //    case "POST":

            //        // grab the message body to look at
            //        string responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            //        // run this Encounter through our Subscription Manager
            //        SubscriptionManager.ProcessEncounter(responseContent, response.Headers.Location);

            //        break;

            //    default:

            //        // just proxy
            //        break;
            //}

            // return the results of the proxied call
            return response;
        }
    }
}
