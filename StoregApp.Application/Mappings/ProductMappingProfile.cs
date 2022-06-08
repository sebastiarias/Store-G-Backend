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
            CreateMap<CreateProductRequest, Category>();
            CreateMap<Category, CreateProductRequest>();

            CreateMap<UpdateProductRequest, Category>();
            CreateMap<Category, UpdateProductRequest>();

        }
    }
}
