using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hidden_Implement.Models;
namespace Hidden_Implement.Controllers
{
    public class  StudentController : Controller
    {
        public IActionResult Edit()
        {
            Student student = new Student(){Id = 1, Name = "Rahim Khan", Branch = "CSE"};
            return View(student);
        }
        [HttpPost]
        public string Edit(Student student)
        {
            return $"ID: {student.Id} Name: {student.Name} Branch: {student.Branch}"; 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}