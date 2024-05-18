using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.entity
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }

        public string Img { get; set; } = string.Empty;

        public List<ProductCategory> ProductCategories { get; set; } = [];
    }
}
