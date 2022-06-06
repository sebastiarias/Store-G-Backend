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
            CreateMap<CreateCategoryRequest, Category>();
            CreateMap<Category, CreateCategoryRequest>();

            CreateMap<UpdateCategoryRequest, Category>();
            CreateMap<Category, UpdateCategoryRequest>();
            
        }
    }
}
