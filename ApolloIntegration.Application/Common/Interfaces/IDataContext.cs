using ApolloIntegration.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApolloIntegration.Application.Common.Interfaces
{
    public interface IDataContext
    {
        public DbSet<ApolloContact>  ApolloContacts { get; set; }
        public DbSet<ApolloKeyword>  ApolloKeywords { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
