using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using NHibernate.Linq;
using NHibernate.Transform;

namespace Data.NHibernate.UnitOfWork
{

    public abstract class BaseRepository<TEntity> : IRepository<TEntity>
            where TEntity : class, IEntity
    {
        private readonly ISessionProvider sessionProvider;


        protected BaseRepository(ISessionProvider sessionProvider)
        {
            if (sessionProvider == null)
                throw new ArgumentNullException("sessionProvider");

            this.sessionProvider = sessionProvider;
        }

        protected ISession Session
        {
            get { return sessionProvider.CurrentSession; }
        }


        public void Add(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity item)
        {
            Session.SaveOrUpdate(item);
        }

        public void Remove(TEntity item)
        {
            Session.Delete(item);
        }

        public TEntity GetById(int id)
        {
            return Session.Get<TEntity>(id);
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
        {
            return Session.Query<TEntity>().Where(expression);
        }
    }
}
