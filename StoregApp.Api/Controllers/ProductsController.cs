using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoregApp.Application.Requests;
using StoregApp.Domain.Entities;
using StoregApp.Domain.Interfaces;
using StoregApp.Infrastructure.Persistence;

namespace StoregApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductsController(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_repository.GetProducts());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetProductByIdRequest request)
        {
            return Ok(_repository.GetProductById(request.IdProduct));
        }

        [HttpPost]
        public IActionResult Post(CreateProductRequest request)
        {
            var product = _mapper.Map<Product>(request);
            _repository.InsertProduct(product);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(CreateProductRequest request)
        {
            var product = _mapper.Map<Product>(request);
            _repository.UpdateProduct(product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] DeleteProductRequest request)
        {
            _repository.DeleteProduct(request.IdProduct);
            return Ok();
        }

    }
}
