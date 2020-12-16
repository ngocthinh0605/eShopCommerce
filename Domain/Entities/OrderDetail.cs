    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderDetail
    {
      
        public int OrderId             {set;get;}
      
        public int ProductId           {set;get;}
        public int Quantity            {set;get;}
        public decimal Price { set; get; }

        public Order Order { set; get; }
        public Product Product { set; get; }
    }
}
