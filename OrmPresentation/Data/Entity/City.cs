using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class City
    {
        public City()
        {
            CityClans = new List<VillainClan>();
        }

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual List<VillainClan> CityClans { get; private set; }
    }
}
