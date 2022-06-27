using ApolloIntegration.Application.Common.Interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApolloIntegration.Application.Common.Models.Base
{
    public abstract class BaseService<T> : BackgroundService, IHostedService, IDisposable where T : IServiceConfiguration
    {
        private int executionCount = 0;
        private DateTime lastRunDate = DateTime.Now;

        private Timer _timer;

        private bool isProcessing = false;

        protected readonly ILogger _logger;
        protected readonly T config;
        public BaseService(ILogger logger,
            IOptions<IServiceConfiguration> options)
        {
            _logger = logger;
            this.config = (T)options.Value;
        }
        public override void Dispose()
        {
            _timer?.Dispose();
        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Service for {0} Started", this.config.ServiceName);

            return this.ExecuteAsync(cancellationToken);
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _timer = new Timer(RunService, null, TimeSpan.FromSeconds(10), TimeSpan.FromSeconds(config.PeriodTimerSeconds));
            return Task.CompletedTask;
        }
        protected abstract Task ExecuteBackgroundService();

        private void RunService(object state)
        {
            if (executionCount < config.RunsPerDay && lastRunDate.Date == DateTime.Now.Date)
            {
                ExecutingService();
            }
            else if(executionCount >= config.RunsPerDay && lastRunDate.Date != DateTime.Now.Date)
            {
                executionCount = 0;
                ExecutingService();
            }
        }
        private void ExecutingService()
        {
            var count = Interlocked.Increment(ref executionCount);
            lastRunDate = DateTime.Now;

            _logger.LogInformation("Service for {0} is Running. Count: {1}", this.config.ServiceName, count);

            if (!this.isProcessing)
            {
                _ = this.ExecuteBackgroundService();
            }
        }
    }
}
