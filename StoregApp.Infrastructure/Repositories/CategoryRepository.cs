using StoregApp.Domain.Entities;
using StoregApp.Domain.Interfaces;
using StoregApp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private StoreGContext _context;

        public CategoryRepository(StoreGContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetCategories()
        {
            return _context.Categories;
        }

        public Product GetCategoryById(int idCategory)
        {
            return _context.Categories.FirstOrDefault(x => x.IdCategory == idCategory);
        }

        public void InsertCategory(Product category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Product category)
        {
            var categoriaExistente = _context.Categories.FirstOrDefault(x => x.IdCategory == category.IdCategory);
            categoriaExistente.NameCategory = categoriaExistente.NameCategory;
            _context.SaveChanges();
        }

        public void DeleteCategory(int idCategory)
        {
            var categoriaExistente = _context.Categories.FirstOrDefault(x => x.IdCategory == idCategory);          
            _context.Categories.Remove(categoriaExistente);
            _context.SaveChanges();
        }








    }
}
