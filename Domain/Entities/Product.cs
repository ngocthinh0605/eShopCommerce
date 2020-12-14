using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Product : IAggregateRoot
    {
        [Key]
        public int Id { set; get; }
        public int Category_Id {set;get;}
        public string Name { get; set; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public bool? IsFeatured { get; set; }
        public string Image { get; set; }
        public Category category {set;get;}
        
    
    }
}