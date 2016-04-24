using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    interface IRepository<T>
    {
        void Add(T item);
        void Update(T item);
        void Remove(T item);
        T GetById(int id);
        IQueryable<T> Where(Expression expression);
    }
}
