using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopCommerce.Areas.Admin.Controllers
{
    
    [Area("admin")]
    [Route("admin/dashboard")]
    [Authorize(Roles = "Admin")]
    public class DashBoardController : Controller
    {
        [Route("")]
        [Route("index")]
        /*[Authorize]*/
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
