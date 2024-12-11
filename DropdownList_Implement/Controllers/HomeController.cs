using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DropdownList_Implement.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DropdownList_Implement.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
         // List of Departments
        List<Department> ListDepartments = new List<Department>()
            {
                new Department() {Id = 1, Name="IT" },
                new Department() {Id = 2, Name="HR" },
                new Department() {Id = 3, Name="Payroll" },
            };
        ViewBag.Departments1 = ListDepartments;

        // List of SelectListItem 
        List<SelectListItem> Departments = new List<SelectListItem>(){
            new SelectListItem() {Text = "IT", Value = "1", Selected = true},
            new SelectListItem() {Text = "HR", Value = "2"},
            new SelectListItem() {Text = "Payroll", Value = "3"}
        };

        ViewBag.Departments2 = Departments;

        Employee emp = new Employee()
        {
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
