namespace IntroToEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCitiesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hometowns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        State = c.String(),
                        Population = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hometowns");
        }
    }
}
