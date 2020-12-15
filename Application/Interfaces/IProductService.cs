using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetProducts (string sortOrder, string movieGenre, string searchString, int pageIndex, int pageSize, out int count);
        ProductDto GetProduct(int productId);
        IEnumerable<ProductDto> GetAll();
        IEnumerable<string> GetGenres();
        void CreateProduct(ProductDto product);
        void UpdateProduct(ProductDto product);
        void DeleteProduct(int product);
    }
}
