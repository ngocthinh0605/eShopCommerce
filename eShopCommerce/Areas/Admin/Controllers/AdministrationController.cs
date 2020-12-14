using Domain.UserApplication;
using eShopCommerce.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopCommerce.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/administration")]
    [Authorize(Roles = "Admin")]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdministrationController(RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        [Route("")]
        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index","eShop",new { Areas = ""});
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("")]
        [Route("CreateRole")]

        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        [Route("CreateRole")]

        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if(ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await _roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRole", "Administration", new { Areas = "admin" });
                }
                foreach(IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
          
            return View(model);
        }
        [HttpGet]
        [Route("")]
        [Route("ListRole")]
        public IActionResult ListRole()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        /*[Route("")]
        [Route("EditRole")]
        public IActionResult EditRole(string id)
        {
            var role = _roleManager.FindByNameAsync(id);
            return View(role);
        }*/

        [HttpGet]
        [Route("")]
        [Route("EditRole")]
        public async Task<IActionResult> EditRole (string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            if(role == null)
            {
                ViewBag.ErrorMessage = $"role with id = {id} cannot be found";
                return View("NotFound");
            }
            else
            {
                var modeledit = new EditRoleModel
                {
                    Id = role.Id,
                    RoleName = role.Name
                };

                foreach (var user in _userManager.Users.ToList())
                {
                    if (await _userManager.IsInRoleAsync(user, role.Name))
                    {
                        modeledit.Users.Add(user.UserName);
                    }
                }
                return View(modeledit);
            }
        }

        [HttpPost]
        [Route("")]
        [Route("EditRole")]
        public async Task<IActionResult> EditRole(EditRoleModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"role with id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                role.Name = model.RoleName;
                var result = await _roleManager.UpdateAsync(role);
    
               if(result.Succeeded)
                {
                    return RedirectToAction("ListRole", "Administration", new { Areas = "admin" });
                }

               foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
        }
        [Route("")]
        [Route("EditUsersInRole")]
        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.roleId = roleId;
            var role = await _roleManager.FindByIdAsync(roleId);
            if(role == null)
            {
                ViewBag.ErrorMessage = $"role with id = {roleId} cannot be found";
                return View("NotFound");
            }
            var model = new List<UserRoleViewModel>();

            foreach(var user in _userManager.Users.ToList())
            {
                var userRoleVewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                };

                if(await _userManager.IsInRoleAsync(user,role.Name))
                {
                    userRoleVewModel.IsSelected = true;
                }
                else
                {
                    userRoleVewModel.IsSelected = false;
                }
                model.Add(userRoleVewModel);

               
            }
            return View(model);
        }

        [HttpPost]
        [Route("")]
        [Route("EditUsersInRole")]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"role with id = {roleId} cannot be found";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await  _userManager.FindByIdAsync(model[i].UserId);
                IdentityResult result = null;
                if (model[i].IsSelected && !(await _userManager.IsInRoleAsync(user,role.Name)))
                {
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }
                else
                {
                    if (!model[i].IsSelected && await _userManager.IsInRoleAsync(user, role.Name))
                    {
                        result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                    }
                    else
                    {
                        continue;
                    }
                }

                if (result.Succeeded)
                {
                    if(i < (model.Count - 1))
                    {
                        continue;
                    }
                    else
                    {
                        return RedirectToAction("editrole", "administration", new { Areas = "admin", Id = roleId });
                    }
                }
            }

            return RedirectToAction("editrole", "administration", new { Areas = "admin", Id = roleId });

        }
    }
}
