using Domain.Entities;
using Domain.Repository;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CategoryRepository : EFRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(eShopContext eShopContext) : base(eShopContext)
        {

        }

        public IEnumerable<Product> GetProductInCategory(int category_id)
        {
            var query = _eShopContext.Products.AsQueryable().Where(d => d.Category_Id == category_id);
            return query;
        }
    }
}
