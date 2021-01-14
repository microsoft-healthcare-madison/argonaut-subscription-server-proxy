// <copyright file="CapabilitiesProcessorR5.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir5;

using System;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using fhir5.Hl7.Fhir.Model;
using fhir5.Hl7.Fhir.Serialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using ProxyKit;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>The capabilities processor.</summary>
    public abstract class CapabilitiesProcessorR5
    {
        /// <summary>The extension capability websocket.</summary>
        private const string ExtensionCapabilityWebsocket = "http://hl7.org/fhir/StructureDefinition/capabilitystatement-websocket";

        /// <summary>The FHIR parser.</summary>
        private static FhirJsonParser _fhirParser = new FhirJsonParser(new Hl7.Fhir.Serialization.ParserSettings()
        {
            AcceptUnknownMembers = true,
            AllowUnrecognizedEnums = true,
            PermissiveParsing = true,
        });

        /// <summary>Process the request.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result that yields a HttpResponseMessage.</returns>
        internal static async Task<HttpResponseMessage> Process(HttpContext context)
        {
            string fhirServerUrl = ProcessorUtils.GetFhirServerUrlR5(context.Request);

            if (context.Request.Path.Value.Length > 4)
            {
                context.Request.Path = new PathString(context.Request.Path.Value.Substring(3));
            }

            // proxy this call
            ForwardContext proxiedContext = context.ForwardTo(fhirServerUrl);

            // send to server and await response
            HttpResponseMessage response = await proxiedContext.Send().ConfigureAwait(false);

            // get copies of data when we care
            switch (context.Request.Method.ToUpperInvariant())
            {
                case "GET":
                    ProcessGet(ref context, ref response);

                    break;

                default:

                    // ignore
                    break;
            }

            // return the originator response, plus any modifications we've done
            return response;
        }

        /// <summary>Process an R5 metadata GET.</summary>
        /// <param name="context"> [in,out] The context.</param>
        /// <param name="response">[in,out] The response.</param>
        private static void ProcessGet(
            ref HttpContext context,
            ref HttpResponseMessage response)
        {
            // check for a valid capability statement
            try
            {
                // grab the message body to look at
                string responseContent = response.Content.ReadAsStringAsync().Result;

                CapabilityStatement capabilities = _fhirParser.Parse<CapabilityStatement>(responseContent);

                if (capabilities.Software == null)
                {
                    capabilities.Software = new CapabilityStatement.SoftwareComponent()
                    {
                        Name = $"Argo-Proxy: {Program.FhirServerUrlR5}",
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

                capabilities.Implementation = new CapabilityStatement.ImplementationComponent()
                {
                    Description = $"Argonaut Subscription Proxy to: {Program.FhirServerUrlR5}",
                    Url = Program.PublicUrl,
                };

                // only support application/fhir+json
                capabilities.Format = new string[] { "application/fhir+json" };

                // make sure resources we need are present
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
                        switch (capabilities.Rest[restIndex].Resource[resourceIndex].TypeName)
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
                                capabilities.Rest[restIndex].Extension[extIndex].Value = new Hl7.Fhir.Model.FhirUri(Program.WebsocketUrl);
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
                        capabilities.Rest[0].Extension = new System.Collections.Generic.List<Hl7.Fhir.Model.Extension>();
                    }

                    capabilities.Rest[0].Extension.Add(new Hl7.Fhir.Model.Extension()
                    {
                        Url = ExtensionCapabilityWebsocket,
                        Value = new Hl7.Fhir.Model.FhirUri(Program.WebsocketUrl),
                    });
                }

                // serialize and return
                ProcessorUtils.SerializeR5(ref response, capabilities);
            }
            catch (Exception ex)
            {
                // write to console
                Console.WriteLine($"Failed to parse capability statement, {ex.Message}");
            }
        }

        /// <summary>Builds subscription resource component.</summary>
        /// <returns>A CapabilityStatement.ResourceComponent.</returns>
        private static CapabilityStatement.ResourceComponent BuildSubscriptionResourceComponent()
        {
            return new CapabilityStatement.ResourceComponent()
            {
                Type = ResourceType.Subscription,
                Interaction = new System.Collections.Generic.List<CapabilityStatement.ResourceInteractionComponent>()
                {
                    new CapabilityStatement.ResourceInteractionComponent()
                    {
                        Code = TypeRestfulInteraction.Create,
                    },
                    new CapabilityStatement.ResourceInteractionComponent()
                    {
                        Code = TypeRestfulInteraction.Read,
                    },
                    new CapabilityStatement.ResourceInteractionComponent()
                    {
                        Code = TypeRestfulInteraction.Update,
                    },
                    new CapabilityStatement.ResourceInteractionComponent()
                    {
                        Code = TypeRestfulInteraction.Delete,
                    },
                },
                Versioning = CapabilityStatement.ResourceVersionPolicy.NoVersion,
                Operation = new System.Collections.Generic.List<CapabilityStatement.OperationComponent>()
                {
                    new CapabilityStatement.OperationComponent()
                    {
                        Name = "$status",
                        Definition = "http://hl7.org/fhir/OperationDefinition/Subscription-status",
                    },
                },
            };
        }

        /// <summary>Builds subscription resource component.</summary>
        /// <returns>A CapabilityStatement.ResourceComponent.</returns>
        private static CapabilityStatement.ResourceComponent BuildSubscriptionTopicResourceComponent()
        {
            return new CapabilityStatement.ResourceComponent()
            {
                Type = ResourceType.SubscriptionTopic,
                Interaction = new System.Collections.Generic.List<CapabilityStatement.ResourceInteractionComponent>()
                {
                    new CapabilityStatement.ResourceInteractionComponent()
                    {
                        Code = TypeRestfulInteraction.Read,
                    },
                },
                Versioning = CapabilityStatement.ResourceVersionPolicy.NoVersion,
            };
        }
    }
}
