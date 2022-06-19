using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoregApp.Application.Interfaces;
using StoregApp.Application.Requests;
using StoregApp.Application.Responses;
using StoregApp.Domain.Entities;
using StoregApp.Domain.Interfaces;
using StoregApp.Infrastructure.Persistence;
using System.Net;

namespace StoregApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("aplication/json")]

    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _services;

        public OrdersController(IOrderService service)
        {
            _services = service;

        }
        /// <summary>
        /// Retorna un listado con todas las categorias
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<OrderResponse>))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get()
        {
            return Ok(_services.GetOrders());
        }
        /// <summary>
        /// Permite consultar la información de su categoria por id
        /// </summary>
        /// <param name="request">Identificador de la categoria a buscar</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(OrderResponse))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get([FromRoute] GetOrderByIdRequest request)
        {
            return Ok(_services.GetOrderById(idOrder: request.IdOrder));
        }


        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]

        public IActionResult Post(CreateOrderRequest request)
        {
            _services.InsertOrder(request);
            return Ok();

        }

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Put(UpdateOrderRequest request)
        {
            _services.UpdateOrder(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Delete([FromRoute] DeleteOrderRequest request)
        {
            _services.DeleteOrder(request.IdOrder);
            return Ok();
        }
    }

}
