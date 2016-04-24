using NHibernate;

namespace Data.NHibernate
{
    public interface ISessionProvider
    {
 
        ISession CurrentSession { get; }
    }
}