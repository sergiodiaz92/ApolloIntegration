using ApolloIntegration.Application.ApolloContacts.Commands.CreateApolloContact;
using ApolloIntegration.Application.ApolloKeywords.Queries.ApolloKeywordsList;
using ApolloIntegration.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApolloIntegration.Application.Dtos
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateApolloContactCommand, ApolloContact>();
            CreateMap<ApolloKeyword, GetApolloKeywordDto>();
        }
    }
}
