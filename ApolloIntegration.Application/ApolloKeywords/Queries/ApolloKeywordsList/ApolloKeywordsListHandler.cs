using ApolloIntegration.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApolloIntegration.Application.ApolloKeywords.Queries.ApolloKeywordsList
{
    public class ApolloKeywordsListHandler : IRequestHandler<ApolloKeywordsListQuery, List<GetApolloKeywordDto>>
    {
        private readonly IDataContext _dataContext;
        private readonly IMapper _mapper;

        public ApolloKeywordsListHandler(IDataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task<List<GetApolloKeywordDto>> Handle(ApolloKeywordsListQuery request, CancellationToken cancellationToken)
        {
            var dbKeywords = await _dataContext.ApolloKeywords.ToListAsync();
            return _mapper.Map<List<GetApolloKeywordDto>>(dbKeywords);
        }
    }
}
