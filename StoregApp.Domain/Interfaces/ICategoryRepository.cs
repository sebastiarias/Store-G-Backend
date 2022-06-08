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
        Product GetCategoryById(int idCategory);

        IEnumerable<Product> GetCategories();

        void InsertCategory(Product category);

        void UpdateCategory(Product category);

        void DeleteCategory(int idCategory);

    }
}
