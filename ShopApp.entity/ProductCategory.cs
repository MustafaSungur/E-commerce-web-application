using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.entity
{
    public class ProductCategory
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } = new();
        public Category Category { get; set; } = new();
        public int CategoryId { get; set; }
    }
}
