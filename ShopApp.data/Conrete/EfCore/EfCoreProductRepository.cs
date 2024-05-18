using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp.data.Abstract;
using ShopApp.entity;

namespace ShopApp.data.Conrete.EfCore
{
    internal class EfCoreProductRepository: EfCoreGenericRepository<Product, ShopContext>,IProductRepository
    {
        public List<Product> GetPopularProducts()
        {
            using var context = new ShopContext();
            return [.. context.Products];
        }
    }
}
