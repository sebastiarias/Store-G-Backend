﻿using FluentValidation;
using StoregApp.Application.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Validator
{
    public class UpdateOrderDetailValidator : AbstractValidator<UpdateOrderDetailRequest>
    {
        public UpdateOrderDetailValidator()
        {

        }
    }
}
