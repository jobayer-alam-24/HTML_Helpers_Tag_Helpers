using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using View_Component_Tag_Helper.Models;
using View_Component_Tag_Helper.Services;

namespace View_Component_Tag_Helper.Controllers;

public class HomeController : Controller
{
    private readonly ProductService _productService;
    private readonly CartService _cartService;

    public HomeController(){
        _productService = new ProductService();
        _cartService = new CartService();
    }

    public IActionResult Index()
    {
        var products = _productService.GetAllProducts();
        return View(products);
    }
    public IActionResult AddToCart(int id)
    {
        var product = _productService.GetAllProducts().FirstOrDefault(x => x.Id == id);
        if(product != null)
        {
            _cartService.AddToCart(product, 1);
        }
        return View(product);
    }
    public IActionResult Cart()
    {
        var cartItems = _cartService.GetCartItems();
        return View(cartItems);
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
