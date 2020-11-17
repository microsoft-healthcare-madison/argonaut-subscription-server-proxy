// <copyright file="Startup.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>
using System;
using System.Net.Http;
using System.Reflection;
using argonaut_subscription_server_proxy.Handlers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProxyKit;

namespace argonaut_subscription_server_proxy
{
    /// <summary>A startup.</summary>
    public class Startup
    {
        /// <summary>Configure services.</summary>
        /// <param name="services">The services.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // because we are loading the web host manually, we need to force it to load our local assemblies
            services.AddMvc().AddApplicationPart(Assembly.GetExecutingAssembly());

            // inject the configuration singleton into our services
            services.AddSingleton<IConfiguration>(Program.Configuration);

            // configure automatic decompression for our proxy
            HttpMessageHandler CreatePrimaryHandler()
            {
                return new HttpClientHandler
                {
                    AutomaticDecompression = System.Net.DecompressionMethods.GZip |
                        System.Net.DecompressionMethods.Deflate,
                };
            }

            // add proxy services
            services.AddProxy(httpClientBuilder =>
                httpClientBuilder.ConfigurePrimaryHttpMessageHandler(CreatePrimaryHandler));
        }

        /// <summary>This method gets called by the runtime. Use this method to configure the HTTP request pipeline.</summary>
        /// <param name="app">The application.</param>
        /// <param name="env">The environment.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // we want to essentially disable CORS
            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            string fhirServerUrl = Program.Configuration.GetValue<string>("Server_FHIR_Url");
            Uri fhirServerUri = new Uri(fhirServerUrl);
            string basePath = fhirServerUri.AbsolutePath;
            string fhirServerForwardBase = fhirServerUrl.Replace(basePath, string.Empty, StringComparison.OrdinalIgnoreCase);

            if (!basePath.EndsWith('/'))
            {
                basePath += "/";
            }

            // enable websockets
            app.UseWebSockets();

            // setup Subscription websockets
            app.UseMiddleware<SubscriptionWebsocketHandler>("/subscriptions/websocketurl");

            // handle specific routes we want to intercept
            app
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/metadata", StringComparison.Ordinal),
                    appInner => appInner.RunProxy(ResourceProcessors.CapabilitiesProcessor.Process))
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/SubscriptionTopic", StringComparison.Ordinal),
                    appInner => ResourceProcessors.SubscriptionTopicProcessor.ProcessRequest(appInner, fhirServerUrl))
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/Subscription", StringComparison.Ordinal),
                    appInner => appInner.RunProxy(ResourceProcessors.SubscriptionProcessor.Process))
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/Encounter", StringComparison.Ordinal),
                    appInner => appInner.RunProxy(ResourceProcessors.EncounterProcessor.Process))

                // .UseWhen(
                //    context => context.Request.Path.StartsWithSegments($"/Basic", StringComparison.Ordinal),
                //    appInner => ResourceProcessors.BasicProcessor.ProcessRequest(appInner, fhirServerUrl))
                ;

            app.UseWhen(
                context => true,
                appInner => appInner.RunProxy(ResourceProcessors.ResourceProcessor.Process));

            // default to proxying all other requests
            //app.RunProxy(context => context
            //    .ForwardTo(fhirServerUrl)
            //    .Send());
        }
    }
}
