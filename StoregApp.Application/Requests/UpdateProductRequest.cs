using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Requests
{
    public class UpdateProductRequest
    {
        public int IdProduct { get; set; }
        public int? SkuProduct { get; set; }
        public string? NameProduct { get; set; }
        public decimal? PriceProduct { get; set; }
        public int? IdCategory { get; set; }
        public DateTime? CreateDay { get; set; }
        public int? Stock { get; set; }
    }
}
