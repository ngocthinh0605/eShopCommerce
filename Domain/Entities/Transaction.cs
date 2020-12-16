using Domain.UserApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Transaction
    {
        [Key]
        public int Id                              {set;get;}
        public DateTime TransactionDate                 {set;get;}
        public decimal Amount                          {set;get;}
        public decimal Fee                             {set;get;}
        public bool Result                          {set;get;}
        public string Message                         {set;get;}
        public int Status                          {set;get;}

        public int UserId { set; get; } 

        public ApplicationUser applicationUser { set; get; }



    }
}
