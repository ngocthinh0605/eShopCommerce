using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<Product> GetProductInCategory(int category_id);
    }
}
