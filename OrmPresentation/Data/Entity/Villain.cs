﻿using System;
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
        public virtual int Id { get; set; }
        public virtual List<string> Crimes { get; set; }
    }


}
