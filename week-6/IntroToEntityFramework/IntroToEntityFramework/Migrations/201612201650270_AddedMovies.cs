namespace IntroToEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMovies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MoviesCustomers",
                c => new
                    {
                        Movies_Id = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movies_Id, t.Customer_Id })
                .ForeignKey("dbo.Movies", t => t.Movies_Id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Movies_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MoviesCustomers", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.MoviesCustomers", "Movies_Id", "dbo.Movies");
            DropIndex("dbo.MoviesCustomers", new[] { "Customer_Id" });
            DropIndex("dbo.MoviesCustomers", new[] { "Movies_Id" });
            DropTable("dbo.MoviesCustomers");
            DropTable("dbo.Movies");
        }
    }
}
