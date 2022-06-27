using ApolloIntegration.Application.Common.Interfaces;
using ApolloIntegration.Application.Common.Models.Base;
using ApolloIntegration.Infrastructure.ApolloAPI;
using Microsoft.Extensions.Options;

namespace ApolloIntegration.WorkerApp.Service
{
    public class ApolloAPIService : BaseService<ApolloAPISettings>
    {
        private IServiceProvider _serviceProvider;
        private readonly IConnectAPIApolloService _apolloApi;

        public ApolloAPIService(
            ILogger<ApolloAPIService> logger,
            IOptions<ApolloAPISettings> options,
            IServiceProvider serviceProvider
        ) : base(logger, options)
        {
            _serviceProvider = serviceProvider;
            _apolloApi = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<IConnectAPIApolloService>();
        }
        protected override async Task ExecuteBackgroundService()
        {
            var response = await _apolloApi.CreateContacts();
            if (!response.Success)
            {
                _logger.LogError("Error in {0}. StackTrace: {1}", this.config.ServiceName, response.Message);
            }
            _logger.LogInformation("Service for {0} completed. Message: {1}", this.config.ServiceName,response.Message);
        }
    }
}
