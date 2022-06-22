using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoregApp.Infrastructure.Persistence;
using StoregApp.Domain.Entities;
using StoregApp.Domain.Interfaces;
using AutoMapper;
using StoregApp.Application.Requests;
using StoregApp.Application.Interfaces;
using System.Net;
using StoregApp.Application.Responses;
using Microsoft.AspNetCore.Authorization;

namespace StoregApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [Authorize]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _services;

        public CategoriesController(ICategoryService service)
        {
            _services = service;

        }
        /// <summary>
        /// Retorna un listado con todas las categorias
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<CategoryResponse>))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get()
        {
            return Ok(_services.GetCategories());
        }
        /// <summary>
        /// Permite consultar la información d esu categoria por id
        /// </summary>
        /// <param name="request">Identificador de la categoria a buscar</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(CategoryResponse))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get([FromRoute] GetCategoryByIdRequest request)
        {
            return Ok(_services.GetCategoryById(idCategory: request.Id));
        }


        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]

        public IActionResult Post(CreateCategoryRequest request)
        {
            _services.InsertCategory(request);
            return Ok();
            
        }

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Put(UpdateCategoryRequest request)
        {
            _services.UpdateCategory(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Delete([FromRoute] DeleteCategoryRequest request)
        {
            _services.DeleteCategory(request.Id);
            return Ok();
        }






    }
}
