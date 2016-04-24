using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class SuperHero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HeroGender Gender { get; set; }
    }

}
