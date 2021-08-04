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

            // enable websockets
            app.UseWebSockets();

            // setup Subscription websockets
            app.UseMiddleware<SubscriptionWebsocketHandler>(Program.WebsocketUrl);
            app.UseMiddleware<SubscriptionWebsocketHandler>($"/r4{Program.WebsocketUrl}");
            app.UseMiddleware<SubscriptionWebsocketHandler>($"/r5{Program.WebsocketUrl}");

            // handle specific routes we want to intercept
            app
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/r4/metadata", StringComparison.Ordinal),
                    appInner => appInner.RunProxy(ResourceProcessors.CapabilitiesProcessorR4.Process))
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/r5/metadata", StringComparison.Ordinal),
                    appInner => appInner.RunProxy(ResourceProcessors.CapabilitiesProcessorR5.Process))
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/r4/SubscriptionTopic", StringComparison.Ordinal),
                    appInner => appInner.RunProxy(ResourceProcessors.SubscriptionTopicProcessorR4.Process))
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/r5/SubscriptionTopic", StringComparison.Ordinal),
                    appInner => appInner.RunProxy(ResourceProcessors.SubscriptionTopicProcessorR5.Process))
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/r4/Subscription", StringComparison.Ordinal),
                    appInner => appInner.RunProxy(ResourceProcessors.SubscriptionProcessorR4.Process))
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/r5/Subscription", StringComparison.Ordinal),
                    appInner => appInner.RunProxy(ResourceProcessors.SubscriptionProcessorR5.Process))
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/r4/Encounter", StringComparison.Ordinal),
                    appInner => appInner.RunProxy(ResourceProcessors.EncounterProcessorR4.Process))
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/r5/Encounter", StringComparison.Ordinal),
                    appInner => appInner.RunProxy(ResourceProcessors.EncounterProcessorR5.Process))

                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/r4", StringComparison.Ordinal),
                    appInner => appInner.RunProxy(ResourceProcessors.ResourceProcessorR4.Process))
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/r5", StringComparison.Ordinal),
                    appInner => appInner.RunProxy(ResourceProcessors.ResourceProcessorR5.Process))
                ;

            app.UseWhen(
                context => true,
                appInner => appInner.RunProxy(ResourceProcessors.InvalidRequestProcessor.Process));
        }
    }
}
