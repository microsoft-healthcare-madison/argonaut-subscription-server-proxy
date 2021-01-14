// <copyright file="Program.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>
using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using argonaut_subscription_server_proxy.Managers;
using argonaut_subscription_server_proxy.Services;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace argonaut_subscription_server_proxy
{
    /// <summary>A program.</summary>
    public abstract class Program
    {
        /// <summary>A Regex pattern to filter proper base URLs for WebHost.</summary>
        private const string _regexBaseUrlMatch = @"(http[s]*:\/\/[A-Za-z0-9\.]*(:\d+)*)";

        /// <summary>The proxy header key.</summary>
        public const string _proxyHeaderKey = "FHIR-Server-Url";

        /// <summary>Gets URL of the websocket.</summary>
        public const string WebsocketUrl = "/websockets";

        /// <summary>Gets or sets the configuration.</summary>
        /// <value>The configuration.</value>
        public static IConfiguration Configuration { get; set; }

        /// <summary>Gets or sets the REST client.</summary>
        /// <value>The REST client.</value>
        public static HttpClient RestClient { get; set; }

        /// <summary>Gets or sets URL of the R4 FHIR server.</summary>
        /// <value>The fhir server URL.</value>
        public static string FhirServerUrlR4 { get; set; }

        /// <summary>Gets or sets URL of the R5 FHIR server.</summary>
        /// <value>The fhir server URL.</value>
        public static string FhirServerUrlR5 { get; set; }

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
            if (!Configuration["Server_FHIR_Url_R4"].EndsWith('/'))
            {
                Configuration["Server_FHIR_Url_R4"] = Configuration["Server_FHIR_Url_R4"] + '/';
            }

            FhirServerUrlR4 = Configuration["Server_FHIR_Url_R4"];

            // update external urls to make sure the DO have trailing slashes
            if (!Configuration["Server_FHIR_Url_R5"].EndsWith('/'))
            {
                Configuration["Server_FHIR_Url_R5"] = Configuration["Server_FHIR_Url_R5"] + '/';
            }

            FhirServerUrlR5 = Configuration["Server_FHIR_Url_R5"];

            // create our REST client
            RestClient = new HttpClient();

            // initialize managers
            SubscriptionTopicManager.Init();
            SubscriptionManagerR4.Init();
            SubscriptionManagerR5.Init();
            WebsocketManager.Init();

            // create our service host
            CreateHostBuilder(args).Build().StartAsync();

            // create our web host
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>Creates host builder.</summary>
        /// <returns>The new host builder.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddHostedService<WebsocketHeartbeatService>();
                });

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
        public static string UrlForR5ResourceId(string resource, string id)
        {
            return new Uri(
                new Uri(Program.Configuration["Server_Public_Url"], UriKind.Absolute),
                new Uri($"/r5/{resource}/{id}", UriKind.Relative))
                .ToString();
        }

        /// <summary>URL for resource identifier.</summary>
        /// <param name="resource">The resource.</param>
        /// <param name="id">      The identifier.</param>
        /// <returns>A string.</returns>
        public static string UrlForR4ResourceId(string resource, string id)
        {
            return new Uri(
                new Uri(Program.Configuration["Server_Public_Url"], UriKind.Absolute),
                new Uri($"/r4/{resource}/{id}", UriKind.Relative))
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
