using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShopCommerce.Areas.Admin.ViewModels
{
    public class EditRoleModel
    {
        public EditRoleModel()
        {
            Users = new List<string>();
        }
        public string Id { get; set; }

        [Required(ErrorMessage ="Role Name is Required")]
        public string RoleName { set; get; }

        public List<string> Users { get; set; }
    }
}
