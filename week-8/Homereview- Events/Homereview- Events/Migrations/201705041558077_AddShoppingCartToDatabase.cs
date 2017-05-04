namespace Homereview__Events.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShoppingCartToDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Tickets", "DatePurchased", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tickets", "DatePurchased", c => c.DateTime(nullable: false));
            DropColumn("dbo.Orders", "Discriminator");
        }
    }
}
