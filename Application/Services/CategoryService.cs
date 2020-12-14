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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;        }
        public IEnumerable<CategoryDto> GetAll()
        {
            var categoris = _categoryRepository.GetAll();
            return categoris.MappingcategoryDtos();
        }

        public CategoryDto GetBy(int id)
        {
            var category = _categoryRepository.GetBy(id);
            if (category == null) return null;
            return category.MappingCategoryDto();
        }

        public IEnumerable<ProductDto> GetProductInCategory(int Category_id)
        {
            var productincategory = _categoryRepository.GetProductInCategory(Category_id);
            if (productincategory == null) return null;
            return productincategory.MappingDtos();
        }
    }
}
