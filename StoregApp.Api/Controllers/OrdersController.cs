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

    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public OrdersController(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_repository.GetOrders());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetOrderByIdRequest request)
        {
            return Ok(_repository.GetOrderById(request.IdOrder));
        }

        [HttpPost]
        public IActionResult Post(CreateOrderDetailRequest request)
        {
            var order = _mapper.Map<Order>(request);
            _repository.InsertOrder(order);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(CreateOrderDetailRequest request)
        {
            var order = _mapper.Map<Order>(request);
            _repository.UpdateOrder(order);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] DeleteOrderRequest request)
        {
            _repository.DeleteOrder(request.IdOrder);
            return Ok();
        }
    }

}
