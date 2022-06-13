using ApolloIntegration.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApolloIntegration.Infrastructure.Data.Mappings
{
    public class ApolloKeywordMap : IEntityTypeConfiguration<ApolloKeyword>
    {
        public void Configure(EntityTypeBuilder<ApolloKeyword> builder)
        {
            builder.ToTable("ApolloKeyword");
        }
    }
}
