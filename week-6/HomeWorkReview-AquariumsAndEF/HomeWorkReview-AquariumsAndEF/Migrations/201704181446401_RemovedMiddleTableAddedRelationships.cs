namespace HomeWorkReview_AquariumsAndEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedMiddleTableAddedRelationships : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AquariumAquaticLifeOcean", "AquariumId", "dbo.Aquarium");
            DropForeignKey("dbo.AquariumAquaticLifeOcean", "AquaticLifeId", "dbo.AquaticLIfe");
            DropForeignKey("dbo.AquariumAquaticLifeOcean", "OceanId", "dbo.Ocean");
            DropIndex("dbo.AquariumAquaticLifeOcean", new[] { "AquariumId" });
            DropIndex("dbo.AquariumAquaticLifeOcean", new[] { "AquaticLifeId" });
            DropIndex("dbo.AquariumAquaticLifeOcean", new[] { "OceanId" });
            CreateTable(
                "dbo.AquaticLIfeAquarium",
                c => new
                    {
                        AquaticLIfe_Id = c.Int(nullable: false),
                        Aquarium_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AquaticLIfe_Id, t.Aquarium_Id })
                .ForeignKey("dbo.AquaticLIfe", t => t.AquaticLIfe_Id, cascadeDelete: true)
                .ForeignKey("dbo.Aquarium", t => t.Aquarium_Id, cascadeDelete: true)
                .Index(t => t.AquaticLIfe_Id)
                .Index(t => t.Aquarium_Id);
            
            CreateTable(
                "dbo.OceanAquaticLIfe",
                c => new
                    {
                        Ocean_Id = c.Int(nullable: false),
                        AquaticLIfe_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ocean_Id, t.AquaticLIfe_Id })
                .ForeignKey("dbo.Ocean", t => t.Ocean_Id, cascadeDelete: true)
                .ForeignKey("dbo.AquaticLIfe", t => t.AquaticLIfe_Id, cascadeDelete: true)
                .Index(t => t.Ocean_Id)
                .Index(t => t.AquaticLIfe_Id);
            
            DropTable("dbo.AquariumAquaticLifeOcean");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.OceanAquaticLIfe", "AquaticLIfe_Id", "dbo.AquaticLIfe");
            DropForeignKey("dbo.OceanAquaticLIfe", "Ocean_Id", "dbo.Ocean");
            DropForeignKey("dbo.AquaticLIfeAquarium", "Aquarium_Id", "dbo.Aquarium");
            DropForeignKey("dbo.AquaticLIfeAquarium", "AquaticLIfe_Id", "dbo.AquaticLIfe");
            DropIndex("dbo.OceanAquaticLIfe", new[] { "AquaticLIfe_Id" });
            DropIndex("dbo.OceanAquaticLIfe", new[] { "Ocean_Id" });
            DropIndex("dbo.AquaticLIfeAquarium", new[] { "Aquarium_Id" });
            DropIndex("dbo.AquaticLIfeAquarium", new[] { "AquaticLIfe_Id" });
            DropTable("dbo.OceanAquaticLIfe");
            DropTable("dbo.AquaticLIfeAquarium");
            CreateIndex("dbo.AquariumAquaticLifeOcean", "OceanId");
            CreateIndex("dbo.AquariumAquaticLifeOcean", "AquaticLifeId");
            CreateIndex("dbo.AquariumAquaticLifeOcean", "AquariumId");
            AddForeignKey("dbo.AquariumAquaticLifeOcean", "OceanId", "dbo.Ocean", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AquariumAquaticLifeOcean", "AquaticLifeId", "dbo.AquaticLIfe", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AquariumAquaticLifeOcean", "AquariumId", "dbo.Aquarium", "Id", cascadeDelete: true);
        }
    }
}
