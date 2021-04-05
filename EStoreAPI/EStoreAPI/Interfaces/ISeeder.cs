using EStoreDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStoreAPI.Interfaces
{
    public interface ISeeder
    {
        List<Product> GetAllProducts();

        bool AddProduct(Product product);

        bool UpdateProduct(int id, Product updatedProduct);

        bool DeleteProduct(int id);
    }
}
