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
    public class CustomersMappingProfile : Profile
    {
        public CustomersMappingProfile()
        {
            CreateMap<CreateCustomerRequest, Customer>();
            CreateMap<Customer, CreateCustomerRequest>();

            CreateMap<UpdateCustomerRequest, Customer>();
            CreateMap<Customer, UpdateCustomerRequest>();
        }
    }
}
