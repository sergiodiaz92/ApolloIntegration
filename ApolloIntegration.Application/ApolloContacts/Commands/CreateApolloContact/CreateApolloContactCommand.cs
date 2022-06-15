using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApolloIntegration.Application.ApolloContacts.Commands.CreateApolloContact
{
    public class CreateApolloContactCommand : IRequest<int>
    {
        public string ApolloId { get; set; }
        public string JsonData { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
