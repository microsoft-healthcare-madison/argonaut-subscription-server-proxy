// <copyright file="SubscriptionTopicProcessorR5.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir5;

using System.Net.Http;
using System.Threading.Tasks;
using argonaut_subscription_server_proxy.Managers;
using fhir5.Hl7.Fhir.Model;
using fhir5.Hl7.Fhir.Serialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using ProxyKit;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>A topic processor.</summary>
    public abstract class SubscriptionTopicProcessorR5
    {
        /// <summary>Process the given context.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result that yields a HttpResponseMessage.</returns>
        internal static async Task<HttpResponseMessage> Process(HttpContext context)
        {
            // create our response object
            HttpResponseMessage response = new HttpResponseMessage();

            if (ProcessorUtils.IsOperation(context.Request, out string operationName, out string prevComponent))
            {
                response.StatusCode = System.Net.HttpStatusCode.NotImplemented;
                return response;
            }

            // get copies of data when we care
            switch (context.Request.Method.ToUpperInvariant())
            {
                case "GET":
                    ProcessGet(ref context, ref response);

                    break;

                default:
                    // tell client we didn't understand
                    response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

                    break;
            }

            // return the originator response, plus any modifications we've done
            return response;
        }

        /// <summary>Process the get.</summary>
        /// <param name="context"> [in,out] The context.</param>
        /// <param name="response">[in,out] The response message.</param>
        internal static void ProcessGet(ref HttpContext context, ref HttpResponseMessage response)
        {
            ProcessorUtils.SerializeR5(ref response, SubscriptionTopicManager.GetTopicsBundle());
        }
    }
}
