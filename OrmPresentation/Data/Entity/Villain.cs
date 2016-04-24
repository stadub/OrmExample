using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Villain : SuperHero
    {
        public virtual VillainClan Clan { get; set;}
    }
}
