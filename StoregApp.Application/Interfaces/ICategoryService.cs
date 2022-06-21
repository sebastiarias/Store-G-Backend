using StoregApp.Application.Requests;
using StoregApp.Application.Responses;
using StoregApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Interfaces
{
    public interface ICategoryService
    {
        CategoryResponse GetCategoryById(int idCategory);

        IEnumerable<CategoryResponse> GetCategories();

        void InsertCategory(CreateCategoryRequest category);

        void UpdateCategory(UpdateCategoryRequest category);

        void DeleteCategory(int idCategory);
    }
}
