using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetAll();
        CategoryDto GetBy(int id);

        IEnumerable<ProductDto> GetProductInCategory(int Category_id);
    }
}
