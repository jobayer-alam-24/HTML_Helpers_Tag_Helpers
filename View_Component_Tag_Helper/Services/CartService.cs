using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using View_Component_Tag_Helper.Models;

namespace View_Component_Tag_Helper.Services
{
    public class CartService
    {
        private static List<CartItem> _cartItems = new List<CartItem>();    
        public List<CartItem> GetCartItems()
        {
            return _cartItems;
        }
        public void AddToCart(Product product, int quantity)
        {
            var _existingItem = _cartItems.FirstOrDefault(x => x.Product.Id == product.Id);
            if(_existingItem == null)
            {
                _cartItems.Add(new CartItem { Product = product, Quantity = quantity });
            }
            else
            {
                _existingItem.Quantity += quantity;
            }
        }
    }
}