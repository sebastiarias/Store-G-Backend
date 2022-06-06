using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoregApp.Infrastructure.Persistence;
using StoregApp.Domain.Entities;
using StoregApp.Domain.Interfaces;
using AutoMapper;
using StoregApp.Application.Requests;

namespace StoregApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;

        
        public CustomersController(ICustomerRepository repository, IMapper mapper )
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_repository.GetCustomers());
        }

        [HttpGet("{id}") ]

        public IActionResult Get([FromRoute] GetCustomerByIdRequest request)
        {
            return Ok(_repository.GetCustomerById(request.IdCustomer));
        }

        [HttpPost] 
        
        public IActionResult Post(CreateCategoryRequest request)
        {
            var customer = _mapper.Map<Customer>(request);
            _repository.InsertCustomer(customer);
            return Ok();
        }

        [HttpPut]

        public IActionResult Put(UpdateCategoryRequest request)
        {
            var customer = _mapper.Map<Customer>(request);
            _repository.UpdateCustomer(customer);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] GetCustomerByIdRequest request)
        {
            _repository.DeleteCustomer(request.IdCustomer);         
            return Ok();

        }
    }
}
