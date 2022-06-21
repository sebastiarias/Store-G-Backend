using AutoMapper;
using StoregApp.Application.Requests;
using StoregApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Mappings
{
    public class OrderDetailMappingProfile : Profile
    {
        public OrderDetailMappingProfile()
        {
            CreateMap<CreateOrderDetailRequest, OrderDetail>();
            CreateMap<OrderDetail, CreateOrderDetailRequest>();

            CreateMap<UpdateOrderDetailRequest, OrderDetail>();
            CreateMap<OrderDetail, UpdateOrderDetailRequest>();
        }
       
    }
}
