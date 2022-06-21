using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Requests
{
    public class UpdateOrderDetailRequest
    {
        public int IdDetail { get; set; }
        public int? IdProduct { get; set; }
        public decimal? Price { get; set; }
        public int? IdOrder { get; set; }
        public int? Quantity { get; set; }
    }
}
