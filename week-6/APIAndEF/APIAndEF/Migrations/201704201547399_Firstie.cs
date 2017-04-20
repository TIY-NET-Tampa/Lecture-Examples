namespace APIAndEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Firstie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sandwhiches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Bread = c.String(),
                        MainItem = c.String(),
                        HasLettuce = c.Boolean(nullable: false),
                        Cheese = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sandwhiches");
        }
    }
}
