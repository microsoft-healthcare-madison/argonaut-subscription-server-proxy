// <copyright file="Program.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>
using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using argonaut_subscription_server_proxy.Managers;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace argonaut_subscription_server_proxy
{
    /// <summary>A program.</summary>
    public abstract class Program
    {
        /// <summary>A Regex pattern to filter proper base URLs for WebHost.</summary>
        private const string _regexBaseUrlMatch = @"(http[s]*:\/\/[A-Za-z0-9\.]*(:\d+)*)";

        /// <summary>The proxy header key.</summary>
        public const string _proxyHeaderKey = "FHIR-Server-Url";

        /// <summary>Gets or sets the configuration.</summary>
        /// <value>The configuration.</value>
        public static IConfiguration Configuration { get; set; }

        /// <summary>Gets or sets the REST client.</summary>
        /// <value>The REST client.</value>
        public static HttpClient RestClient { get; set; }

        /// <summary>Gets or sets URL of the fhir server.</summary>
        /// <value>The fhir server URL.</value>
        public static string FhirServerUrl { get; set; }

        /// <summary>Gets or sets URL of the public.</summary>
        /// <value>The public URL.</value>
        public static string PublicUrl { get; set; }

        /// <summary>Main entry-point for this application.</summary>
        /// <param name="args">An array of command-line argument strings.</param>
        public static void Main(string[] args)
        {
            // setup our configuration (command line > environment > appsettings.json)
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables()
                .Build()
                ;

            // update configuration to make sure listen url is properly formatted
            Regex regex = new Regex(_regexBaseUrlMatch);
            Match match = regex.Match(Configuration["Server_Public_Url"]);
            Configuration["Server_Public_Url"] = match.ToString();
            PublicUrl = match.ToString();

            match = regex.Match(Configuration["Server_Internal_Url"]);
            Configuration["Server_Internal_Url"] = match.ToString();

            // update external urls to make sure the DO have trailing slashes
            if (!Configuration["Server_FHIR_Url"].EndsWith('/'))
            {
                Configuration["Server_FHIR_Url"] = Configuration["Server_FHIR_Url"] + '/';
            }

            FhirServerUrl = Configuration["Server_FHIR_Url"];

            // create our REST client
            RestClient = new HttpClient();

            // initialize managers
            SubscriptionTopicManager.Init();
            SubscriptionManager.Init();
            WebsocketManager.Init();

            // create our web host
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>Creates web host builder.</summary>
        /// <param name="args">An array of command-line argument strings.</param>
        /// <returns>The new web host builder.</returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls(Configuration["Server_Internal_Url"])
                .UseKestrel()
                .UseStartup<Startup>()
                ;

        /// <summary>URL for resource identifier.</summary>
        /// <param name="resource">The resource.</param>
        /// <param name="id">      The identifier.</param>
        /// <returns>A string.</returns>
        public static string UrlForResourceId(string resource, string id)
        {
            return new Uri(
                new Uri(Program.Configuration["Server_Public_Url"], UriKind.Absolute),
                new Uri($"{resource}/{id}", UriKind.Relative))
                .ToString();
        }

        /// <summary>Resource identifier from reference.</summary>
        /// <param name="reference">The reference.</param>
        /// <returns>A string.</returns>
        public static string ResourceIdFromReference(string reference)
        {
            if (string.IsNullOrEmpty(reference))
            {
                return string.Empty;
            }

            // check for URL
            if (reference.Contains('/'))
            {
                return reference.Substring(reference.LastIndexOf('/') + 1);
            }

            // assume this is the reference
            return reference;
        }
    }
}
