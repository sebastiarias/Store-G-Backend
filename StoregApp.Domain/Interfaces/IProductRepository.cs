using StoregApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Domain.Interfaces
{
    public interface IProductRepository
    {
        Product GetProductById(int IdProduct);

        IEnumerable<Product> GetProducts();

        void InsertProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int IdProduct);
        
    }
}
