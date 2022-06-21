using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Requests
{
    public class CreateCustomerRequest
    {
        public string? EmailCustomer { get; set; }
        public string? PasswordCustomer { get; set; }
        public string? FullNameCustomer { get; set; }
        public string? BillingAddres { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }

    }
}
