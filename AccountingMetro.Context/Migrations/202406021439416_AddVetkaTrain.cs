namespace AccountingMetro.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVetkaTrain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trains", "VetkaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Trains", "VetkaId");
            AddForeignKey("dbo.Trains", "VetkaId", "dbo.Vetkas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trains", "VetkaId", "dbo.Vetkas");
            DropIndex("dbo.Trains", new[] { "VetkaId" });
            DropColumn("dbo.Trains", "VetkaId");
        }
    }
}
