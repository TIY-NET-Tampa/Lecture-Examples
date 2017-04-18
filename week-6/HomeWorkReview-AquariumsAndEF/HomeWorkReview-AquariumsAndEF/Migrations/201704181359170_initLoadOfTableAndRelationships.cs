namespace HomeWorkReview_AquariumsAndEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initLoadOfTableAndRelationships : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AquariumAquaticLifeOcean",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AquariumId = c.Int(nullable: false),
                        AquaticLifeId = c.Int(nullable: false),
                        OceanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aquarium", t => t.AquariumId, cascadeDelete: true)
                .ForeignKey("dbo.AquaticLIfe", t => t.AquaticLifeId, cascadeDelete: true)
                .ForeignKey("dbo.Ocean", t => t.OceanId, cascadeDelete: true)
                .Index(t => t.AquariumId)
                .Index(t => t.AquaticLifeId)
                .Index(t => t.OceanId);
            
            CreateTable(
                "dbo.Aquarium",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AquaticLIfe",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Color = c.String(),
                        Name = c.String(),
                        DataAddedToTank = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ocean",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AverageTemp = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AquariumAquaticLifeOcean", "OceanId", "dbo.Ocean");
            DropForeignKey("dbo.AquariumAquaticLifeOcean", "AquaticLifeId", "dbo.AquaticLIfe");
            DropForeignKey("dbo.AquariumAquaticLifeOcean", "AquariumId", "dbo.Aquarium");
            DropIndex("dbo.AquariumAquaticLifeOcean", new[] { "OceanId" });
            DropIndex("dbo.AquariumAquaticLifeOcean", new[] { "AquaticLifeId" });
            DropIndex("dbo.AquariumAquaticLifeOcean", new[] { "AquariumId" });
            DropTable("dbo.Ocean");
            DropTable("dbo.AquaticLIfe");
            DropTable("dbo.Aquarium");
            DropTable("dbo.AquariumAquaticLifeOcean");
        }
    }
}
