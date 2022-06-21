using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Requests
{
    public class CreateOrderRequest
    {
        public string? ShippingAddress { get; set; }
        public string? OrderEmail { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool? OrderStatus { get; set; }
    }
}
