using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApolloIntegration.Application.Common.Models.ApolloAPI
{
    public class SearchContactsRequest
    {
        public string api_key { get; set; }
        public string q_keywords { get; set; } = "Partner";
        public string sort_by_field { get; set; } = "contact_last_activity_date";
        public string sort_ascending { get; set; } = "false";
        public int page { get; set; } = 1;
        public int per_page { get; set; } = 25;
    }
}
