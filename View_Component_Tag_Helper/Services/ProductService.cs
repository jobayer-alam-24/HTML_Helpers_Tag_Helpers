using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using View_Component_Tag_Helper.Models;

namespace View_Component_Tag_Helper.Services
{
    public class ProductService
    {
        private List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1000, Description = "A powerful laptop for professionals Developers",
            ProductImage = "https://dummyimage.com/600x400/000/fff&text=Laptop" },
            new Product { Id = 2, Name = "Smartphone", Price = 500, Description = "Latest smartphone with cutting-edge features",
            ProductImage = "https://dummyimage.com/600x400/000/fff&text=Smartphone" },
            new Product { Id = 3, Name = "Headphones", Price = 1500, Description = "Noise-cancelling over-ear headphones good for health",
            ProductImage = "https://dummyimage.com/600x400/000/fff&text=Headphones" }
        };
        public List<Product> GetAllProducts()
        {
            return _products;
        }
    }
}