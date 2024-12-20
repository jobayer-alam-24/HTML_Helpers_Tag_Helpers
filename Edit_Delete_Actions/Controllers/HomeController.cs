using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Edit_Delete_Actions.Models;

namespace Edit_Delete_Actions.Controllers;

public class HomeController : Controller
{
    private List<Student> students = new List<Student>{
        new Student{Id=1, Name="John", Age="25", Image="images/cute_baby.jpg"},
        new Student{Id=2, Name="Jane", Age="22", Image="images/cute_baby.jpg"},
        new Student{Id=3, Name="Mike", Age="23", Image="images/cute_baby.jpg"},
        new Student{Id=4, Name="Anna", Age="24", Image="images/cute_baby.jpg"},
        new Student{Id=5, Name="Tom", Age="21", Image="images/cute_baby.jpg"},
        new Student{Id=6, Name="Lucy", Age="26", Image="images/cute_baby.jpg"},
    };
    public IActionResult Index()
    {
        return View(students);
    }

    public IActionResult Edit(int id)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        return View(student);
    }
    public IActionResult Delete(int id)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
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
