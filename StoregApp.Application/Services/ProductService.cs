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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteProduct(int idProduct)
        {
            _repository.DeleteProduct(idProduct);
        }

        public ProductResponse GetProductById(int idProduct)
        {
            var product = _repository.GetProductById(idProduct);
            var productResponse = _mapper.Map<ProductResponse>(product);
            return productResponse;
        }


        public IEnumerable<ProductResponse> GetProducts()
        {
            var product = _repository.GetProducts();
            var productResponse = _mapper.Map<IEnumerable<ProductResponse>>(product);
            return productResponse;
        }


        public void InsertProduct(CreateProductRequest request)
        {
            var product = _mapper.Map<Product>(request);
            _repository.InsertProduct(product);
        }

        public void UpdateProduct(UpdateProductRequest request)
        {
            var product = _mapper.Map<Product>(request);
            _repository.InsertProduct(product);
        }
    }
}
