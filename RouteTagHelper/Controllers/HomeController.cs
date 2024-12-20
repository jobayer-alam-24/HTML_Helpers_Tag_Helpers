using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RouteTagHelper.Models;

namespace RouteTagHelper.Controllers;

public class HomeController : Controller
{
    private List<Student> students = new List<Student>
        {
            new Student() {Id = 101, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" },
            new Student() {Id = 102, Name = "Smith", Branch = "ETC", Section = "B", Gender = "Male" },
            new Student() {Id = 103, Name = "David", Branch = "CSE", Section = "A", Gender = "Male" },
            new Student() {Id = 104, Name = "Sara", Branch = "CSE", Section = "A", Gender = "Female" },
            new Student() {Id = 105, Name = "Pam", Branch = "ETC", Section = "B", Gender = "Female" }
        };

    public IActionResult Index()
    {
        return View(students);
    }

    public IActionResult Details(int Id)
    {
        var student = students.FirstOrDefault(x => x.Id == Id);
        return View(student);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
