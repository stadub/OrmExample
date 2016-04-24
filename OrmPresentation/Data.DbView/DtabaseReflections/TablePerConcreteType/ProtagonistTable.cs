using Data.Entity;

namespace Data.DbView.DtabaseReflections.TablePerConcreteType
{
    public class ProtagonistTable
    {
        public virtual int Id { get; set; }
        public SuperPower SuperPower { get; set; }
        public virtual string Name { get; set; }
        public virtual HeroGender Gender { get; set; }
    }
}
