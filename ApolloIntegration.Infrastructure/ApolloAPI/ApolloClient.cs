using ApolloIntegration.Application.Common.Models.ApolloAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApolloIntegration.Infrastructure.ApolloAPI
{
    public class ApolloClient : BaseHttpClient
    {
        public ApolloClient(HttpClient httpClient) : base(httpClient)
        {

        }
        public async Task<SearchContacts> GetAllContacts(string apiKey, string query, int page)
        {
            return await Post<SearchContacts>(ApolloContactsEndpoints.SearchContacts, new SearchContactsRequest
            {
                api_key = apiKey,
                page = page,
                q_keywords = query
            });
        }
    }
}
