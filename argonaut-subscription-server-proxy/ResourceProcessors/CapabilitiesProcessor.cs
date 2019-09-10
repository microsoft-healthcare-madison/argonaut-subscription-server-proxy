using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProxyKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    public class CapabilitiesProcessor
    {
        public static void ProcessRequest(IApplicationBuilder appInner, string fhirServerUrl)
        {
            // **** run the proxy for this request ****

            appInner.RunProxy(async context =>
            {
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

                            // **** parse this response ****

                            FhirJsonParser parser = new FhirJsonParser();
                            CapabilityStatement capabilities = parser.Parse<CapabilityStatement>(responseContent);

                            // **** remove everything but application/fhir+json ****

                            capabilities.Format = new string[] { "application/fhir+json" };



                            // **** serialize and return ****

                            FhirJsonSerializer serializer = new FhirJsonSerializer();

                            response.Content = new StringContent(
                                serializer.SerializeToString(capabilities),
                                Encoding.UTF8,
                                "application/fhir+json");
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
    }
}
