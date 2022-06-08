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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetCategories());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetCategoryByIdRequest request)
        {
            return Ok(_repository.GetCategoryById(idCategory: request.Id));
        }


        [HttpPost]

        public IActionResult Post(CreateCategoryRequest request)
        {
            var category = _mapper.Map<Product>(request);
            _repository.InsertCategory(category);
            return Ok(category);
            
        }

        [HttpPut]
        public IActionResult Put(UpdateCategoryRequest request)
        {
            var category = _mapper.Map<Product>(request);
            _repository.UpdateCategory(category);
            return Ok(category);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] DeleteCategoryRequest request)
        {
            _repository.DeleteCategory(request.Id);
            return Ok();
        }






    }
}
