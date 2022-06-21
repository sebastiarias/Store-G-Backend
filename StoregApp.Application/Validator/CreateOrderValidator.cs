using FluentValidation;
using StoregApp.Application.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Validator
{
    public class CreateOrderValidator : AbstractValidator<CreateOrderRequest>
    {
        public CreateOrderValidator()
        {
            RuleFor(x => x.OrderEmail)
               .NotEmpty()
               .WithMessage("El email es requerido");

            RuleFor(x => x.ShippingAddress)
               .NotEmpty()
               .WithMessage("La dirección es requerido");

            RuleFor(x => x.OrderDate)
               .NotEmpty()
               .WithMessage("La fecha es requerido");
        }

    }
}
