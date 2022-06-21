using StoregApp.Application.Requests;
using StoregApp.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Interfaces
{
    public interface ICustomerService
    {
        CustomerResponse GetCustomerById(int idCustomer);

        IEnumerable<CustomerResponse> GetCustomers();

        void InsertCustomer(CreateCustomerRequest customer);

        void UpdateCustomer(UpdateCustomerRequest customer);

        void DeleteCustomer(int idCustomer);
    }
}
