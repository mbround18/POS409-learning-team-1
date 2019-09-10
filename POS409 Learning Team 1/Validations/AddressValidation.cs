using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS409_Learning_Team_1.Validations
{
    class AddressValidation : AbstractValidator<Entities.Address>
    {
        public AddressValidation()
        {
            RuleFor(addr => addr.Address1).NotNull().NotEmpty();
        }
    }
}
