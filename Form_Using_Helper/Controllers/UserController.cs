using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Form_Using_Helper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Form_Using_Helper.Controllers
{
    public class UserController : Controller
    {

        [HttpGet]
        public IActionResult Register()
        {
            var model = new UserRegistrationModel()
            {
                Courses = new List<string>
                {
                    "C#",
                    "ASP.NET",
                    "SQL Server",
                    "Angular"
                },
                Skills = new List<string>
                {
                    "C",
                    "C++",
                    "C#",
                    "SQL Server"
                },
                HiddenField = Guid.NewGuid()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Register(UserRegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Success", model);
            }
            model.Courses = new List<string>
            {
                "C#",
                "ASP.NET",
                "SQL Server",
                "Angular"
            };
            model.Skills = new List<string>
            {
                "C",
                "C++",
                "C#",
                "SQL Server"
            };
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}