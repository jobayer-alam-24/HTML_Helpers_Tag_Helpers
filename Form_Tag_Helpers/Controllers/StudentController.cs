using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Form_Tag_Helpers.Models;
using Form_Tag_Helpers.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Form_Tag_Helpers.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>(){
            new Student
            {
                StudentId = 1, Name = "Pranaya Rout", Password = "Password123!",
                DateOfBirth = new DateTime(1990, 1, 1), Gender = Gender.Male, Address = "Test Address 1234",
                Branch = Branch.CSE, TermsAndConditions = true,
                Hobbies = new List<string> { "Reading", "Traveling" },
                Skills = new List<string> { "C#", "SQL" }
            },
            new Student
            {
                StudentId = 2, Name = "Hina Sharma", Password = "Password123!",
                DateOfBirth = new DateTime(1992, 2, 15), Gender = Gender.Female, Address = "Test Address 1234",
                Branch = Branch.ETC, TermsAndConditions = true,
                Hobbies = new List<string> { "Music", "Traveling" },
                Skills = new List<string> { "Python", "Machine Learning" }
            },
            new Student
            {
                StudentId = 3, Name = "Anurag Mohanty", Password = "Password123!",
                DateOfBirth = new DateTime(1988, 11, 23), Gender = Gender.Male, Address = "Test Address 1234",
                Branch = Branch.Mechanical, TermsAndConditions = true,
                Hobbies = new List<string> { "Reading", "Music" },
                Skills = new List<string> { "ASP.NET Core", "Oracle" }
            }
        };
        [HttpGet]
        public IActionResult List()
        {
            return View(students);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var student = students.FirstOrDefault(s => s.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        [HttpGet]
        public IActionResult Register()
        {
            var student = new Student(){
                Hobbies = new List<string>()
            };
            ViewBag.Hobbies = new List<string> { "Reading", "Traveling", "Music" };
            ViewBag.Skills = new List<string> { "C#", "Python", "ASP.NET Core", "Machine Learning" };

            return View(student);
        }

        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                student.StudentId = students.Count + 1;
                students.Add(student);
                return RedirectToAction("List", "Student");
            }
            ViewBag.Hobbies = new List<string> { "Reading", "Traveling", "Music", "Sports", "Photography" };
            ViewBag.Skills = new List<string> { "C#", "Python", "SQL", "Machine Learning", "Physics", "Research", "Data Analysis" };
            return View(student);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}