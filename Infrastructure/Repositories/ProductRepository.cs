using Domain.Entities;
using Domain.Repository;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductRepository :EFRepository<Product>, IProductRepository
    {
        public ProductRepository(eShopContext eShopContext) : base(eShopContext)
        {

        }
        public IEnumerable<Product> Filter(string sortOrder, string movieGenre, string searchString, int pageIndex, int pageSize, out int count)
        {
            var query = _eShopContext.Products.AsQueryable();
            count = 0;
            if(!string.IsNullOrEmpty(movieGenre))
            {
                var queryGenre = _eShopContext.Categories.AsQueryable();
                queryGenre = queryGenre.Where(m => m.Name == movieGenre);
            }
            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(m => m.Name.Contains(searchString));
            }
            count = query.Count();
            return query.Skip((pageIndex - 1)* pageSize)
                .Take(pageSize).ToList();
        }

        public IEnumerable<string> GetGenres()
        {
            return _eShopContext.Categories
                    .OrderBy(m => m.Name)
                    .Select(m => m.Name)
                    .Distinct();
        }



    }
}
