using Data.Entity;

namespace Data.DbView.DtabaseReflections.TablePerType
{
    public class ProtagonistTable : SuperHeroTable
    {
        public virtual int Id { get; set; }
        public SuperPower SuperPower { get; set; }
    }
}
