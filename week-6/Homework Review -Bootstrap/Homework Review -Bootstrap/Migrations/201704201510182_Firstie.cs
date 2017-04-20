namespace Homework_Review__Bootstrap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Firstie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HomeTeam = c.String(),
                        AwayTeam = c.String(),
                        HomeScore = c.Int(nullable: false),
                        AwayScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
        }
    }
}
