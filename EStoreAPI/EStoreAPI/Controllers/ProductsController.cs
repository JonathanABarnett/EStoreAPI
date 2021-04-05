using EStoreAPI.Interfaces;
using EStoreDomain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStoreAPI.Controllers
{
    [Route("/api/[controller]")]
    public class ProductsController : Controller
    {

        private readonly ISeeder _seeder;

        public ProductsController(ISeeder seeder)
        {
            _seeder = seeder;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            
            return Ok(_seeder.GetAllProducts());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _seeder.GetAllProducts().FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            var addResult = _seeder.AddProduct(product);

            if (!addResult)
            {
                return BadRequest("Unable to create new product");
            }

            return Created("https://localhost:5001/api/products{product.Id}", product);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody]Product updatedProduct)
        {
            var result = _seeder.UpdateProduct(id, updatedProduct);

            if (result)
            {
                return Ok("Product updated successfully");
            }

            return BadRequest("Unable to update product");
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var result = _seeder.DeleteProduct(id);

            if (result)
            {
                return Ok("Product deleted");
            }

            return BadRequest("Unable to delete product");
        }
    }
}
