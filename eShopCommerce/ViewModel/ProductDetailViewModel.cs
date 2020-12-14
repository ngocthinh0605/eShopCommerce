using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopCommerce.ViewModel
{
    public class ProductDetailViewModel
    {
        public ProductDto product { set; get; }
        public IEnumerable<ProductDto> productincategory { set; get; }
    }
}
