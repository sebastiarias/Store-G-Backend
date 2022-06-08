using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoregApp.Domain.Entities;
using StoregApp.Domain.Interfaces;

namespace StoregApp.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Category GetCategoryById(int idCategory);

        IEnumerable<Category> GetCategories();

        void InsertCategory(Category category);

        void UpdateCategory(Category category);

        void DeleteCategory(int idCategory);

    }
}
