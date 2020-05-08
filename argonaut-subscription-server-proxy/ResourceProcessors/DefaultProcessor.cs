// <copyright file="DefaultProcessor.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>
using Microsoft.AspNetCore.Builder;
using ProxyKit;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>A default processor.</summary>
    public abstract class DefaultProcessor
    {
        /// <summary>Process the request.</summary>
        /// <param name="appInner">     The application inner.</param>
        /// <param name="fhirServerUrl">URL of the fhir server.</param>
        public static void ProcessRequest(IApplicationBuilder appInner, string fhirServerUrl)
        {
            // run the proxy for this request
            appInner.RunProxy(async context =>
            {
                // look for a FHIR server header
                if (context.Request.Headers.ContainsKey(Program._proxyHeaderKey) &&
                    (context.Request.Headers[Program._proxyHeaderKey].Count > 0))
                {
                    fhirServerUrl = context.Request.Headers[Program._proxyHeaderKey][0];
                }

                // proxy this call
                ForwardContext proxiedContext = context.ForwardTo(fhirServerUrl);

                // send to server and await response
                return await proxiedContext.Send().ConfigureAwait(false);
            });
        }
    }
}
