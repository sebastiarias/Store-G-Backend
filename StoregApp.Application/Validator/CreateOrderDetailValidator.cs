using FluentValidation;
using StoregApp.Application.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Validator
{
    public class CreateOrderDetailValidator : AbstractValidator<CreateOrderDetailRequest>
    {
        public CreateOrderDetailValidator()
        {
            RuleFor(x => x.Quantity)
                .NotEmpty()
                .WithMessage("La cantidad es requerida");

            RuleFor(x => x.Price)
                .NotEqual(0)
                .WithMessage("El precio debe ser superior a 0");

        }

    }
}
