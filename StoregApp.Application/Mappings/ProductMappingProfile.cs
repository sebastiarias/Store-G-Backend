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
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<CreateProductRequest, Product>();
            CreateMap<Product, CreateProductRequest>();

            CreateMap<UpdateProductRequest, Product>();
            CreateMap<Product, UpdateProductRequest>();

        }
    }
}
