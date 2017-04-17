namespace IntroToEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "HomeTownId", c => c.Int());
            CreateIndex("dbo.People", "HomeTownId");
            AddForeignKey("dbo.People", "HomeTownId", "dbo.Hometowns", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "HomeTownId", "dbo.Hometowns");
            DropIndex("dbo.People", new[] { "HomeTownId" });
            DropColumn("dbo.People", "HomeTownId");
        }
    }
}
