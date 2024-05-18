using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp.entity;
namespace ShopApp.data.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
         List<Product> GetPopularProducts();
    }
}
