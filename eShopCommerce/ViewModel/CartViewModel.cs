using System.Collections.Generic;
using Application.DTOs;

namespace eShopCommerce.ViewModel
{
    public class CartViewModel
    {

        public CartViewModel()
        {
            cartDtos = new List<CartDto>();
        }

        public List<CartDto> cartDtos { get; set; }
        public decimal GrandTotal { get; set; }

    }
}