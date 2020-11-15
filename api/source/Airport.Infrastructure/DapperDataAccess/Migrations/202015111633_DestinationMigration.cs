using FluentMigrator;

namespace Airport.Infrastructure.DapperDataAccess.Migrations
{
    [Migration(202015111633, TransactionBehavior.None)]
    public class DestinationMigration : Migration
    {
        public override void Up()
        {
            Create.Table("destinations")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("airlineid").AsInt32()
                .WithColumn("country").AsString();

            Create.ForeignKey() 
                .FromTable("destinations").ForeignColumn("airlineid")
                .ToTable("airlines").PrimaryColumn("id");
        }

        public override void Down()
        {
            Delete.Table("destinations");
        }
    }
}