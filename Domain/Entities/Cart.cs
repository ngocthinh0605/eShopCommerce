﻿using Domain.Entities.Common;
using Domain.UserApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cart : IAggregateRoot
    {
        public Cart()
        {
            Quantity = 0;
            Price = 0;
        }
        [Key]
        public int Id                 {set;get;}
        public int ProductId          {set;get;}
        public int Quantity           {set;get;}
        public decimal Price     { set; get; }

        public string UserId { set; get; }

        public ApplicationUser appcationUser { set; get; }
        public Product Product { get; set; }
    }
}
