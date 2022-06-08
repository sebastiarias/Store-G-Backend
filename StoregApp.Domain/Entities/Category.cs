using System;
using System.Collections.Generic;

namespace StoregApp.Domain.Entities
{
    public partial class Product
    {
        public Product()
        {
            Products = new HashSet<Product>();
        }

        public int IdCategory { get; set; } 
        public string? NameCategory { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
