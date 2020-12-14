using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShopCommerce.Areas.Admin.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }

        public string Id { set; get; }
        [Required]
        public string UserName { set; get; }
        [Required] [EmailAddress]
        public string Email { set; get; }
        public string City { set; get; }

        public List<string> Claims { set; get; }
        public IList<string> Roles { set; get; }
    }
}
