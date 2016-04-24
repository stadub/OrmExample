using Data.Entity;
using FluentNHibernate.Mapping;

namespace Data.NHibernate
{
    public class CityMap : ClassMap<City>
    {
        public CityMap()
        {
            Table("City");
            Id(e => e.Id);
            Map(e => e.Name);
            HasMany(x => x.CityClans).AsBag(); ;
        }
    }
    public class SuperHeroMap : ClassMap<SuperHero>
    {
        public SuperHeroMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Gender)
                .CustomType("Data.Entity, HeroGender")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("INTEGER")
                .Not.Nullable();
        }
    }
    public class ProtagonistMap : ClassMap<Protagonist>
    {
        public ProtagonistMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Gender);
            Component<SuperPower>(x => x.SuperPower, m =>
            {
                m.Map(x => x.Name);
            });
        }
    }
    public class VillainClanMap : ClassMap<VillainClan>
    {
        public VillainClanMap()
        {
            Id(x => x.Id);
            Map(x => x.Crimes);
            References(x => x.City);
            HasMany(x => x.Villains).Cascade.None();
        }
    }

    public class VillainMap : SubclassMap<Villain>
    {
        public VillainMap()
        {
            Table("Villain");
            KeyColumn("Id");
            Map(x => x.Name);
            Map(x => x.Gender);
        }
    }

}
