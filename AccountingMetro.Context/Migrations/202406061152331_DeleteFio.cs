namespace AccountingMetro.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteFio : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.StaffDeparts", "FIO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StaffDeparts", "FIO", c => c.String(nullable: false));
        }
    }
}
