using FluentValidation;
using StoregApp.Application.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Validator
{
    internal class CreateCustomerValidator : AbstractValidator<CreateCustomerRequest>
    {
        public CreateCustomerValidator()
        {
            RuleFor(x => x.FullNameCustomer)
               .NotEmpty()
               .WithMessage("El nombre es requerido");

            RuleFor(x => x.EmailCustomer)
               .NotEmpty()
               .WithMessage("El email es requerido");

            RuleFor(x => x.Phone)
               .NotEmpty()
               .WithMessage("El teléfono es requerido");

            RuleFor(x => x.BillingAddres)
               .NotEmpty()
               .WithMessage("La dirección es requerida");

            RuleFor(x => x.Country)
               .NotEmpty()
               .WithMessage("El país es requerido");


        }
    }
}
