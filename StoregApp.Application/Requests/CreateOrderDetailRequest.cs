﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Requests
{
    public class CreateOrderDetailRequest
    {
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
