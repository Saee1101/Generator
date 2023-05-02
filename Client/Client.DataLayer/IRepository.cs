using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataLayer
{
   public interface IRepository<TEntity>
    {
        void report();
        int Add(TEntity entity);
        int Remove(TEntity entity);
        int Update(TEntity entity);
        List<TEntity> All();
        TEntity Find(params object[] keys);
        int Count();
    }
}
