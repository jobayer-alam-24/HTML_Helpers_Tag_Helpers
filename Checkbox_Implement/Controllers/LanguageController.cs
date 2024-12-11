using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Checkbox_Implement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Checkbox_Implement.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult SelectLanguages()
        {
            var model = new ProgrammingLanguagesViewModel
            {
                LanguageOptions = new List<LanguageOption>{
                    new LanguageOption { IsSelected = false, LanguageName = "C#" },
                    new LanguageOption { IsSelected = false, LanguageName = "ASP.NET Core" },
                    new LanguageOption { IsSelected = false, LanguageName = "Python" },
                    new LanguageOption { IsSelected = false, LanguageName = "Java" },
                    new LanguageOption { IsSelected = false, LanguageName = "Ruby" },
                    new LanguageOption { IsSelected = false, LanguageName = "C++" }
                }
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult SubmitLanguages(ProgrammingLanguagesViewModel model)
        {
            var selectedLanguages = model.LanguageOptions
            .Where(x => x.IsSelected)
            .Select(x => x.LanguageName)
            .ToList();

            ViewBag.SelectLanguages = selectedLanguages;
            return View("SelectedLanguages", selectedLanguages);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}