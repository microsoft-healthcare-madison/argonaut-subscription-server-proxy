using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using argonaut_subscription_server_proxy.Managers;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace argonaut_subscription_server_proxy
{
    public class Program
    {

        public static IConfiguration Configuration { get; set; }


        public static void Main(string[] args)
        {
            // **** start the topic manager ****

            TopicManager.Init();

            // **** start the subscription manager ****

            SubscriptionManager.Init();

            // **** create our web host ****

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((webHostBuilderContext, configurationbuilder) =>
                {
                    var environment = webHostBuilderContext.HostingEnvironment;
                    configurationbuilder.AddJsonFile("appsettings.json", optional: true);
                    configurationbuilder.AddEnvironmentVariables();
                    Configuration = configurationbuilder.Build();
                })
                .UseStartup<Startup>();
    }
}
