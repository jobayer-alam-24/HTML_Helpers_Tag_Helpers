using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using View_Component_Tag_Helper.Models;

namespace View_Component_Tag_Helper.ViewComponents
{
    public class NavigationBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var menuItems = new List<MenuItem>
            {
                new MenuItem { Text = "Home", Action = "Index", Controller = "Home" },
                new MenuItem { Text = "AddToCart", Action = "AddToCart", Controller = "Home" },
                new MenuItem { Text = "Contact", Action = "Contact", Controller = "Home" }
            };
            return View(menuItems);
        }   
    }
}