// <copyright file="CapabilitiesProcessorR4.cs" company="Microsoft Corporation">
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
using fhirCsModels4B = fhirCsR4B.Models;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>The capabilities processor.</summary>
    public abstract class CapabilitiesProcessorR4
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

            ForwarderResponse fhirResponse = await FhirForwardingService.Current.RequestR4(context.Request);

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

        /// <summary>Process an R4 metadata GET to add our proxy information.</summary>
        /// <param name="context">     The context.</param>
        /// <param name="fhirResponse">The response.</param>
        /// <returns>An asynchronous result.</returns>
        private static async Task ProcessGetAndRespond(
            HttpContext context,
            ForwarderResponse fhirResponse)
        {
            // check for a valid capability statement
            try
            {
                fhirCsModels4B.CapabilityStatement capabilities =
                    JsonSerializer.Deserialize<fhirCsModels4B.CapabilityStatement>(fhirResponse.Body);

                if (capabilities.Software == null)
                {
                    capabilities.Software = new fhirCsModels4B.CapabilityStatementSoftware()
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

                capabilities.Implementation = new fhirCsModels4B.CapabilityStatementImplementation()
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
                                capabilities.Rest[restIndex].Extension[extIndex].ValueUri = Program.WebsocketUriR4.AbsoluteUri;
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
                        capabilities.Rest[0].Extension = new List<fhirCsModels4B.Extension>();
                    }

                    capabilities.Rest[0].Extension.Add(new fhirCsModels4B.Extension()
                    {
                        Url = ExtensionCapabilityWebsocket,
                        ValueUri = Program.WebsocketUriR4.AbsoluteUri,
                    });
                }

                // serialize and respond
                await ProcessorUtils.SerializeR4(context, capabilities);
            }
            catch (Exception ex)
            {
                // write to console
                Console.WriteLine($"Failed to parse capability statement, {ex.Message}");
            }
        }

        /// <summary>Builds subscription resource component.</summary>
        /// <returns>A CapabilityStatement.ResourceComponent.</returns>
        private static fhirCsModels4B.CapabilityStatementRestResource BuildSubscriptionResourceComponent()
        {
            return new fhirCsModels4B.CapabilityStatementRestResource()
            {
                Type = "Subscription",
                Interaction = new List<fhirCsModels4B.CapabilityStatementRestResourceInteraction>()
                {
                    new fhirCsModels4B.CapabilityStatementRestResourceInteraction()
                    {
                        Code = fhirCsModels4B.CapabilityStatementRestResourceInteractionCodeCodes.CREATE,
                    },
                    new fhirCsModels4B.CapabilityStatementRestResourceInteraction()
                    {
                        Code = fhirCsModels4B.CapabilityStatementRestResourceInteractionCodeCodes.READ,
                    },
                    new fhirCsModels4B.CapabilityStatementRestResourceInteraction()
                    {
                        Code = fhirCsModels4B.CapabilityStatementRestResourceInteractionCodeCodes.UPDATE,
                    },
                    new fhirCsModels4B.CapabilityStatementRestResourceInteraction()
                    {
                        Code = fhirCsModels4B.CapabilityStatementRestResourceInteractionCodeCodes.DELETE,
                    },
                },
                Versioning = fhirCsModels4B.CapabilityStatementRestResourceVersioningCodes.NO_VERSION,
                Operation = new List<fhirCsModels4B.CapabilityStatementRestResourceOperation>()
                {
                    new fhirCsModels4B.CapabilityStatementRestResourceOperation()
                    {
                        Name = "$status",
                        Definition = "http://hl7.org/fhir/uv/subscriptions-backport/OperationDefinition/backport-subscription-status",
                    },
                    new fhirCsModels4B.CapabilityStatementRestResourceOperation()
                    {
                        Name = "$get-ws-binding-token",
                        Definition = "http://hl7.org/fhir/uv/subscriptions-backport/OperationDefinition/backport-subscription-get-ws-binding-token",
                    },
                },
                SearchParam = new List<fhirCsModels4B.CapabilityStatementRestResourceSearchParam>()
                {
                    new fhirCsModels4B.CapabilityStatementRestResourceSearchParam()
                    {
                        Name = "_id",
                        Definition = "http://hl7.org/fhir/SearchParameter/subscription-_id",
                        Type = "token",
                        Documentation = "The ID of the resource",
                    },
                    new fhirCsModels4B.CapabilityStatementRestResourceSearchParam()
                    {
                        Name = "status",
                        Definition = "http://hl7.org/fhir/SearchParameter/subscription-status",
                        Type = "token",
                        Documentation = "The current status of the subscription",
                    },
                    new fhirCsModels4B.CapabilityStatementRestResourceSearchParam()
                    {
                        Name = "url",
                        Definition = "http://hl7.org/fhir/SearchParameter/subscription-url",
                        Type = "uri",
                        Documentation = "The uri that will receive the notifications",
                    },
                    new fhirCsModels4B.CapabilityStatementRestResourceSearchParam()
                    {
                        Name = "criteria",
                        Definition = "http://hl7.org/fhir/SearchParameter/subscription-criteria",
                        Type = "string",
                        Documentation = "The search rules used to determine when to send a notification",
                    },
                },
            };
        }

        /// <summary>Builds subscription resource component.</summary>
        /// <returns>A CapabilityStatement.ResourceComponent.</returns>
        private static fhirCsModels4B.CapabilityStatementRestResource BuildSubscriptionTopicResourceComponent()
        {
            return new fhirCsModels4B.CapabilityStatementRestResource()
            {
                Type = "SubscriptionTopic",
                Interaction = new List<fhirCsModels4B.CapabilityStatementRestResourceInteraction>()
                {
                    new fhirCsModels4B.CapabilityStatementRestResourceInteraction()
                    {
                        Code = fhirCsModels4B.CapabilityStatementRestResourceInteractionCodeCodes.READ,
                    },
                },
                Versioning = fhirCsModels4B.CapabilityStatementRestResourceVersioningCodes.NO_VERSION,
            };
        }
    }
}
