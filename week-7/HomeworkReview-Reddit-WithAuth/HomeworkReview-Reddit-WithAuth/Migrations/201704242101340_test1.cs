namespace HomeworkReview_Reddit_WithAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PostModels", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.PostModels", new[] { "UserId" });
            DropTable("dbo.PostModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PostModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        TimePosted = c.DateTime(nullable: false),
                        UpVote = c.Int(nullable: false),
                        DownVote = c.Int(nullable: false),
                        ImageUrl = c.String(),
                        Body = c.String(),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.PostModels", "UserId");
            AddForeignKey("dbo.PostModels", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
