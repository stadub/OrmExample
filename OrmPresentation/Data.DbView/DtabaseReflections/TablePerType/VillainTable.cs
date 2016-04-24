using Data.Entity;

namespace Data.DbView.DtabaseReflections.TablePerType
{
    public class VillainTable : SuperHeroTable
    {
        public virtual int Id { get; set; }
        public virtual VillainClan Clan { get; set;}
    }
}
