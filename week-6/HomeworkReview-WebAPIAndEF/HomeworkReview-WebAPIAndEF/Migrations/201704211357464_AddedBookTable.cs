namespace HomeworkReview_WebAPIAndEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBookTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author = c.String(),
                        DateAddedToLibrary = c.DateTime(nullable: false),
                        DateCheckedOut = c.DateTime(),
                        DueBackDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}