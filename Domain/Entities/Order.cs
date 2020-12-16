using Domain.UserApplication;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Order
    {
    [Key]
     public int  Id                        {set;get;}
     public DateTime  OrderDate                 {set;get;}
     public string  UserId                    {set;get;}
     public string  ShipAddress               {set;get;}
     public string ShipEmail                 {set;get;}
     public string ShipPhoneNumber { set; get; }
     public int Status { set; get; }
     public ApplicationUser applicationUser { set; get; }
}
}