using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public static class MappingProfile
    {
        public static ProductDto MappingDto(this Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Category_Id = product.Category_Id,
                Name = product.Name,
                DateCreated = product.DateCreated,
                Image = product.Image,
                IsFeatured = product.IsFeatured,
                OriginalPrice = product.OriginalPrice,
                Price = product.Price,
                Stock = product.Stock,
                ViewCount = product.ViewCount
            };
        }


        public static Product MappingProduct(this ProductDto productDto)
        {
            return new Product
            {
                Id = productDto.Id,
                Category_Id = productDto.Category_Id,
                Name = productDto.Name,
                DateCreated = productDto.DateCreated,
                Image = productDto.Image,
                IsFeatured = productDto.IsFeatured,
                OriginalPrice = productDto.OriginalPrice,
                Price = productDto.Price,
                Stock = productDto.Stock,
                ViewCount = productDto.ViewCount
            };
        }

        public static void MappingProduct(this ProductDto productDto, Product product)
        {
            productDto.Id = product.Id;
            productDto.Category_Id = product.Category_Id;
            productDto.Name = product.Name;
            productDto.DateCreated = product.DateCreated;
            productDto.Image = product.Image;
            productDto.IsFeatured = product.IsFeatured;
            productDto.OriginalPrice = product.OriginalPrice;
            productDto.Price = product.Price;
            productDto.Stock = product.Stock;
            productDto.ViewCount = product.ViewCount;
        }

        public static IEnumerable<ProductDto> MappingDtos(this IEnumerable<Product> products)
        {
            foreach (var product in products)
            {
                yield return product.MappingDto();
            }
        }
    }
}
