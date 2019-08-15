using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Configure services.</summary>
        ///
        /// <remarks>Gino Canessa, 7/30/2019.</remarks>
        ///
        /// <param name="services">The services.</param>
        ///-------------------------------------------------------------------------------------------------

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // **** because we are loading the web host manually, we need to force it to load our local assemblies ****

            services.AddMvc().AddApplicationPart(Assembly.GetExecutingAssembly());

            // **** inject the configuration singleton into our services ****

            services.AddSingleton<IConfiguration>(Program.Configuration);

            // **** add proxy services ****

            services.AddProxy();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>This method gets called by the runtime. Use this method to configure the HTTP request pipeline.</summary>
        ///
        /// <remarks>Gino Canessa, 7/30/2019.</remarks>
        ///
        /// <param name="app">The application.</param>
        /// <param name="env">The environment.</param>
        ///-------------------------------------------------------------------------------------------------

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // **** we want to essentially disable CORS ****

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

            // **** handle specific routes we want to intercept ****

            app
                .UseWhen(
                    context => (context.Request.Path.StartsWithSegments($"{basePath}Topic") ||
                                context.Request.Path.StartsWithSegments($"/Topic")),
                    appInner => ResourceProcessors.TopicProcessor.ProcessRequest(appInner, fhirServerForwardBase)
                    )
                //.UseWhen(
                //    context => context.Request.Path.StartsWithSegments($"/Topic"),
                //    appInner => ResourceProcessors.TopicProcessor.ProcessRequest(appInner, fhirServerForwardBase)
                //    )
                //.UseWhen(
                //context => context.Request.Path.StartsWithSegments("/baseR4/Patient"),
                //appInner => ProcessPatientRequest.ProcessRequest(appInner)
                //)
                .UseWhen(
                    context => (context.Request.Path.StartsWithSegments($"{basePath}Subscription") ||
                                context.Request.Path.StartsWithSegments($"/Subscription")),
                    appInner => ResourceProcessors.SubscriptionProcessor.ProcessRequest(appInner, fhirServerForwardBase)
                    )
                .UseWhen(
                    context => (context.Request.Path.StartsWithSegments($"{basePath}Encounter") ||
                                context.Request.Path.StartsWithSegments($"{basePath}Encounter")),
                    appInner => ResourceProcessors.EncounterProcessor.ProcessRequest(appInner, fhirServerForwardBase)
                    )
                ;

            // **** default to proxying all other requests ****

            app.RunProxy(context => context
                .ForwardTo(fhirServerForwardBase)
                .Send());
        }
    }
}
