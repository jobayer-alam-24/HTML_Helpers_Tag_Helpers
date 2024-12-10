using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DropdownList_Implement.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DropdownList_Implement.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        List<Department> Departments = new List<Department>()
        {
            new Department {Id = 1, Name = "IT"},
            new Department {Id = 2, Name = "HR"},
            new Department {Id = 3, Name = "Payroll"}
        };
        ViewBag.Departments = new SelectList(Departments, "Id", "Name");

        Employee emp = new Employee(){
            EmployeeId = 1,
            EmployeeName = "Rahima",
            Gender = "Female",
            DepartmentID = 1
        };

        return View(emp);
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
