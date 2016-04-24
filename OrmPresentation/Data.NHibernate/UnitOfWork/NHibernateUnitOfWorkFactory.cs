using System.Data;
using Data.DDD;

namespace Data.NHibernate.UnitOfWork
{
    public class NHibernateUnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork Create(IsolationLevel isolationLevel)
        {
            return new NHibernateUnitOfWork(NHibernateHelper.OpenSession(), isolationLevel);
        }

        public IUnitOfWork Create()
        {
            return Create(IsolationLevel.ReadCommitted);
        }
    }
}