using NHibernate;

namespace Data.NHibernate
{
    public class SessionProvider : ISessionProvider
    {
        #region ISessionProvider Members

        public ISession CurrentSession
        {
            get { return NHibernateHelper.GetSession(); }
        }

        #endregion
    }
}