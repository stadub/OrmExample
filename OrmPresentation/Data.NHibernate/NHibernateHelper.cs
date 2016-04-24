using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entity;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;

namespace Data.NHibernate
{

    public class NHibernateHelper
    {
        const string dbName = "SuperHeroesDb";
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)

                    InitializeSessionFactory();
                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile(dbName).ShowSql()
                )
                .Mappings(m =>
                          m.FluentMappings
                              .AddFromAssemblyOf<SuperHero>())
                .ExposeConfiguration(BuildSchema)
                .BuildSessionFactory();
 
        }

        private static void BuildSchema(Configuration config)
        {
            // delete the existing db on each run
            if (File.Exists(dbName))
                File.Delete(dbName);

            // this NHibernate tool takes a configuration (with mapping info in)
            // and exports a database schema from it
            new SchemaExport(config)
              .Create(false, true);
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        private static readonly object lockObject = new object();
        private static Configuration configuration;
        private static ISessionFactory sessionFactory;



        public static ISession GetSession()
        {
            if (CurrentSessionContext.HasBind(SessionFactory))
                return SessionFactory.GetCurrentSession();

            throw new InvalidOperationException("Database access logic cannot be used, if session not opened. Implicitly session usage not allowed now. Please open session explicitly through UnitOfWorkFactory.StartLongConversation method");
        }
    }
}
