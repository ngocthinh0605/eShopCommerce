using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<string> GetGenres();
        IEnumerable<Product> Filter(string sortOrder, string movieGenre, string searchString, int pageIndex, int pageSize, out int count);
    }
}
