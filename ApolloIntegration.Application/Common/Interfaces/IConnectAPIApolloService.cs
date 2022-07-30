using ApolloIntegration.Application.ApolloContacts.Commands.CreateApolloContact;
using ApolloIntegration.Application.Common.Responses;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApolloIntegration.Application.Common.Interfaces
{
    public interface IConnectAPIApolloService
    {
        Task<ServiceResponse<bool>> CreateContacts(ILogger logger);
    }
}
