using FluentMigrator;

 namespace Airport.Infrastructure.DapperDataAccess.Migrations
{
    [Migration(202014111148, TransactionBehavior.None)]
    public class PlaneMigration : Migration
    {
        public override void Up()
        {
            Create.Table("planes")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("airlineid").AsInt32()
                .WithColumn("name").AsString()
                .WithColumn("description").AsString();
            
            Create.ForeignKey() 
                .FromTable("planes").ForeignColumn("airlineid")
                .ToTable("airlines").PrimaryColumn("id");
        }

        public override void Down()
        {
            Delete.Table("planes");
        }
    }
}