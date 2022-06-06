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

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories;
        }

        public Category GetCategoryById(int idCategory)
        {
            return _context.Categories.FirstOrDefault(x => x.IdCategory == idCategory);
        }

        public void InsertCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            var categoryExistente = _context.Categories.FirstOrDefault(x => x.IdCategory == category.IdCategory);
            categoryExistente.NameCategory = category.NameCategory;
            _context.SaveChanges();
        }

        public void DeleteCategory(int idCategory)
        {
            var categoryExistente = _context.Categories.FirstOrDefault(x => x.IdCategory == idCategory);
            _context.Categories.Remove(categoryExistente);
            _context.SaveChanges();
        }








    }
}
