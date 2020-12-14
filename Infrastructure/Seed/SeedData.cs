using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Seed
{
    public class SeedData
    {
        public static void Initialize(eShopContext context)
        {
           /* context.Database.EnsureCreated();
             bool temp = false;
            if (!context.Categories.Any())
            {
                temp = true;
                context.Categories.AddRange(new List<Category>
                {
                    new Category
                    {
                        Id = 1,
                        Name = "Áo Nam",
                        Description = "Thời Trang Nam"

                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Áo Nữ",
                        Description = "Thời Trang Nữ"
                    }
                }) ;
            }

            if(!context.Products.Any())
            {
                temp = true;
                context.Products.AddRange(new List<Product> {
                    new Product
                    {
                        Id = 1,
                        Category_Id = 1,
                        Name = "Áo sơ mi nam trắng Việt Tiến",
                        DateCreated = DateTime.Now,
                        OriginalPrice = 100000,
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0,
                        IsFeatured = true,
                        Image = ""
                    },
                    new Product
                    {
                        Id = 2,
                        Category_Id = 1,
                        Name = "Áo sơ mi nam Den Việt Tiến",
                        DateCreated = DateTime.Now,
                        OriginalPrice = 100000,
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0,
                        IsFeatured = true,
                        Image = ""
                    },
                    new Product
                    {
                        Id = 3,
                        Category_Id = 2,
                        Name = "Áo sơ mi nữ trắng Việt Tiến",
                        DateCreated = DateTime.Now,
                        OriginalPrice = 100000,
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0,
                        IsFeatured = true,
                        Image = ""
                    },
                    new Product
                    {
                        Id = 4,
                        Category_Id = 2,
                        Name = "Áo sơ mi nữ đen Việt Tiến",
                        DateCreated = DateTime.Now,
                        OriginalPrice = 100000,
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0,
                        IsFeatured = true,
                        Image = ""
                    }
                    ,new Product
                    {
                        Id = 5,
                        Category_Id = 2,
                        Name = "Áo sơ mi nữ đen Việt Tiến",
                        DateCreated = DateTime.Now,
                        OriginalPrice = 100000,
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0,
                        IsFeatured = true,
                        Image = ""
                    },
                    new Product
                    {
                        Id = 6,
                        Category_Id = 2,
                        Name = "Áo sơ mi nữ đen Việt Tiến",
                        DateCreated = DateTime.Now,
                        OriginalPrice = 100000,
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0,
                        IsFeatured = true,
                        Image = ""
                    },
                    new Product
                    {
                        Id = 7,
                        Category_Id = 2,
                        Name = "Áo sơ mi nữ đen Việt Tiến",
                        DateCreated = DateTime.Now,
                        OriginalPrice = 100000,
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0,
                        IsFeatured = true,
                        Image = ""
                    },
                    new Product
                    {
                        Id = 8,
                        Category_Id = 2,
                        Name = "Áo sơ mi nữ đen Việt Tiến",
                        DateCreated = DateTime.Now,
                        OriginalPrice = 100000,
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0,
                        IsFeatured = true,
                        Image = ""
                    },new Product
                    {
                        Id = 9,
                        Category_Id = 2,
                        Name = "Áo sơ mi nữ đen Việt Tiến",
                        DateCreated = DateTime.Now,
                        OriginalPrice = 100000,
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0,
                        IsFeatured = true,
                        Image = ""
                    },new Product
                    {
                        Id = 10,
                        Category_Id = 2,
                        Name = "Áo sơ mi nữ đen Việt Tiến",
                        DateCreated = DateTime.Now,
                        OriginalPrice = 100000,
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0,
                        IsFeatured = true,
                        Image = ""
                    },new Product
                    {
                        Id = 11,
                        Category_Id = 2,
                        Name = "Áo sơ mi nữ đen Việt Tiến",
                        DateCreated = DateTime.Now,
                        OriginalPrice = 100000,
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0,
                        IsFeatured = true,
                        Image = ""
                    },new Product
                    {
                        Id = 12,
                        Category_Id = 2,
                        Name = "Áo sơ mi nữ đen Việt Tiến",
                        DateCreated = DateTime.Now,
                        OriginalPrice = 100000,
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0,
                        IsFeatured = true,
                        Image = ""
                    },new Product
                    {
                        Id = 13,
                        Category_Id = 2,
                        Name = "Áo sơ mi nữ đen Việt Tiến",
                        DateCreated = DateTime.Now,
                        OriginalPrice = 100000,
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0,
                        IsFeatured = true,
                        Image = ""
                    },new Product
                    {
                        Id = 14,
                        Category_Id = 2,
                        Name = "Áo sơ mi nữ đen Việt Tiến",
                        DateCreated = DateTime.Now,
                        OriginalPrice = 100000,
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0,
                        IsFeatured = true,
                        Image = ""
                    }


                }) ; 
            }    
           if(temp)
            {
                context.SaveChanges();
            }*/

            
        }
    }
        
        
}
