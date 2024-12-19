using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Custom_Helper_Implement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Custom_Helper_Implement.Controllers
{
    public class EmployeeController : Controller
    {

        public IActionResult Index()
        {
            Employee employee = new Employee(){
                Id = 1,
                Name = "Rahim",
                Photo = "../images/baby.jpg",
                AlternateText = "A cute Baby's Picture"
            };
            return View(employee);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}