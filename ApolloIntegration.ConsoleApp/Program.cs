using ApolloIntegration.Application;
using ApolloIntegration.Application.Common.Interfaces;
using ApolloIntegration.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ApolloIntegration.ConsoleApp
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false);
            IConfiguration config = builder.Build();
            var services = new ServiceCollection();
            services.AddApplication();
            services.AddInfrastructure(config);

            var serviceProvider = services.BuildServiceProvider();

            var _apolloService = serviceProvider.GetService<IConnectAPIApolloService>();
            Console.WriteLine("Getting list of contacts... ");
            var apiKey = config.GetValue<string>("api_key");
            var response = await _apolloService.CreateContacts(apiKey);
            Console.WriteLine($"{response.Message}");
            Console.WriteLine("Press any key to continue...");
        }
    }
}
