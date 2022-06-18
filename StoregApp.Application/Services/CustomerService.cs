using AutoMapper;
using StoregApp.Application.Interfaces;
using StoregApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteCustomer(int idCustomer)
        {
            _repository.DeleteCustomer(idCustomer);
        }

        public CategoryResponse GetCategoryById(int idCategory)
        {
            var category = _repository.GetCategoryById(idCategory);
            var categoryResponse = _mapper.Map<CategoryResponse>(category);
            return categoryResponse;
        }


        public IEnumerable<CategoryResponse> GetCategories()
        {
            var category = _repository.GetCategories();
            var categoryResponse = _mapper.Map<IEnumerable<CategoryResponse>>(category);
            return categoryResponse;
        }


        public void InsertCategory(CreateCategoryRequest request)
        {
            var category = _mapper.Map<Category>(request);
            _repository.InsertCategory(category);
        }

        public void UpdateCategory(UpdateCategoryRequest request)
        {
            var category = _mapper.Map<Category>(request);
            _repository.UpdateCategory(category);
        }

    }
}
