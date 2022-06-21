using System;
using System.Collections.Generic;

namespace StoregApp.Domain.Entities
{
    public partial class OrderDetail
    {
        public int IdDetail { get; set; }
        public int? IdProduct { get; set; }
        public decimal? Price { get; set; }
        public int? IdOrder { get; set; }
        public int? Quantity { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
