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

            services.AddHostedService<Managers.FhirForwardingService>();
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

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/r4/metadata/{**components}", ResourceProcessors.CapabilitiesProcessorR4.Process);
                endpoints.Map("/r5/metadata/{**components}", ResourceProcessors.CapabilitiesProcessorR5.Process);

                endpoints.Map("/r4/SubscriptionTopic/{**components}", ResourceProcessors.SubscriptionTopicProcessorR4.Process);
                endpoints.Map("/r5/SubscriptionTopic/{**components}", ResourceProcessors.SubscriptionTopicProcessorR5.Process);

                endpoints.Map("/r4/Subscription/{**components}", ResourceProcessors.SubscriptionProcessorR4.Process);
                endpoints.Map("/r5/Subscription/{**components}", ResourceProcessors.SubscriptionProcessorR5.Process);

                endpoints.Map("/r4/Encounter/{**components}", ResourceProcessors.EncounterProcessorR4.Process);
                endpoints.Map("/r5/Encounter/{**components}", ResourceProcessors.EncounterProcessorR5.Process);

                endpoints.Map("/r4/{**components}", ResourceProcessors.ResourceProcessorR4.Process);
                endpoints.Map("/r5/{**components}", ResourceProcessors.ResourceProcessorR5.Process);
            });
        }
    }
}
