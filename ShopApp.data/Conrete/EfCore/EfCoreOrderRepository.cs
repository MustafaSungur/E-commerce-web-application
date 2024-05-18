using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp.entity;

namespace ShopApp.data.Conrete.EfCore
{
    internal class EfCoreOrderRepository:EfCoreGenericRepository<Order,ShopContext>
    {
    }
}
