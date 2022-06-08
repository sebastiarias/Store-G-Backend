using FluentValidation;
using StoregApp.Application.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Validator
{
    public class CreateProductValidator : AbstractValidator<CreateProductRequest>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.PriceProduct)
               .NotEmpty()
               .WithMessage("El precio del producto es requerido");

            RuleFor(x => x.NameProduct)
               .NotEmpty()
               .WithMessage("El nombre del producto es requerido");

            RuleFor(x => x.Stock)
                .NotEqual(0)
                .WithMessage("El stock debe ser superior a 0");
        }
      
    }
}
