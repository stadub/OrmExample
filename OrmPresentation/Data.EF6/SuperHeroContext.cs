using Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EF6
{
    public class SuperHeroContext : DbContext
    {
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
