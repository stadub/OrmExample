using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Villain : SuperHero
    {
        public virtual VillainClan Clan { get; set;}
    }

    public class VillainClan
    {
        public VillainClan()
        {
            Crimes= new List<string>();
        }

        public virtual int Id { get; set; }
        public virtual List<string> Crimes { get; private set; }
        public virtual City City { get; set; }
        public virtual List<Villain> Villains { get; set; }
    }


}
