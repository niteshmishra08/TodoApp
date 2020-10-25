using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Common
{
   public interface IUnitOfWork: IDisposable
    {

        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;

    }
}
