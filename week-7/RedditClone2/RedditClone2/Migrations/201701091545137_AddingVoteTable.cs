namespace RedditClone2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingVoteTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        PostId = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RedditPosts", t => t.PostId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.PostId);
            
            DropColumn("dbo.RedditPosts", "Upvotes");
            DropColumn("dbo.RedditPosts", "Downvotes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RedditPosts", "Downvotes", c => c.Int(nullable: false));
            AddColumn("dbo.RedditPosts", "Upvotes", c => c.Int(nullable: false));
            DropForeignKey("dbo.Votes", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Votes", "PostId", "dbo.RedditPosts");
            DropIndex("dbo.Votes", new[] { "PostId" });
            DropIndex("dbo.Votes", new[] { "UserId" });
            DropTable("dbo.Votes");
        }
    }
}
