using System;
using System.Collections.Generic;

namespace StoregApp.Domain.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int IdOrder { get; set; }
        public int? IdCustomer { get; set; }
        public string? ShippingAddress { get; set; }
        public string? OrderEmail { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool? OrderStatus { get; set; }

        public virtual Customer? IdCustomerNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
