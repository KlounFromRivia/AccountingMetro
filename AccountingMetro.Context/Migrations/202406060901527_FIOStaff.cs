namespace AccountingMetro.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FIOStaff : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StaffDeparts", "FIO", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StaffDeparts", "FIO");
        }
    }
}
