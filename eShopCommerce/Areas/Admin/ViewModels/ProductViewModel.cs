using Application.DTOs;
using eShopCommerce.Helpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopCommerce.Areas.Admin.ViewModels
{
    public class ProductViewModel
    {
        public SelectList Genres { get; set; }
        public PaginatedList<ProductDto> Products { get; set; }
        public string ProductGenre { get; set; }
        public string SearchString { get; set; }
        public string SortOrder { get; set; }
    }
}
