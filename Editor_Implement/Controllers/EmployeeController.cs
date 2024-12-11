using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Editor_Implement.Models;
using Microsoft.Extensions.Logging;

namespace Editor_Implement.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            var model = new Employee()
            {
                Name = "Rahim Khan",
                Age = 14,
                Salary = 55.5m,
                IsEmployed = true,
                DateOfBirth = new DateTime(2010, 04, 18),
                Skills = new List<string> {"C#", "Javascript", "Time Management"},
                Gender = Gender.Male,
                ProfilePicture = null,
                UserId = Guid.NewGuid(), //Generates a Unique ID
                WorkingHours = new TimeSpan(4, 30, 0)
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View(model);
        }
        public string Success()
        {
            return "Employee Created/Edited Successfully!";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}