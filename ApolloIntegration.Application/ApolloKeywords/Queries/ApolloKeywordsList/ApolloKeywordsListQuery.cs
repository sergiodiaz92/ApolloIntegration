using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApolloIntegration.Application.ApolloKeywords.Queries.ApolloKeywordsList
{
    public class ApolloKeywordsListQuery : IRequest<List<GetApolloKeywordDto>>
    {
    }
}
