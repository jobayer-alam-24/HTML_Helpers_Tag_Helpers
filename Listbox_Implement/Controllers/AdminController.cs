using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Listbox_Implement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Listbox_Implement.Controllers
{

    public class AdminController : Controller
    {
        private List<Role> GetAvailableRoles()
        {
            return new List<Role>{
                new Role { RoleId = 1, RoleName = "Admin"},
                new Role { RoleId = 2, RoleName = "Editor"},
                new Role { RoleId = 3, RoleName = "Viewer"},
            };
        }
        public IActionResult AssignRoles(int userId = 1)
        {
            var model = new UserRoleViewModel{
                UserId = userId,
                UserName = "Sabbir",
                AvailableRoles = GetAvailableRoles()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult AssignRoles(UserRoleViewModel model){
            model.AvailableRoles = GetAvailableRoles();

            if(model.SelectedRoleIds != null && model.SelectedRoleIds.Any())
            {
                var AssignedRoles = model.AvailableRoles.Where(role => model.SelectedRoleIds.Contains(role.RoleId)).ToList();

                ViewBag.Message = $"Roles assigned to {model.UserName}: {string.Join(", ", AssignedRoles.Select(r => r.RoleName))}";
            }
            else
            {
                ViewBag.Message = "No Role Selected";
            }
            return View(model);
        }
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}