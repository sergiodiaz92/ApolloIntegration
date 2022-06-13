using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApolloIntegration.Application.ApolloContacts.Commands.CreateApolloContact
{
    public class CreateApolloContactValidator : AbstractValidator<CreateApolloContactCommand>
    {
        public CreateApolloContactValidator()
        {
            RuleFor(e => e.ApolloId).NotEmpty();
            RuleFor(e => e.JsonData).NotEmpty();
        }
    }
}
