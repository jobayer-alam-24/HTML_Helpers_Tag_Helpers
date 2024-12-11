using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Checkbox_Implement.Models;

namespace Checkbox_Implement.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        SecuritySettingsViewModel settings = new SecuritySettingsViewModel()
        {
            EnableTwoFactorAuth = false
        };
        return View();
    }
    [HttpPost]
    public string UpdateSecuritySettings(SecuritySettingsViewModel settings)
    {
        if(settings.EnableTwoFactorAuth){
            return "You Enable Two Factor Authentication";
        }
        else
        {
            return "You Disabled Two Factor Authentication";
        }
    }

    [HttpPost]
    public string UpdateProfile(bool SubscribeToNewsletter){
        if(SubscribeToNewsletter){

            return "You Subscribed To News Letter";
        }
        else
        {
            return "You Havenot Subscribe to Newsletter";
        }
    }
    [HttpPost]
    public string Register(bool AcceptTerms)
    {
        if(AcceptTerms){
            return "You Accept the Terms and Conditions";
        }
        else{
            return "You Havenot Accept the Terms and Conditions";
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
