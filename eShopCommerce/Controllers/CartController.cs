using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using shoppingcart.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopCommerce.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        public CartController(IProductService productService)
        {
            _productService = productService;
            
        }
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartDto>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.ProductDto.Price * item.Quantity);
            
            /*ViewBag.total = cart.Sum(item => item.ProductDto.Price * item.Quantity);*/
            return View();
        }

        [Route("buy/{id}")]
        public IActionResult Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<CartDto>>(HttpContext.Session, "cart") == null)
            {
                List<CartDto> cart = new List<CartDto>();
                cart.Add(new CartDto { ProductDto = _productService.GetProduct(id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<CartDto> cart = SessionHelper.GetObjectFromJson<List<CartDto>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new CartDto { ProductDto = _productService.GetProduct(id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }
        private int isExist(int id)
        {
            List<CartDto> cart = SessionHelper.GetObjectFromJson<List<CartDto>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].ProductDto.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

        [Route("remove/{id}")]
        public IActionResult Remove(int id)
        {
            List<CartDto> cart = SessionHelper.GetObjectFromJson<List<CartDto>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
    }

}
