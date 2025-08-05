using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductApplication.src.models;

namespace ProductApplication.src.services
{
    public class ProductService
    {
        private List<Product> _products = new List<Product>();
        public ProductService()
        {
            _products.Add(new Product { Name = "Product 1", Description = "Description 1", Price = 100 });
            _products.Add(new Product { Name = "Product 2", Description = "Description 2", Price = 200 });
            _products.Add(new Product { Name = "Product 3", Description = "Description 3", Price = 200 });
        }
        public List<Product> GetProducts()
        {
            return _products;
        }
        public List<Product> GetProductByPrice(decimal price)
        {
            var selectedProducts = _products.Where(product => product.Price == price).ToList();
            return selectedProducts;
        }
    }
}