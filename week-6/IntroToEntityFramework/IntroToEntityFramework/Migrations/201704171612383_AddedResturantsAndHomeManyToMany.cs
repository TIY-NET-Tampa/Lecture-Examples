namespace IntroToEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedResturantsAndHomeManyToMany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Resturans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ResturansHometowns",
                c => new
                    {
                        Resturans_Id = c.Int(nullable: false),
                        Hometown_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Resturans_Id, t.Hometown_Id })
                .ForeignKey("dbo.Resturans", t => t.Resturans_Id, cascadeDelete: true)
                .ForeignKey("dbo.Hometowns", t => t.Hometown_Id, cascadeDelete: true)
                .Index(t => t.Resturans_Id)
                .Index(t => t.Hometown_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ResturansHometowns", "Hometown_Id", "dbo.Hometowns");
            DropForeignKey("dbo.ResturansHometowns", "Resturans_Id", "dbo.Resturans");
            DropIndex("dbo.ResturansHometowns", new[] { "Hometown_Id" });
            DropIndex("dbo.ResturansHometowns", new[] { "Resturans_Id" });
            DropTable("dbo.ResturansHometowns");
            DropTable("dbo.Resturans");
        }
    }
}
