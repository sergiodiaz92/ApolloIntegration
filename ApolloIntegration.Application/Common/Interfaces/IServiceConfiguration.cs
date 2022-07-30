using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApolloIntegration.Application.Common.Interfaces
{
    public class IServiceConfiguration
    {
        public string ServiceName { get; set; }
        public int ExecutionTimeHour { get; set; }
        public int ExecutionTimeMinutes { get; set; }
        public int ExecutionTimeSeconds { get; set; }
        public int IntervalExecutionTimeHour { get; set; }
        public int IntervalExecutionTimeMinutes { get; set; }
        public int IntervalExecutionTimeSeconds { get; set; }
    }
}
