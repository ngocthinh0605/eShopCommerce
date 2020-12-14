using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
     public static class MappingCategoryProfile
    {
        public static CategoryDto MappingCategoryDto(this Category cat)
        {
            return new CategoryDto
            {
                Id = cat.Id,
                Description = cat.Description,
                Name = cat.Name
            };

        }

        public static Category MappCategory (this CategoryDto cato)
        {
            return new Category
            {
                Id = cato.Id,
                Name = cato.Name,
                Description = cato.Description,

            };

        }

        public static void MappCategory(this CategoryDto cato, Category cat)
        {
            cato.Id = cat.Id;
            cato.Name = cat.Name;
            cato.Description = cat.Description;
        }

        public static IEnumerable<CategoryDto> MappingcategoryDtos(this IEnumerable<Category> cat)
        {
            foreach(var c in cat)
            {
                yield return c.MappingCategoryDto();
            }
        }


    }
}
