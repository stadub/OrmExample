using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Data.Entity;

namespace Data.EF6
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name).IsRequired();
        }
    }
}