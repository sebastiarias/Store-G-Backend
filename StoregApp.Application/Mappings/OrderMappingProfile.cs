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
    internal class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<CreateOrderRequest, Order>();
            CreateMap<Order, CreateOrderRequest>();

            CreateMap<UpdateCategoryRequest, Order>();
            CreateMap<Order, UpdateCategoryRequest>();

        }
    }
}
