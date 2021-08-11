// <copyright file="CapabilitiesProcessorR5.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using argonaut_subscription_server_proxy.Managers;
using argonaut_subscription_server_proxy.Models;
using Microsoft.AspNetCore.Http;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>The capabilities processor.</summary>
    public abstract class CapabilitiesProcessorR5
    {
        /// <summary>The extension capability websocket.</summary>
        private const string ExtensionCapabilityWebsocket = "http://hl7.org/fhir/StructureDefinition/capabilitystatement-websocket";

        /// <summary>Process the request.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result that yields a HttpResponseMessage.</returns>
        internal static async Task Process(HttpContext context)
        {
            if (context.Request.Path.Value.Length > 4)
            {
                context.Request.Path = new PathString(context.Request.Path.Value.Substring(3));
            }

            ForwarderResponse fhirResponse = await FhirForwardingService.Current.RequestR5(context.Request);

            if (!fhirResponse.IsSuccessStatusCode)
            {
                context.Response.StatusCode = (int)fhirResponse.StatusCode;
                if (!string.IsNullOrEmpty(fhirResponse.Body))
                {
                    await context.Response.WriteAsync(fhirResponse.Body);
                }

                return;
            }

            switch (context.Request.Method.ToUpperInvariant())
            {
                case "GET":
                    await ProcessGetAndRespond(context, fhirResponse);
                    break;

                // pass through the original response, plus any modifications
                case "DELETE":
                case "HEAD":
                case "POST":
                case "PUT":
                case "TRACE":
                default:
                    context.Response.StatusCode = (int)fhirResponse.StatusCode;
                    if (!string.IsNullOrEmpty(fhirResponse.Body))
                    {
                        await context.Response.WriteAsync(fhirResponse.Body);
                    }

                    break;
            }
        }

        /// <summary>Process an R5 metadata GET.</summary>
        /// <param name="context">     The context.</param>
        /// <param name="fhirResponse">The FHIR response.</param>
        /// <returns>An asynchronous result.</returns>
        private static async Task ProcessGetAndRespond(
            HttpContext context,
            ForwarderResponse fhirResponse)
        {
            // check for a valid capability statement
            try
            {
                fhirCsR5.Models.CapabilityStatement capabilities =
                    JsonSerializer.Deserialize<fhirCsR5.Models.CapabilityStatement>(fhirResponse.Body);

                if (capabilities.Software == null)
                {
                    capabilities.Software = new fhirCsR5.Models.CapabilityStatementSoftware()
                    {
                        Name = $"Argo-Proxy: {Program.FhirServerUrlR4}",
                        Version = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).FileVersion.ToString(),
                    };
                }
                else
                {
                    capabilities.Software.Name = $"Argo-Proxy: {capabilities.Software.Name}";
                    capabilities.Software.Version =
                        FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).FileVersion.ToString()
                        + ": " + capabilities.Software.Version;
                }

                capabilities.Implementation = new fhirCsR5.Models.CapabilityStatementImplementation()
                {
                    Description = $"Argonaut Subscription Proxy to: {Program.FhirServerUrlR4}",
                    Url = Program.PublicUrl,
                };

                // only support application/fhir+json
                capabilities.Format = new List<string>() { "application/fhir+json" };

                // make sure Subscription is present
                bool foundSubscription = false;
                bool foundSubscriptionTopic = false;
                bool foundWebSocketUrl = false;

                for (int restIndex = 0;
                        restIndex < capabilities.Rest.Count;
                        restIndex++)
                {
                    for (int resourceIndex = 0;
                            resourceIndex < capabilities.Rest[restIndex].Resource.Count;
                            resourceIndex++)
                    {
                        switch (capabilities.Rest[restIndex].Resource[resourceIndex].Type)
                        {
                            case "Subscription":
                                foundSubscription = true;
                                capabilities.Rest[restIndex].Resource[resourceIndex] = BuildSubscriptionResourceComponent();
                                break;

                            case "SubscriptionTopic":
                                foundSubscriptionTopic = true;
                                capabilities.Rest[restIndex].Resource[resourceIndex] = BuildSubscriptionTopicResourceComponent();
                                break;
                        }
                    }

                    if (capabilities.Rest[restIndex].Extension != null)
                    {
                        for (int extIndex = 0;
                                extIndex < capabilities.Rest[restIndex].Extension.Count;
                                extIndex++)
                        {
                            if (capabilities.Rest[restIndex].Extension[extIndex].Url == ExtensionCapabilityWebsocket)
                            {
                                foundWebSocketUrl = true;
                                capabilities.Rest[restIndex].Extension[extIndex].ValueUri = Program.WebsocketUrl;
                            }
                        }
                    }
                }

                if (!foundSubscription)
                {
                    capabilities.Rest[0].Resource.Add(BuildSubscriptionResourceComponent());
                }

                if (!foundSubscriptionTopic)
                {
                    capabilities.Rest[0].Resource.Add(BuildSubscriptionTopicResourceComponent());
                }

                if (!foundWebSocketUrl)
                {
                    if (capabilities.Rest[0].Extension == null)
                    {
                        capabilities.Rest[0].Extension = new List<fhirCsR5.Models.Extension>();
                    }

                    capabilities.Rest[0].Extension.Add(new fhirCsR5.Models.Extension()
                    {
                        Url = ExtensionCapabilityWebsocket,
                        ValueUri = Program.WebsocketUrl,
                    });
                }

                // serialize and respond
                await ProcessorUtils.SerializeR5(context, capabilities);
            }
            catch (Exception ex)
            {
                // write to console
                Console.WriteLine($"Failed to parse capability statement, {ex.Message}");
            }
        }

        /// <summary>Builds subscription resource component.</summary>
        /// <returns>A CapabilityStatement.ResourceComponent.</returns>
        private static fhirCsR5.Models.CapabilityStatementRestResource BuildSubscriptionResourceComponent()
        {
            return new fhirCsR5.Models.CapabilityStatementRestResource()
            {
                Type = "Subscription",
                Interaction = new List<fhirCsR5.Models.CapabilityStatementRestResourceInteraction>()
                {
                    new fhirCsR5.Models.CapabilityStatementRestResourceInteraction()
                    {
                        Code = fhirCsR5.Models.CapabilityStatementRestResourceInteractionCodeCodes.CREATE,
                    },
                    new fhirCsR5.Models.CapabilityStatementRestResourceInteraction()
                    {
                        Code = fhirCsR5.Models.CapabilityStatementRestResourceInteractionCodeCodes.READ,
                    },
                    new fhirCsR5.Models.CapabilityStatementRestResourceInteraction()
                    {
                        Code = fhirCsR5.Models.CapabilityStatementRestResourceInteractionCodeCodes.UPDATE,
                    },
                    new fhirCsR5.Models.CapabilityStatementRestResourceInteraction()
                    {
                        Code = fhirCsR5.Models.CapabilityStatementRestResourceInteractionCodeCodes.DELETE,
                    },
                },
                Versioning = fhirCsR5.Models.CapabilityStatementRestResourceVersioningCodes.NO_VERSION,
                Operation = new List<fhirCsR5.Models.CapabilityStatementRestResourceOperation>()
                {
                    new fhirCsR5.Models.CapabilityStatementRestResourceOperation()
                    {
                        Name = "$status",
                        Definition = "http://hl7.org/fhir/OperationDefinition/Subscription-status",
                    },
                    new fhirCsR5.Models.CapabilityStatementRestResourceOperation()
                    {
                        Name = "$get-ws-binding-token",
                        Definition = "http://hl7.org/fhir/OperationDefinition/Subscription-get-ws-binding-token",
                    },
                },
            };
        }

        /// <summary>Builds subscription resource component.</summary>
        /// <returns>A CapabilityStatement.ResourceComponent.</returns>
        private static fhirCsR5.Models.CapabilityStatementRestResource BuildSubscriptionTopicResourceComponent()
        {
            return new fhirCsR5.Models.CapabilityStatementRestResource()
            {
                Type = "SubscriptionTopic",
                Interaction = new List<fhirCsR5.Models.CapabilityStatementRestResourceInteraction>()
                {
                    new fhirCsR5.Models.CapabilityStatementRestResourceInteraction()
                    {
                        Code = fhirCsR5.Models.CapabilityStatementRestResourceInteractionCodeCodes.READ,
                    },
                },
                Versioning = fhirCsR5.Models.CapabilityStatementRestResourceVersioningCodes.NO_VERSION,
            };
        }
    }
}
