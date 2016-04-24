using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepository<TEntity>
        where TEntity : IEntity
    {
        void Add(TEntity item);
        void Update(TEntity item);
        void Remove(TEntity item);
        TEntity GetById(int id);
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression);
    }
}
