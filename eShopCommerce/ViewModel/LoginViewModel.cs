using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShopCommerce.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string EmailLogin { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string PasswordLogin { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMeLogin { get; set; }

        public string ReturnUrl { get; set; }
    }
}
