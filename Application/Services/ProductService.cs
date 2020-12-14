using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void CreateProduct(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetGenres()
        {
            return _productRepository.GetGenres();
        }

        public ProductDto GetProduct(int productId)
        {
            var product = _productRepository.GetBy(productId);
            return product.MappingDto();

        }

        public IEnumerable<ProductDto> GetProducts(string sortOrder, string movieGenre, string searchString, int pageIndex, int pageSize, out int count)
        {
            var products = _productRepository.Filter(sortOrder, movieGenre, searchString, pageIndex, pageSize, out count);
            return products.MappingDtos();

        }

        public void UpdateProduct(ProductDto product)
        {
            throw new NotImplementedException();
        }
    }
}
