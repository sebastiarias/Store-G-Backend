using StoregApp.Application.Requests;
using StoregApp.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Interfaces
{
    public interface IProductService
    {
        ProductResponse GetProductById(int idProduct);

        IEnumerable<ProductResponse> GetProducts();

        void InsertProduct(CreateProductRequest product);

        void UpdateProduct(UpdateProductRequest product);

        void DeleteProduct(int idProduct);

    }
}
