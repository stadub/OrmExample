using System.Collections.Generic;

namespace Data.Entity
{
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