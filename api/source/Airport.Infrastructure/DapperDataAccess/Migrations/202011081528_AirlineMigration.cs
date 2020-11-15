using FluentMigrator;
namespace Airport.Infrastructure.DapperDataAccess.Migrations
{
    [Migration(202011081528, TransactionBehavior.None)]
    public class AirlineMigration : Migration
    {
        public override void Up()
        {
            Create.Table("airlines")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("name").AsString()
                .WithColumn("description").AsString();
        }
        public override void Down()
        {
            Delete.Table("airlines");
        }
    }
}