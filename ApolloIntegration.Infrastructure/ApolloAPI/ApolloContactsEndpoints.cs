using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApolloIntegration.Infrastructure.ApolloAPI
{
    public class ApolloContactsEndpoints
    {
        private const string ApolloContactsPath = "/v1/contacts";
        public static string SearchContacts = $"{ApolloContactsPath}/search";
        
    }
}
