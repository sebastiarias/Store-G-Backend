using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoregApp.Infrastructure.Persistence;
using StoregApp.Application.Entities;

namespace StoregApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private StoreGContext _context;

        public CustomersController(StoreGContext context)
        {
            _context = context; 
        }

        [HttpGet]

        public ActionResult<List<Customer>> Get()
        {
            var listCliente = _context.Customers;
            return Ok(listCliente);
        }

        [HttpGet("{id}") ]

        public ActionResult<Customer> Get(int id)
        {
            var clienteExistente = _context.Customers.FirstOrDefault(x => x.IdCustomer == id);
            if (clienteExistente is null) return NotFound();
            return Ok(clienteExistente);
        }

        [HttpPost] 
        
        public ActionResult Post(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]

        public ActionResult Put(Customer customer)
        {
            var clienteExistente = _context.Customers.FirstOrDefault(x => x.IdCustomer == customer.IdCustomer);
            if (clienteExistente is null) return NotFound();
            clienteExistente.FullNameCustomer = customer.FullNameCustomer;
            _context.SaveChanges();
            return Ok(clienteExistente);
        }

        [HttpDelete("{id}")]

        public ActionResult Delete(int id)
        {
            var clienteExistente = _context.Customers.FirstOrDefault(x => x.IdCustomer == id);
            if (clienteExistente is null) return NotFound();
            _context.Customers.Remove(clienteExistente);
            _context.SaveChanges();
            return Ok();
        }
    }
}
