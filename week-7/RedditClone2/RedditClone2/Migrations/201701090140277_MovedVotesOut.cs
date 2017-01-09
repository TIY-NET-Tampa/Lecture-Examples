namespace RedditClone2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovedVotesOut : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.RedditPosts", "Upvotes");
            DropColumn("dbo.RedditPosts", "Downvotes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RedditPosts", "Downvotes", c => c.Int(nullable: false));
            AddColumn("dbo.RedditPosts", "Upvotes", c => c.Int(nullable: false));
        }
    }
}
