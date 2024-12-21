using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace View_Component_Tag_Helper.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductImage { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
    public class CartItem{
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
    public class MenuItem{
        public string Text { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
    }
}