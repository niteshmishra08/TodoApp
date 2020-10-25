using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Common
{
   public interface IGenericRepository<T> where T: class
    {

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetList();
    }
}

