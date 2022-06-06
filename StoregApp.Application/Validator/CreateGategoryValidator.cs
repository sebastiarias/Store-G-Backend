﻿using FluentValidation;
using StoregApp.Application.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Validator
{
    public class CreateGategoryValidator : AbstractValidator<CreateCategoryRequest>
    {
        public CreateGategoryValidator()
        {
            RuleFor(X => X.NameCategory)
                .NotEmpty()
                .WithMessage("La categoría es requerida");
             
        }
    }
}
