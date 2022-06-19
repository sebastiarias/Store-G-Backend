using AutoMapper;
using StoregApp.Application.Interfaces;
using StoregApp.Application.Requests;
using StoregApp.Application.Responses;
using StoregApp.Domain.Entities;
using StoregApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteCustomer(int idCustomer)
        {
            _repository.DeleteCustomer(idCustomer);
        }

        public CustomerResponse GetCustomerById(int idCustomer)
        {
            var customer = _repository.GetCustomerById(idCustomer);
            var customerResponse = _mapper.Map<CustomerResponse>(customer);
            return customerResponse;
        }


        public IEnumerable<CustomerResponse> GetCustomers()
        {
            var customer = _repository.GetCustomers();
            var customerResponse = _mapper.Map<IEnumerable<CustomerResponse>>(customer);
            return customerResponse;
        }


        public void InsertCustomer(CreateCustomerRequest request)
        {
            var customer = _mapper.Map<Customer>(request);
            _repository.InsertCustomer(customer);
        }

        public void UpdateCustomer(UpdateCustomerRequest request)
        {
            var customer = _mapper.Map<Customer>(request);
            _repository.UpdateCustomer(customer);
        }

    }
}
