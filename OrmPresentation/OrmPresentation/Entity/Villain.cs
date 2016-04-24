using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmPresentation.Entity
{
    public class Villain : SuperHero
    {

        public VillainClan Clan { get; set;}
    }

    public class VillainClan
    {
        List<string> Crimes { get; set; }
    }
}
