using Data.Entity;

namespace Data.DbView.DtabaseReflections.TablePerType
{
    public class SuperHeroTable
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual HeroGender Gender { get; set; }
    }
}
