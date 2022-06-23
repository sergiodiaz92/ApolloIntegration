using ApolloIntegration.Application.ApolloContacts.Commands.CreateApolloContact;
using ApolloIntegration.Application.ApolloKeywords.Queries.ApolloKeywordsList;
using ApolloIntegration.Application.Common.Interfaces;
using ApolloIntegration.Application.Common.Responses;
using ApolloIntegration.Application.Utils;
using ApolloIntegration.Infrastructure.ApolloAPI;
using MediatR;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace ApolloIntegration.Application.Services.ConnectAPIApolloService
{
    public class ConnectAPIApolloService : IConnectAPIApolloService
    {
        private readonly ApolloClient _apolloClient;
        private readonly IMediator _mediator;
        private readonly ApolloAPISettings _settings;
        private const int RATE_LIMIT = 5;

        public ConnectAPIApolloService(ApolloClient apolloClient, IMediator mediator, IOptions<ApolloAPISettings> settings)
        {
            _apolloClient = apolloClient;
            _mediator = mediator;
            _settings = settings.Value;
        }
        public async Task<ServiceResponse<bool>> CreateContacts()
        {
            try
            {
                int rate = 1;
                var keywords = await _mediator.Send(new ApolloKeywordsListQuery());
                foreach (var keyword in keywords)
                {
                    bool flag = false;
                    int page = 1;
                    do
                    {
                        if (rate == RATE_LIMIT) Thread.Sleep(60000);
                        var SearchContacts = await _apolloClient.GetAllContacts(_settings.apiKey,keyword.Keyword, page);
                        if (SearchContacts.Contacts == null && SearchContacts.Pagination.Page == 1)
                        {
                            break;
                        }
                        foreach (var contact in SearchContacts.Contacts)
                        {
                            CreateApolloContactCommand command = new CreateApolloContactCommand
                            {
                                ApolloId = contact.Id,
                                JsonData = JsonSerializer.Serialize(contact),
                                LastUpdatedDate = DateTime.Now.SetKindUtc()
                            };
                            await _mediator.Send(command);
                        }
                        rate++;
                        page++;
                        flag = (SearchContacts.Pagination.Page != SearchContacts.Pagination.TotalPages) && SearchContacts.Pagination.TotalPages != 0;
                    } while (flag);
                }


                return new ServiceResponse<bool>
                {
                    Data = true,
                    Message = "Contacts imported.",
                    Success = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<bool>
                {
                    Data = false,
                    Message = "Contacts might not be imported. Please check the database. Error: " + e.InnerException.Message,
                    Success = false
                };
            }

        }
    }
}
