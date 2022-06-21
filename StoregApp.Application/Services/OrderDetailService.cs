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
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository _repository;
        private readonly IMapper _mapper;

        public OrderDetailService(IOrderDetailRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteOrderDetail(int idOrderDetail)
        {
            _repository.DeleteOrderDetail(idOrderDetail);
        }

        public OrderDetailResponse GetOrderDetailById(int idOrderDetail)
        {
            var orderDetail = _repository.GetOrderDetailById(idOrderDetail);
            var orderDetailResponse = _mapper.Map<OrderDetailResponse>(orderDetail);
            return orderDetailResponse;
        }


        public IEnumerable<OrderDetailResponse> GetOrderDetails()
        {
            var orderDetail = _repository.GetOrderDetails();
            var orderDetailResponse = _mapper.Map<IEnumerable<OrderDetailResponse>>(orderDetail);
            return orderDetailResponse;
        }


        public void InsertOrderDetail(CreateOrderDetailRequest request)
        {
            var orderDetail = _mapper.Map<OrderDetail>(request);
            _repository.InsertOrderDetail(orderDetail);
        }

        public void UpdateOrderDetail(UpdateOrderDetailRequest request)
        {
            var orderDetail = _mapper.Map<OrderDetail>(request);
            _repository.InsertOrderDetail(orderDetail);
        }

    }
}
