using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Hidden_Implement.Models;
using Hidden_Implement.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hidden_Implement.Controllers
{
    public class RegistrationController : Controller
    {
        [Route("/Registration/Step-1")]
        [HttpGet]
        public IActionResult PersonalInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PersonalInfo(PersonalInfoViewModel personalInfo)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("AddressInfo", new {personalInfo.FirstName, personalInfo.LastName, personalInfo.Email});
            }
            return View(personalInfo);
        }
        [HttpGet]
        public IActionResult AddressInfo(string firstName, string lastName, string email)
        {
            
            AddressInfoViewModel addressInfo = new AddressInfoViewModel()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };
            return View(addressInfo);
        }
        [HttpPost]
        public IActionResult AddressInfo(AddressInfoViewModel model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("RegistrationSummary", new {
                    model.FirstName,
                    model.LastName,
                    model.Email,
                    model.City,
                    model.Street,
                    model.ZipCode
                });
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult RegistrationSummary(string firstName, string lastName, string email, string city, string street, string zipCode)
        {

            RegistrationSummaryViewModel registration = new RegistrationSummaryViewModel()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                City = city,
                ZipCode = zipCode,
                Street = street 
            };
            return View(registration);
        }
        [HttpPost]
        public IActionResult Submit(RegistrationSummaryViewModel registration)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View(registration);
        }
        public IActionResult Success()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}