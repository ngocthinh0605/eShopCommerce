using Application.DTOs;
using Application.Interfaces;
using eShopCommerce.Helpers;
using eShopCommerce.ViewModel;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopCommerce.Controllers
{
    [AllowAnonymous]
    public class eShopController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public eShopController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
      

        public IActionResult Index(string sortOrder, string movieGenre, string searchString, int pageIndex = 1)
        {
            int pageSize = 20;
            int count;
            var products = _productService.GetProducts(sortOrder, movieGenre, searchString, pageIndex, pageSize, out count);
            var genres = _productService.GetGenres();
            var indexvm = new IndexViewModel()
            {
                Products = new PaginatedList<ProductDto>(products, count, pageIndex, pageSize),
                Genres = new SelectList(genres),
                ProductGenre = movieGenre,
                SearchString = searchString
            };
            return View(indexvm);
        }

        public IActionResult ProductDetail(int id)
        {
            var producta = _productService.GetProduct(id);
            var productincategory = _categoryService.GetProductInCategory(producta.Category_Id);
            return View(new ProductDetailViewModel()
            {
                product = producta,
                productincategory = productincategory

            });
        }
    }
}
