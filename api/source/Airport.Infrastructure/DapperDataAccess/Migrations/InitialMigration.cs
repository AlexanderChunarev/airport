using FluentMigrator;
namespace Airport.Infrastructure.DapperDataAccess.Migrations
{
    [Migration(20201107, TransactionBehavior.None)]
    public class InitialMigration : Migration
    {
        public override void Up()
        {
            Create.Table("init_table")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("title").AsString();
        }
        public override void Down()
        {
            Delete.Table("init_table");
        }
    }
}