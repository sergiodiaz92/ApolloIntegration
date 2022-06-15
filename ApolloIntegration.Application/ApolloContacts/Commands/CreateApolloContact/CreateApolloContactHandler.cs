using ApolloIntegration.Application.Common.Interfaces;
using ApolloIntegration.Domain.Entities;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApolloIntegration.Application.ApolloContacts.Commands.CreateApolloContact
{
    public class CreateApolloContactHandler : IRequestHandler<CreateApolloContactCommand, int>
    {
        private readonly IDataContext _context;
        private readonly IMapper _mapper;

        public CreateApolloContactHandler(IDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateApolloContactCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<ApolloContact>(request);
            var dbEntity = await _context.ApolloContacts.FirstOrDefaultAsync(ac => ac.ApolloId == entity.ApolloId);
            if (dbEntity != null)
            {
                dbEntity.JsonData = entity.JsonData;
                dbEntity.LastUpdatedDate = entity.LastUpdatedDate;
            }
            else
            {
                await _context.ApolloContacts.AddAsync(entity);
            }
            await _context.SaveChangesAsync(cancellationToken);
            return entity.id;
        }
    }
}
