using System;
using System.Collections.Generic;

namespace StoregApp.Domain.Entities
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int IdProduct { get; set; }
        public int? SkuProduct { get; set; }
        public string? NameProduct { get; set; }
        public decimal? PriceProduct { get; set; }
        public int? IdCategory { get; set; }
        public DateTime? CreateDay { get; set; }
        public int? Stock { get; set; }

        public virtual Product? IdCategoryNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
