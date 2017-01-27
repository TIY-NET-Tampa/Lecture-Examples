namespace ResturantDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSchema : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MenuItems", "Order_Id", "dbo.Orders");
            DropIndex("dbo.MenuItems", new[] { "Order_Id" });
            CreateTable(
                "dbo.OrderMenuItems",
                c => new
                    {
                        Order_Id = c.Int(nullable: false),
                        MenuItem_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Order_Id, t.MenuItem_Id })
                .ForeignKey("dbo.Orders", t => t.Order_Id, cascadeDelete: true)
                .ForeignKey("dbo.MenuItems", t => t.MenuItem_Id, cascadeDelete: true)
                .Index(t => t.Order_Id)
                .Index(t => t.MenuItem_Id);
            
            DropColumn("dbo.MenuItems", "Order_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MenuItems", "Order_Id", c => c.Int());
            DropForeignKey("dbo.OrderMenuItems", "MenuItem_Id", "dbo.MenuItems");
            DropForeignKey("dbo.OrderMenuItems", "Order_Id", "dbo.Orders");
            DropIndex("dbo.OrderMenuItems", new[] { "MenuItem_Id" });
            DropIndex("dbo.OrderMenuItems", new[] { "Order_Id" });
            DropTable("dbo.OrderMenuItems");
            CreateIndex("dbo.MenuItems", "Order_Id");
            AddForeignKey("dbo.MenuItems", "Order_Id", "dbo.Orders", "Id");
        }
    }
}
