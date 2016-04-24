using Data.Entity;

namespace Data.DbView.DtabaseReflections.TablePerConcreteType
{
    public class VillainTable 
    {
        public virtual int Id { get; set; }
        public virtual VillainClan Clan { get; set;}
        public virtual string Name { get; set; }
        public virtual HeroGender Gender { get; set; }
    }
}
