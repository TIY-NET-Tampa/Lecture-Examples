namespace Homereview__Events.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTicketsAndOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BarCode = c.Guid(nullable: false),
                        DatePurchased = c.DateTime(nullable: false),
                        PurchasedPrice = c.Double(nullable: false),
                        WasUsed = c.Boolean(nullable: false),
                        EventId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EventModels", t => t.EventId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.EventId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeCreated = c.DateTime(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            AddColumn("dbo.EventModels", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Tickets", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Tickets", "EventId", "dbo.EventModels");
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropIndex("dbo.Tickets", new[] { "OrderId" });
            DropIndex("dbo.Tickets", new[] { "EventId" });
            DropColumn("dbo.EventModels", "Price");
            DropTable("dbo.Orders");
            DropTable("dbo.Tickets");
        }
    }
}
