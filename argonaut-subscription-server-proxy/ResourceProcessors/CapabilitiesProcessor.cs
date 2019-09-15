using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProxyKit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    public class CapabilitiesProcessor
    {
        private static CamelCasePropertyNamesContractResolver _contractResolver = new CamelCasePropertyNamesContractResolver();


        public static void ProcessRequest(IApplicationBuilder appInner, string fhirServerUrl)
        {
            // **** run the proxy for this request ****

            appInner.RunProxy(async context =>
            {
                // **** look for a FHIR server header ****

                if ((context.Request.Headers.ContainsKey(Program._proxyHeaderKey)) &&
                    (context.Request.Headers[Program._proxyHeaderKey].Count > 0))
                {
                    fhirServerUrl = context.Request.Headers[Program._proxyHeaderKey][0];
                }

                // **** proxy this call ****

                ForwardContext proxiedContext = context.ForwardTo(fhirServerUrl);

                // **** send to server and await response ****

                HttpResponseMessage response = await proxiedContext.Send();

                // **** get copies of data when we care ****

                switch (context.Request.Method.ToUpper())
                {
                    case "GET":

                        // **** check for a valid capability statement ****

                        try
                        {
                            // **** grab the message body to look at ****

                            string responseContent = await response.Content.ReadAsStringAsync();

                            // **** parse this capabilities statement ****

                            fhir.CapabilityStatement capabilities = JsonConvert.DeserializeObject<fhir.CapabilityStatement>(responseContent);

                            // **** flag we are involved ****

                            if (capabilities.Software != null)
                            {
                                capabilities.Software.Name = $"Argo-Proxy: {capabilities.Software.Name}";
                                capabilities.Software.Version =
                                    FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).FileVersion.ToString()
                                    + ": " + capabilities.Software.Version;

                            }
                            else
                            {
                                capabilities.Software = new fhir.CapabilityStatementSoftware()
                                {
                                    Name = $"Argo-Proxy: {Program.FhirServerUrl}",
                                    Version = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).FileVersion.ToString(),
                                };
                            }

                            capabilities.Implementation = new fhir.CapabilityStatementImplementation()
                            {
                                Description = $"Argonaut Subscription Proxy to: {Program.FhirServerUrl}",
                                Url = Program.PublicUrl,
                            };

                            // **** only support application/fhir+json ****

                            capabilities.Format = new string[] { "application/fhir+json" };

                            // **** make sure Topic and Subscription are present ****

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
                                if ((foundTopic) && (foundSubscription))
                                {
                                    break;
                                }
                            }

                            // **** check for adding Topic ****

                            if (!foundTopic)
                            {
                                fhir.CapabilityStatementRestResource[] resources = new fhir.CapabilityStatementRestResource[capabilities.Rest[0].Resource.Length + 1];
                                capabilities.Rest[0].Resource.CopyTo(resources, 1);
                                resources[0] = GetTopicCapabilityResource();
                                capabilities.Rest[0].Resource = resources;
                            }

                            if (!foundSubscription)
                            {
                                fhir.CapabilityStatementRestResource[] resources = new fhir.CapabilityStatementRestResource[capabilities.Rest[0].Resource.Length + 1];
                                capabilities.Rest[0].Resource.CopyTo(resources, 1);
                                resources[0] = GetSubscriptionCapabilityResource();
                                capabilities.Rest[0].Resource = resources;
                            }

                            // **** serialize and return ****

                            response.Content = new StringContent(
                                JsonConvert.SerializeObject(
                                    capabilities,
                                    new JsonSerializerSettings()
                                    {
                                        NullValueHandling = NullValueHandling.Ignore,
                                        ContractResolver = _contractResolver,
                                    })
                                );
                            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
                            response.StatusCode = System.Net.HttpStatusCode.OK;
                        }
                        catch (Exception ex)
                        {
                            // **** write to console ****

                            Console.WriteLine($"Failed to parse capability statement, {ex.Message}");
                        }

                        break;

                    default:

                        // **** ignore ****

                        break;
                }

                // **** return the results of the proxied call ****

                return response;
            });
        }

        private static fhir.CapabilityStatementRestResource GetTopicCapabilityResource()
        {
            return new fhir.CapabilityStatementRestResource()
            {
                Type = "Topic",
                Interaction = new fhir.CapabilityStatementRestResourceInteraction[]
                                        {
                                            new fhir.CapabilityStatementRestResourceInteraction()
                                            {
                                                Code = fhir.CapabilityStatementRestResourceInteractionCodeCodes.READ
                                            },
                                            //new fhir.CapabilityStatementRestResourceInteraction()
                                            //{
                                            //    Code = fhir.CapabilityStatementRestResourceInteractionCodeCodes.SEARCH_TYPE
                                            //},
                                            // TODO(ginoc): Support Topic creation and deletion
                                            //new fhir.CapabilityStatementRestResourceInteraction()
                                            //{
                                            //    Code = fhir.CapabilityStatementRestResourceInteractionCodeCodes.CREATE
                                            //},
                                            //new fhir.CapabilityStatementRestResourceInteraction()
                                            //{ 
                                            //    Code = fhir.CapabilityStatementRestResourceInteractionCodeCodes.DELETE
                                            //},
                                        },
                Versioning = fhir.CapabilityStatementRestResourceVersioningCodes.NO_VERSION,
            };
        }


        private static fhir.CapabilityStatementRestResource GetSubscriptionCapabilityResource()
        {
            return new fhir.CapabilityStatementRestResource()
            {
                Type = "Subscription",
                Interaction = new fhir.CapabilityStatementRestResourceInteraction[]
                                        {
                                        new fhir.CapabilityStatementRestResourceInteraction()
                                        {
                                            Code = fhir.CapabilityStatementRestResourceInteractionCodeCodes.READ
                                        },
                                        //new fhir.CapabilityStatementRestResourceInteraction()
                                        //{
                                        //    Code = fhir.CapabilityStatementRestResourceInteractionCodeCodes.SEARCH_TYPE
                                        //},
                                        new fhir.CapabilityStatementRestResourceInteraction()
                                        {
                                            Code = fhir.CapabilityStatementRestResourceInteractionCodeCodes.CREATE
                                        },
                                        new fhir.CapabilityStatementRestResourceInteraction()
                                        {
                                            Code = fhir.CapabilityStatementRestResourceInteractionCodeCodes.DELETE
                                        },
                                        },
                Versioning = fhir.CapabilityStatementRestResourceVersioningCodes.NO_VERSION,
            };
        }
    }
}

