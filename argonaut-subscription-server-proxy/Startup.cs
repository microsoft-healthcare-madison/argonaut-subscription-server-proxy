using System;
using System.Collections.Generic;
using System.Linq;
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
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddProxy();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            string fhirServerUrl = Program.Configuration.GetValue<string>("FHIR_Server_Url");

            // **** handle specific routes we want to intercept ****

            app.UseWhen(
                context => context.Request.Path.StartsWithSegments("/baseR4/Topic"),
                appInner => ResourceProcessors.TopicProcessor.ProcessRequest(appInner, fhirServerUrl)
                )
                //.UseWhen(
                //context => context.Request.Path.StartsWithSegments("/baseR4/Patient"),
                //appInner => ProcessPatientRequest.ProcessRequest(appInner)
                //)
                //.UseWhen(
                //context => context.Request.Path.StartsWithSegments("/baseR4/Subscription"),
                //appInner => ProcessSubscriptionRequest.ProcessRequest(appInner)
                //)
                ;

            // **** default to proxying all other requests ****

            app.RunProxy(context => context
                .ForwardTo(fhirServerUrl)
                .Send());
        }
    }
}
