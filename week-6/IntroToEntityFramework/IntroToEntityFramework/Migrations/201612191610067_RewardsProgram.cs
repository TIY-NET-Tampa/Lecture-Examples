namespace IntroToEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RewardsProgram : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "RewardPoints", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "RewardPoints");
        }
    }
}
