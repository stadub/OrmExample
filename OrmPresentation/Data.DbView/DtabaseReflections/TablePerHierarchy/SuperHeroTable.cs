using Data.Entity;

namespace Data.DbView.DtabaseReflections.TablePerHierarchy
{
    public class SuperHeroTable
    {
        public SuperPower SuperPower { get; set; }
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual HeroGender Gender { get; set; }
        public virtual VillainClan Clan { get; set; }
    }
}