namespace RedditClone2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedUnNeededPKForVote : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Votes", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Votes", new[] { "UserId" });
            DropPrimaryKey("dbo.Votes");
            AlterColumn("dbo.Votes", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Votes", new[] { "UserId", "PostId" });
            CreateIndex("dbo.Votes", "UserId");
            AddForeignKey("dbo.Votes", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            DropColumn("dbo.Votes", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Votes", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Votes", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Votes", new[] { "UserId" });
            DropPrimaryKey("dbo.Votes");
            AlterColumn("dbo.Votes", "UserId", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Votes", "Id");
            CreateIndex("dbo.Votes", "UserId");
            AddForeignKey("dbo.Votes", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
