// <copyright file="ProcessorUtils.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

extern alias fhir4;
extern alias fhir5;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Hl7.Fhir.Model;
using Microsoft.AspNetCore.Http;
using r4 = fhir4.Hl7.Fhir.Model;
using r4s = fhir4.Hl7.Fhir.Serialization;
using r5 = fhir5.Hl7.Fhir.Model;
using r5s = fhir5.Hl7.Fhir.Serialization;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    /// <summary>A processor utilities.</summary>
    public abstract class ProcessorUtils
    {
        /// <summary>The R4 serializer.</summary>
        private static r4s.FhirJsonSerializer _serializerR4 = new r4s.FhirJsonSerializer(new Hl7.Fhir.Serialization.SerializerSettings()
        {
            AppendNewLine = false,
            Pretty = false,
        });

        /// <summary>The R5 serializer.</summary>
        private static r5s.FhirJsonSerializer _serializerR5 = new r5s.FhirJsonSerializer(new Hl7.Fhir.Serialization.SerializerSettings()
        {
            AppendNewLine = false,
            Pretty = false,
        });

        /// <summary>The path split characters.</summary>
        private static readonly char[] _pathSplitChars =
        {
            '/',
            '?',
            '&',
        };

        /// <summary>Serialize an R4 C# Basic resource.</summary>
        /// <param name="response">[in,out] The response.</param>
        /// <param name="resource">The resource.</param>
        internal static void SerializeR4(ref HttpResponseMessage response, fhirCsR4.Models.Resource resource)
        {
            response.Content = new StringContent(System.Text.Json.JsonSerializer.Serialize(resource));
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
            response.StatusCode = System.Net.HttpStatusCode.OK;
        }

        /// <summary>Serialize an R4 Firely resource.</summary>
        /// <param name="response">[in,out] The response.</param>
        /// <param name="resource">The resource.</param>
        internal static void SerializeR4(ref HttpResponseMessage response, Resource resource)
        {
            response.Content = new StringContent(_serializerR4.SerializeToString(resource));
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
            response.StatusCode = System.Net.HttpStatusCode.OK;
        }

        /// <summary>Serialize an R5 C# Basic resource.</summary>
        /// <param name="response">[in,out] The response.</param>
        /// <param name="resource">The resource.</param>
        internal static void SerializeR5(ref HttpResponseMessage response, fhirCsR5.Models.Resource resource)
        {
            response.Content = new StringContent(System.Text.Json.JsonSerializer.Serialize(resource));
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
            response.StatusCode = System.Net.HttpStatusCode.OK;
        }

        /// <summary>Serialize an R5 Firely resource.</summary>
        /// <param name="response">[in,out] The response.</param>
        /// <param name="resource">The resource.</param>
        internal static void SerializeR5(ref HttpResponseMessage response, Resource resource)
        {
            response.Content = new StringContent(_serializerR5.SerializeToString(resource));
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/fhir+json");
            response.StatusCode = System.Net.HttpStatusCode.OK;
        }

        /// <summary>Query if 'request' is r 4.</summary>
        /// <param name="request">The request.</param>
        /// <returns>True if r 4, false if not.</returns>
        public static bool IsR4(HttpRequest request)
        {
            if (request == null)
            {
                return false;
            }

            if (request.Headers.ContainsKey("Accept") &&
                (request.Headers["Accept"].Count > 0))
            {
                foreach (string header in request.Headers["Accept"])
                {
                    if (header.Contains("fhirVersion=4.0", StringComparison.Ordinal))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>Gets FHIR server URL.</summary>
        /// <param name="request">The request.</param>
        /// <returns>The FHIR server URL.</returns>
#pragma warning disable CA1055 // Uri return values should not be strings
        public static string GetFhirServerUrlR5(HttpRequest request)
#pragma warning restore CA1055 // Uri return values should not be strings
        {
            if (request == null)
            {
                return Program.FhirServerUrlR5;
            }

            if (request.Headers.ContainsKey(Program._proxyHeaderKey) &&
                (request.Headers[Program._proxyHeaderKey].Count > 0))
            {
                return request.Headers[Program._proxyHeaderKey][0];
            }

            return Program.FhirServerUrlR5;
        }

        /// <summary>Gets FHIR server URL.</summary>
        /// <param name="request">The request.</param>
        /// <returns>The FHIR server URL.</returns>
#pragma warning disable CA1055 // Uri return values should not be strings
        public static string GetFhirServerUrlR4(HttpRequest request)
#pragma warning restore CA1055 // Uri return values should not be strings
        {
            if (request == null)
            {
                return Program.FhirServerUrlR4;
            }

            if (request.Headers.ContainsKey(Program._proxyHeaderKey) &&
                (request.Headers[Program._proxyHeaderKey].Count > 0))
            {
                return request.Headers[Program._proxyHeaderKey][0];
            }

            return Program.FhirServerUrlR4;
        }

        /// <summary>Query if 'request' is operation.</summary>
        /// <param name="request">          The request.</param>
        /// <param name="operationName">    [out] Name of the operation.</param>
        /// <param name="previousComponent">[out] The previous component.</param>
        /// <returns>True if operation, false if not.</returns>
        public static bool IsOperation(
            HttpRequest request,
            out string operationName,
            out string previousComponent)
        {
            operationName = string.Empty;
            previousComponent = string.Empty;

            if (request == null)
            {
                return false;
            }

            string path = request.Path.Value;

            if (path.Contains('$', StringComparison.Ordinal))
            {
                string[] components = path.Split(_pathSplitChars, StringSplitOptions.RemoveEmptyEntries);

                foreach (string component in components)
                {
                    if (component[0] == '$')
                    {
                        operationName = component;
                        return true;
                    }

                    previousComponent = component;
                }
            }

            operationName = string.Empty;
            previousComponent = string.Empty;
            return false;
        }
    }
}
