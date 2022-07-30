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
            _timer = StartTimer(new TimeSpan(config.ExecutionTimeHour, config.ExecutionTimeMinutes, config.ExecutionTimeSeconds), new TimeSpan(config.IntervalExecutionTimeHour, config.IntervalExecutionTimeMinutes, config.IntervalExecutionTimeSeconds));
            return Task.CompletedTask;
        }
        protected abstract Task ExecuteBackgroundService();

        private void RunService(object state)
        {
            _logger.LogInformation("Service for {0} is Running.", this.config.ServiceName);

            if (!this.isProcessing)
            {
                _ = this.ExecuteBackgroundService();
            }
        }
        protected Timer StartTimer(TimeSpan scheduledRunTime, TimeSpan timeBetweenEachRun)
        {
            // Initialize timer
            double current = DateTime.Now.TimeOfDay.TotalMilliseconds;
            double scheduledTime = scheduledRunTime.TotalMilliseconds;
            double intervalPeriod = timeBetweenEachRun.TotalMilliseconds;

            double firstExecution = current > scheduledTime ? intervalPeriod - (current - scheduledTime) : scheduledTime - current;

            TimerCallback callback = new TimerCallback(RunService);

            return new Timer(callback, null, Convert.ToInt32(firstExecution), Convert.ToInt32(intervalPeriod));

        }
    }
}
