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
    public class ApolloContactMap : IEntityTypeConfiguration<ApolloContact>
    {
        public void Configure(EntityTypeBuilder<ApolloContact> builder)
        {
            builder.ToTable("ApolloContact");
            builder.Property(b => b.JsonData).HasColumnType("jsonb");
        }
    }
}
