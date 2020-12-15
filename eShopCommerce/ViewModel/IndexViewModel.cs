using Application.DTOs;
using Domain.Entities;
using eShopCommerce.Helpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopCommerce.ViewModel
{
    public class IndexViewModel
    {
        /*public PaginatedList<ProductDto> Products { get; set; }*/
        public IEnumerable<ProductDto> Products { set; get; }
        public SelectList Genres { get; set; }
        public string ProductGenre { get; set; }
        public string SearchString { get; set; }
        public string SortOrder { get; set; }
        

    }
}
