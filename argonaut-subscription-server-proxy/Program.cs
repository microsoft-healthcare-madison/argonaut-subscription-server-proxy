using argonaut_subscription_server_proxy.Managers;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace argonaut_subscription_server_proxy
{
    class Program
    {
        /// <summary>A Regex pattern to filter proper base URLs for WebHost.</summary>
        private const string _regexBaseUrlMatch = @"(http[s]*:\/\/[A-Za-z0-9\.]*(:\d+)*)";

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Gets or sets the configuration.</summary>
        ///
        /// <value>The configuration.</value>
        ///-------------------------------------------------------------------------------------------------

        public static IConfiguration Configuration { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Gets or sets the REST client.</summary>
        ///
        /// <value>The REST client.</value>
        ///-------------------------------------------------------------------------------------------------

        public static HttpClient RestClient { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Main entry-point for this application.</summary>
        ///
        /// <remarks>Gino Canessa, 7/30/2019.</remarks>
        ///
        /// <param name="args">An array of command-line argument strings.</param>
        ///-------------------------------------------------------------------------------------------------

        public static void Main(string[] args)
        {
            // **** setup our configuration (command line > environment > appsettings.json) ****

            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables()
                .Build()
                ;

            // **** update configuration to make sure listen url is properly formatted ****

            Regex regex = new Regex(_regexBaseUrlMatch);
            Match match = regex.Match(Configuration["Server_Listen_Url"]);
            Configuration["Server_Listen_Url"] = match.ToString();

            // **** create our REST client ****

            RestClient = new HttpClient();

            // **** initialize managers ****

            TopicManager.Init();
            SubscriptionManager.Init();

            // **** create our web host ****

            CreateWebHostBuilder(args).Build().Run();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Creates web host builder.</summary>
        ///
        /// <remarks>Gino Canessa, 7/30/2019.</remarks>
        ///
        /// <param name="args">An array of command-line argument strings.</param>
        ///
        /// <returns>The new web host builder.</returns>
        ///-------------------------------------------------------------------------------------------------

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls(Configuration["Server_Listen_Url"])
                .UseKestrel()
                .UseStartup<Startup>()
                ;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>URL for resource identifier.</summary>
        ///
        /// <remarks>Gino Canessa, 8/2/2019.</remarks>
        ///
        /// <param name="resource">The resource.</param>
        /// <param name="id">      The identifier.</param>
        ///
        /// <returns>A string.</returns>
        ///-------------------------------------------------------------------------------------------------

        public static string UrlForResourceId(string resource, string id)
        {
            return (new Uri(
                new Uri(Program.Configuration["Server_Listen_Url"], UriKind.Absolute),
                new Uri($"baseR4/{resource}/{id}", UriKind.Relative))
                ).ToString();
        }
    }
}
