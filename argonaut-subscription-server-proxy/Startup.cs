using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using argonaut_subscription_server_proxy.Handlers;
using argonaut_subscription_server_proxy.ResourceProcessors;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProxyKit;

namespace argonaut_subscription_server_proxy
{
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
                        System.Net.DecompressionMethods.Deflate
                };
            }  

            // add proxy services

            services.AddProxy(httpClientBuilder => 
                httpClientBuilder.ConfigurePrimaryHttpMessageHandler(CreatePrimaryHandler)
                );
        }

        /// <summary>This method gets called by the runtime. Use this method to configure the HTTP request pipeline.</summary>
        /// <param name="app">The application.</param>
        /// <param name="env">The environment.</param>
        [Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // we want to essentially disable CORS

            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                //.AllowCredentials()
                );

            string fhirServerUrl = Program.Configuration.GetValue<string>("Server_FHIR_Url");
            Uri fhirServerUri = new Uri(fhirServerUrl);
            string basePath = fhirServerUri.AbsolutePath;
            string fhirServerForwardBase = fhirServerUrl.Replace(basePath, "");
            
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
                    context => context.Request.Path.StartsWithSegments($"/metadata"),
                    appInner => ResourceProcessors.CapabilitiesProcessor.ProcessRequest(appInner, fhirServerUrl)
                    )
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/Topic"),
                    appInner => ResourceProcessors.TopicProcessor.ProcessRequest(appInner, fhirServerUrl)
                    )
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/Subscription"),
                    appInner => ResourceProcessors.SubscriptionProcessor.ProcessRequest(appInner, fhirServerUrl)
                    )
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/Encounter"),
                    appInner => ResourceProcessors.EncounterProcessor.ProcessRequest(appInner, fhirServerUrl)
                    )
                .UseWhen(
                    context => context.Request.Path.StartsWithSegments($"/Basic"),
                    appInner => ResourceProcessors.BasicProcessor.ProcessRequest(appInner, fhirServerUrl)
                    )
                ;

            app.UseWhen(
                context => true,
                appInner => ResourceProcessors.DefaultProcessor.ProcessRequest(appInner, fhirServerUrl)
                );

            //// default to proxying all other requests

            //app.RunProxy(context => context
            //    .ForwardTo(fhirServerUrl)
            //    .Send());

        }
    }
}
