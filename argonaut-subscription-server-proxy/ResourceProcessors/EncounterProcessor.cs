// <copyright file="EncounterProcessor.cs" company="Microsoft Corporation">
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
    /// <summary>An encounter processor.</summary>
    public abstract class EncounterProcessor
    {
        /// <summary>Process the request.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result that yields a HttpResponseMessage.</returns>
        internal static async Task<HttpResponseMessage> Process(HttpContext context)
        {
            string fhirServerUrl = ProcessorUtils.GetFhirServerUrl(context.Request);

            // context.Request.Headers["Accept-Encoding"] = "";
            // proxy this call
            ForwardContext proxiedContext = context.ForwardTo(fhirServerUrl);

            // send to server and await response
            HttpResponseMessage response = await proxiedContext.Send().ConfigureAwait(false);

            // get copies of data when we care
            switch (context.Request.Method.ToUpperInvariant())
            {
                case "PUT":
                case "POST":

                    // grab the message body to look at
                    string responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                    if (response.IsSuccessStatusCode)
                    {
                        // run this Encounter through our Subscription Manager
                        SubscriptionManager.ProcessEncounter(
                            responseContent,
                            response.Headers.Location);
                    }

                    break;

                default:

                    // ignore
                    break;
            }

            // return the results of the proxied call
            return response;
        }
    }
}
