using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApolloIntegration.Domain.Entities
{
    public class ApolloContact
    {
        public int id { get; set; }
        public string ApolloId { get; set; }
        public string JsonData { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
