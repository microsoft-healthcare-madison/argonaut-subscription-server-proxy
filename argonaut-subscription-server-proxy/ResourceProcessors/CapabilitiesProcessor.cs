// <copyright file="CapabilitiesProcessor.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir4;
extern alias fhir5;

using System;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProxyKit;
using r4 = fhir4.Hl7.Fhir.Model;
using r4s = fhir4.Hl7.Fhir.Serialization;
using r5 = fhir5.Hl7.Fhir.Model;
using r5s = fhir5.Hl7.Fhir.Serialization;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>The capabilities processor.</summary>
    public abstract class CapabilitiesProcessor
    {
        private static CamelCasePropertyNamesContractResolver _contractResolver = new CamelCasePropertyNamesContractResolver();

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
                HttpResponseMessage response = await proxiedContext.Send().ConfigureAwait(false);

                // get copies of data when we care
                switch (context.Request.Method.ToUpperInvariant())
                {
                    case "GET":

                        // check for a valid capability statement
                        try
                        {
                            // grab the message body to look at
                            string responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                            // parse this capabilities statement
                            fhirP5.CapabilityStatement capabilities = JsonConvert.DeserializeObject<fhirP5.CapabilityStatement>(responseContent);

                            // flag we are involved
                            if (capabilities.Software != null)
                            {
                                capabilities.Software.Name = $"Argo-Proxy: {capabilities.Software.Name}";
                                capabilities.Software.Version =
                                    FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).FileVersion.ToString()
                                    + ": " + capabilities.Software.Version;
                            }
                            else
                            {
                                capabilities.Software = new fhirP5.CapabilityStatementSoftware()
                                {
                                    Name = $"Argo-Proxy: {Program.FhirServerUrl}",
                                    Version = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).FileVersion.ToString(),
                                };
                            }

                            capabilities.Implementation = new fhirP5.CapabilityStatementImplementation()
                            {
                                Description = $"Argonaut Subscription Proxy to: {Program.FhirServerUrl}",
                                Url = Program.PublicUrl,
                            };

                            // only support application/fhir+json
                            capabilities.Format = new string[] { "application/fhir+json" };

                            // make sure Topic and Subscription are present
                            bool foundSubscription = false;
                            bool foundTopic = false;

                            for (int restIndex = 0;
                                    restIndex < capabilities.Rest.Length;
                                    restIndex++)
                            {
                                for (int resourceIndex = 0;
                                        resourceIndex < capabilities.Rest[restIndex].Resource.Length;
                                        resourceIndex++)
                                {
                                    if (capabilities.Rest[restIndex].Resource[resourceIndex].Type == "Topic")
                                    {
                                        foundTopic = true;
                                        capabilities.Rest[restIndex].Resource[resourceIndex] = GetTopicCapabilityResource();
                                    }

                                    if (capabilities.Rest[restIndex].Resource[resourceIndex].Type == "Subscription")
                                    {
                                        foundSubscription = true;
                                        capabilities.Rest[restIndex].Resource[resourceIndex] = GetSubscriptionCapabilityResource();
                                    }
                                }

                                if (foundTopic && foundSubscription)
                                {
                                    break;
                                }
                            }

                            // check for adding Topic
                            if (!foundTopic)
                            {
                                fhirP5.CapabilityStatementRestResource[] resources = new fhirP5.CapabilityStatementRestResource[capabilities.Rest[0].Resource.Length + 1];
                                capabilities.Rest[0].Resource.CopyTo(resources, 1);
                                resources[0] = GetTopicCapabilityResource();
                                capabilities.Rest[0].Resource = resources;
                            }

                            if (!foundSubscription)
                            {
                                fhirP5.CapabilityStatementRestResource[] resources = new fhirP5.CapabilityStatementRestResource[capabilities.Rest[0].Resource.Length + 1];
                                capabilities.Rest[0].Resource.CopyTo(resources, 1);
                                resources[0] = GetSubscriptionCapabilityResource();
                                capabilities.Rest[0].Resource = resources;
                            }

                            // serialize and return
                            response.Content = new StringContent(
                                JsonConvert.SerializeObject(
                                    capabilities,
                                    new JsonSerializerSettings()
                                    {
                                        NullValueHandling = NullValueHandling.Ignore,
                                        ContractResolver = _contractResolver,
                                    }));
                            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
                            response.StatusCode = System.Net.HttpStatusCode.OK;
                        }
                        catch (Exception ex)
                        {
                            // write to console
                            Console.WriteLine($"Failed to parse capability statement, {ex.Message}");
                        }

                        break;

                    default:

                        // ignore
                        break;
                }

                // return the results of the proxied call
                return response;
            });
        }

        /// <summary>Gets topic capability resource.</summary>
        /// <returns>The topic capability resource.</returns>
        private static fhirP5.CapabilityStatementRestResource GetTopicCapabilityResource()
        {
            return new fhirP5.CapabilityStatementRestResource()
            {
                Type = "SubscriptionTopic",
                Interaction = new fhirP5.CapabilityStatementRestResourceInteraction[]
                {
                    new fhirP5.CapabilityStatementRestResourceInteraction()
                    {
                        Code = fhirP5.CapabilityStatementRestResourceInteractionCodeCodes.READ,
                    },
                },
                Versioning = fhirP5.CapabilityStatementRestResourceVersioningCodes.NO_VERSION,
            };
        }

        /// <summary>Gets subscription capability resource.</summary>
        /// <returns>The subscription capability resource.</returns>
        private static fhirP5.CapabilityStatementRestResource GetSubscriptionCapabilityResource()
        {
            return new fhirP5.CapabilityStatementRestResource()
            {
                Type = "Subscription",
                Interaction = new fhirP5.CapabilityStatementRestResourceInteraction[]
                {
                    new fhirP5.CapabilityStatementRestResourceInteraction()
                    {
                        Code = fhirP5.CapabilityStatementRestResourceInteractionCodeCodes.READ,
                    },
                    new fhirP5.CapabilityStatementRestResourceInteraction()
                    {
                        Code = fhirP5.CapabilityStatementRestResourceInteractionCodeCodes.CREATE,
                    },
                    new fhirP5.CapabilityStatementRestResourceInteraction()
                    {
                        Code = fhirP5.CapabilityStatementRestResourceInteractionCodeCodes.DELETE,
                    },
                },
                Versioning = fhirP5.CapabilityStatementRestResourceVersioningCodes.NO_VERSION,
            };
        }
    }
}
