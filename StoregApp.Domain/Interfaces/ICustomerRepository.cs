using StoregApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int idCustomer);

        IEnumerable<Customer> GetCustomers();

        void InsertCustomer(Customer customer);

        void UpdateCustomer(Customer customer);

        void DeleteCustomer(int idCustomer);        
   
    }
}
