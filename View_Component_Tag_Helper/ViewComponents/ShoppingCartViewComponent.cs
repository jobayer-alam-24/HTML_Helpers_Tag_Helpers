using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using View_Component_Tag_Helper.Services;

namespace View_Component_Tag_Helper.ViewComponents
{
    public class ShoppingCartViewComponent : ViewComponent
    { 
        private readonly CartService cartService;
        public ShoppingCartViewComponent(CartService cartService)
        {
            this.cartService = cartService;
        }
        public IViewComponentResult Invoke(CartService cartService){
            var cartItems = cartService.GetCartItems();
            return View(cartItems);
        }
    }
}