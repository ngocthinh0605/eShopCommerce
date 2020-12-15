using Application.DTOs;
using Application.Interfaces;
using eShopCommerce.Areas.Admin.ViewModels;
using eShopCommerce.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopCommerce.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/product")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index(string sortOrder, string movieGenre, string searchString, int pageIndex = 1)
        {
            int pageSize = 6;
            int count;
            var products = _productService.GetProducts(sortOrder, movieGenre, searchString, pageIndex, pageSize, out count);
            var genres = _productService.GetGenres();
            var indexvm = new ProductViewModel()
            {
                Products = new PaginatedList<ProductDto>(products, count, pageIndex, pageSize),
                Genres = new SelectList(genres),
                ProductGenre = movieGenre,
                SearchString = searchString
            };
            return View(indexvm);
        }

        [Route("")]
        [Route("Create")]
        public IActionResult Create(ProductDto productDto)
        {
            if (ModelState.IsValid)
            {
                _productService.CreateProduct(productDto);
                return RedirectToAction("Index", "Product", new { Areas = "admin" });
            }

            return View();
        }

        [Route("")]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            var movie = _productService.GetProduct(id);

            return View(movie);
        }

        [HttpPost]
        [Route("")]
        [Route("Delete")]
        public IActionResult Delete(int id, bool notUsed)
        {
            var movie = _productService.GetProduct(id);
            _productService.DeleteProduct(movie.Id);

            return RedirectToAction("Index", "Product", new { Areas = "admin" });
        }


        [HttpGet]
        [Route("")]
        [Route("Edit")]
        public IActionResult Edit(int id)
        {
            var product = _productService.GetProduct(id);

            return View(product);
        }

        [HttpPost]
        [Route("")]
        [Route("Edit")]
        public IActionResult Edit(ProductDto productdto)
        {
            if (ModelState.IsValid)
            {
                _productService.UpdateProduct(productdto);
                return RedirectToAction("Index", "Product", new { Areas = "admin" });
            }
            return View();
        }



    }
}
