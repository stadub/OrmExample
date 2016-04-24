using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;

namespace Data.NHibernate
{
    public interface INHibernateInitializer
    {
        ///<summary>
        /// Builds and returns nhibernate configuration
        ///</summary>
        ///<returns>NHibernate configuration object</returns>
        Configuration GetConfiguration();
    }
}

