using ApolloIntegration.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApolloIntegration.Infrastructure.ApolloAPI
{
    public class ApolloAPISettings : IServiceConfiguration
    {
        public string apiKey { get; set; }
        public int requestRateLimitPerMinute { get; set; }
        public double sleepTimeSeconds { get; set; }
    }
}
