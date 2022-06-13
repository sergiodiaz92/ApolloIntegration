using ApolloIntegration.Application;
using ApolloIntegration.Application.Common.Interfaces;
using ApolloIntegration.Infrastructure;
using ApolloIntegration.Infrastructure.ApolloAPI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace ApolloIntegration.ConsoleApp
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            var _apolloService = host.Services.GetRequiredService<IConnectAPIApolloService>();
            var response = await _apolloService.CreateContacts();
            Console.WriteLine($"{response.Message}");
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .UseContentRoot(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
            .ConfigureServices((hostContext, services) =>
            {
                services.AddApplication();
                services.AddInfrastructure(hostContext.Configuration);
            });
    }
}
