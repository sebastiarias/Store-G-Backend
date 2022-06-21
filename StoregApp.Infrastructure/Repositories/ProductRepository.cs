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
    public class ProductRepository : IProductRepository
    {
        private StoreGContext _context;

        public ProductRepository(StoreGContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

        public Product GetProductById(int IdProduct)
        {
            return _context.Products.FirstOrDefault(x => x.IdProduct == IdProduct);
        }

        public void InsertProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            var productExistente = _context.Products.FirstOrDefault(x => x.IdProduct == product.IdProduct);
            productExistente.NameProduct = product.NameProduct;
            productExistente.SkuProduct = product.SkuProduct;
            productExistente.PriceProduct = product.PriceProduct;
            _context.SaveChanges();
        }

        public void DeleteProduct(int IdProduct)
        {
            var productExistente = _context.Products.FirstOrDefault(x => x.IdProduct == IdProduct);
            _context.Products.Remove(productExistente);
            _context.SaveChanges();
        }

        

        

        

        
    }
}
