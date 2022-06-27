using ApolloIntegration.Infrastructure.Data;
using ApolloIntegration.WorkerApp.Service;

namespace ApolloIntegration.WorkerApp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWorkerServices(this IServiceCollection services)
        {
            //Hosted Services
            services.AddHostedService<ApolloAPIService>();
            services.AddHealthChecks().AddDbContextCheck<DataContext>();
            return services;
        }
    }
}
