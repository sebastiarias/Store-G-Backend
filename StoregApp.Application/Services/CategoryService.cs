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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteCategory(int idCategory)
        {
            _repository.DeleteCategory(idCategory);
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
