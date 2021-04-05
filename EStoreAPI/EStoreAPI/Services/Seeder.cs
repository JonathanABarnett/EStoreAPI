using EStoreAPI.Interfaces;
using EStoreDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStoreAPI.Services
{
    public class Seeder : ISeeder
    {
        private List<Product> _products = new List<Product>();

        public bool AddProduct(Product product)
        {
            _products.Add(product);
            return true;
        }

        public bool DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return false;
            }

            _products.Remove(product);

            return true;
        }

        public List<Product> GetAllProducts()
        {
            var product1 = new Product
            {
                Id = 1,
                Name = "Logitech IP Camera",
                Description = "Takes some pictures",
                Price = 35.25f
        };
            _products.Add(product1);

            var product2 = new Product
            {
                Id = 2,
                Name = "LG Phone",
                Description = "Some kind of phone",
                Price = 46.33f
            };
            _products.Add(product2);
            var product3 = new Product
            {
                Id = 3,
                Name = "HP Keyboard",
                Description = "Can type some letters",
                Price = 12.36f
            };
            _products.Add(product3);

            return _products;
        }

        public bool UpdateProduct(int id, Product updatedProduct)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                _products.Remove(product);
                _products.Add(updatedProduct);
                return true;
            }
            return false;
        }
    }
}
