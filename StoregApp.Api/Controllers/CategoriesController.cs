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

        [HttpPost]

        public IActionResult Post(CreateCategoryRequest request)
        {
            var category = _mapper.Map<Category>(request);
            _repository.AddCategory(category);
            return Ok(category);
            
        }

        public IActionResult Put(UpdateCategoryRequest request)
        {
            var category = _mapper.Map<Category>(request);
            _repository.UpdateCategory(category);
            return Ok(category);
        }




    }
}
