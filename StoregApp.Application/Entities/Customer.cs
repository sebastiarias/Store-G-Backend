using System;
using System.Collections.Generic;

namespace StoregApp.Application.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int IdCustomer { get; set; }
        public string? EmailCustomer { get; set; }
        public string? PasswordCustomer { get; set; }
        public string? FullNameCustomer { get; set; }
        public string? BillingAddres { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
