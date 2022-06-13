using System;
using ApolloIntegration.Application.Common.Interfaces;
using ApolloIntegration.Application.Services.ConnectAPIApolloService;
using ApolloIntegration.Infrastructure.ApolloAPI;
using ApolloIntegration.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApolloIntegration.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options => 
            options.UseNpgsql(
                configuration.GetConnectionString("PostgresConnection"),
                b=>b.MigrationsAssembly(typeof(DataContext).Assembly.FullName)));

            services.AddScoped<IDataContext>(provider => provider.GetService<DataContext>());

            services.AddHttpClient<ApolloClient>("ApolloClient", config =>
            {
                config.BaseAddress = new Uri(configuration.GetSection("ApolloAPI").GetSection("baseUri").Value);
                config.Timeout = TimeSpan.FromSeconds(30);
            });

            services.AddScoped<IConnectAPIApolloService, ConnectAPIApolloService>();
            services.Configure<ApolloAPISettings>(options => configuration.GetSection("ApolloAPI").Bind(options)); 
            return services;
        }
    }
}
