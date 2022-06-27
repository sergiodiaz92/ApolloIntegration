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
        public double PeriodTimerSeconds { get; set; }
        public int RunsPerDay { get; set; }
    }
}
