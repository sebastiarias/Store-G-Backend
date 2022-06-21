using Microsoft.AspNetCore.Mvc;
using StoregApp.Domain.Entities;
using StoregApp.Domain.Interfaces;
using StoregApp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private StoreGContext _context;

        public CustomerRepository(StoreGContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers;
        }

        public Customer GetCustomerById(int idCustomer)
        {
            return _context.Customers.FirstOrDefault(x=> x.IdCustomer == idCustomer);
        }

        public void InsertCustomer(Customer customer)
        {
            var clienteExistente = _context.Customers.FirstOrDefault(x => x.IdCustomer == customer.IdCustomer);
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            var clienteExistente = _context.Customers.FirstOrDefault(x => x.IdCustomer == customer.IdCustomer);
            clienteExistente.IdCustomer = customer.IdCustomer;
            clienteExistente.FullNameCustomer = customer.FullNameCustomer;
            clienteExistente.BillingAddres = customer.BillingAddres;
            clienteExistente.Country = customer.Country;
            _context.Customers.Remove(customer);
            _context.SaveChanges();            
        }

        public void DeleteCustomer(int idCustomer)
        {
            var clienteExistente = _context.Customers.FirstOrDefault(x => x.IdCustomer == idCustomer);
            _context.Customers.Remove(clienteExistente);
            _context.SaveChanges();
        }

    }

}






       
        

