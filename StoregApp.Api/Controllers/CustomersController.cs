using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoregApp.Infrastructure.Persistence;
using AutoMapper;
using StoregApp.Application.Requests;
using StoregApp.Domain.Interfaces;
using StoregApp.Domain.Entities;
using StoregApp.Application.Interfaces;
using StoregApp.Application.Responses;
using System.Net;
using Microsoft.AspNetCore.Authorization;

namespace StoregApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [Authorize]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _services;


        public CustomersController(ICustomerService service)
        {
            _services = service;

        }
        /// <summary>
        /// Retorna un listado con todas las categorias
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<CustomerResponse>))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get()
        {
            return Ok(_services.GetCustomers());
        }
        /// <summary>
        /// Permite consultar la información de su categoria por id
        /// </summary>
        /// <param name="request">Identificador de la categoria a buscar</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(CustomerResponse))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get([FromRoute] GetCustomerByIdRequest request)
        {
            return Ok(_services.GetCustomerById(idCustomer: request.IdCustomer));
        }


        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]

        public IActionResult Post(CreateCustomerRequest request)
        {
            _services.InsertCustomer(request);
            return Ok();

        }

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Put(UpdateCustomerRequest request)
        {
            _services.UpdateCustomer(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Delete([FromRoute] DeleteCustomerRequest request)
        {
            _services.DeleteCustomer(request.Id);
            return Ok();
        }
    }
}
