using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDomain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Supplier Supplier { get; set; }
        public string ImageUrl { get; set; }

    }
}
