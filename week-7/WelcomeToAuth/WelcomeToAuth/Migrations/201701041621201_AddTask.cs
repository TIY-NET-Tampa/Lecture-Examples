namespace WelcomeToAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddTask : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskItems",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Description = c.String(),
                    IsCompleted = c.Boolean(nullable: false),
                    DateCreated = c.DateTime(),
                    DateCompleted = c.DateTime(),
                    UserId = c.String(maxLength: 128),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
        }

        public override void Down()
        {
            DropForeignKey("dbo.TaskItems", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.TaskItems", new[] { "UserId" });
            DropTable("dbo.TaskItems");
        }
    }
}
