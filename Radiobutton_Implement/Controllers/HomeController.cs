using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Radiobutton_Implement.Models;
namespace Radiobutton_Implement.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        Company company = new Company();
        return View(company);
    }

    [HttpPost]
    public string Index(Company company)
    {
        if(company.SelectedDepartment <= 0)
        {
            return "You did not select any department";
        }
        else
        {
            return "You have selected: " + company.SelectedDepartment;
        }
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
