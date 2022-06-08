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
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<CreateCategoryRequest, Product>();
            CreateMap<Product, CreateCategoryRequest>();

            CreateMap<UpdateCategoryRequest, Product>();
            CreateMap<Product, UpdateCategoryRequest>();
            
        }
    }
}
