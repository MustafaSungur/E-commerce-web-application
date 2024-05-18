using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.business.Abstract
{
    public interface IService<T>
    {
        List<T> GetAll();

        T GetById(Guid id);

        void Update(T entity);
        void Delete(T entity);
        void Create(T entity);

    }
}
