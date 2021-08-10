// <copyright file="EncounterProcessorR4.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using System.Threading.Tasks;
using argonaut_subscription_server_proxy.Managers;
using argonaut_subscription_server_proxy.Models;
using Microsoft.AspNetCore.Http;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>An encounter processor.</summary>
    public abstract class EncounterProcessorR4
    {
        /// <summary>Process the request.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result that yields a HttpResponseMessage.</returns>
        internal static async Task Process(HttpContext context)
        {
            if (context.Request.Path.Value.Length > 4)
            {
                context.Request.Path = new PathString(context.Request.Path.Value.Substring(3));
            }

            ForwarderResponse forwarderResponse = await FhirForwardingService.Current.RequestR4(context.Request);

            await FhirForwardingService.Current.SendResponse(context, forwarderResponse);

            // get copies of data when we care
            switch (context.Request.Method.ToUpperInvariant())
            {
                case "PUT":
                case "POST":

                    if (forwarderResponse.IsSuccessStatusCode)
                    {
                        // run this Encounter through our Subscription Manager
                        SubscriptionManagerR4.ProcessEncounter(
                            forwarderResponse.Body,
                            forwarderResponse.Location);
                    }

                    break;

                default:

                    // ignore
                    break;
            }
        }
    }
}
