using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace Data.NHibernate.Migration
{
    [Migration(1)]
    public class M0001_CreateMemberTable : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table("SuperHero")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Name").AsString(50)
                .WithColumn("Gender").AsInt32();
        }

        public override void Down()
        {
            Delete.Table("SuperHero");
        }
    }
}
