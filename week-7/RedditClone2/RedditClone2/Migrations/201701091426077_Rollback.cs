namespace RedditClone2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rollback : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Votes", "PostId", "dbo.RedditPosts");
            DropForeignKey("dbo.Votes", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Votes", new[] { "UserId" });
            DropIndex("dbo.Votes", new[] { "PostId" });
            AddColumn("dbo.RedditPosts", "Upvotes", c => c.Int(nullable: false));
            AddColumn("dbo.RedditPosts", "Downvotes", c => c.Int(nullable: false));
            DropTable("dbo.Votes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Weight = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                        PostId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.RedditPosts", "Downvotes");
            DropColumn("dbo.RedditPosts", "Upvotes");
            CreateIndex("dbo.Votes", "PostId");
            CreateIndex("dbo.Votes", "UserId");
            AddForeignKey("dbo.Votes", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Votes", "PostId", "dbo.RedditPosts", "Id", cascadeDelete: true);
        }
    }
}
