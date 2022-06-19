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
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _services;

        public ProductsController(IProductService service)
        {
            _services = service;

        }
        /// <summary>
        /// Retorna un listado con todas las categorias
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<ProductResponse>))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get()
        {
            return Ok(_services.GetProducts());
        }
        /// <summary>
        /// Permite consultar la información de su categoria por id
        /// </summary>
        /// <param name="request">Identificador de la categoria a buscar</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ProductResponse))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get([FromRoute] GetProductByIdRequest request)
        {
            return Ok(_services.GetProductById(idProduct: request.IdProduct));
        }


        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]

        public IActionResult Post(CreateProductRequest request)
        {
            _services.InsertProduct(request);
            return Ok();

        }

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Put(UpdateProductRequest request)
        {
            _services.UpdateProduct(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Delete([FromRoute] DeleteProductRequest request)
        {
            _services.DeleteProduct(request.IdProduct);
            return Ok();
        }

    }
}
