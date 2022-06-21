using AutoMapper;
using StoregApp.Application.Interfaces;
using StoregApp.Application.Requests;
using StoregApp.Application.Responses;
using StoregApp.Domain.Entities;
using StoregApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteOrder(int idOrder)
        {
            _repository.DeleteOrder(idOrder);
        }

        public OrderResponse GetOrderById(int idOrder)
        {
            var order = _repository.GetOrderById(idOrder);
            var orderResponse = _mapper.Map<OrderResponse>(order);
            return orderResponse;
        }


        public IEnumerable<OrderResponse> GetOrders()
        {
            var order = _repository.GetOrders();
            var orderResponse = _mapper.Map<IEnumerable<OrderResponse>>(order);
            return orderResponse;
        }


        public void InsertOrder(CreateOrderRequest request)
        {
            var order = _mapper.Map<Order>(request);
            _repository.InsertOrder(order);
        }

        public void UpdateOrder(UpdateOrderRequest request)
        {
            var order = _mapper.Map<Order>(request);
            _repository.InsertOrder(order);
        }
    }
}
