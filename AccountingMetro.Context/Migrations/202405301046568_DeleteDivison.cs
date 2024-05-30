namespace AccountingMetro.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteDivison : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "DivisionId", "dbo.Divisions");
            DropForeignKey("dbo.Shifts", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.StaffDeparts", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.Posts", new[] { "DivisionId" });
            DropIndex("dbo.Shifts", new[] { "Employee_Id" });
            DropIndex("dbo.StaffDeparts", new[] { "Employee_Id" });
            DropColumn("dbo.Shifts", "EmployeeId");
            DropColumn("dbo.StaffDeparts", "EmployeeId");
            RenameColumn(table: "dbo.Shifts", name: "Employee_Id", newName: "EmployeeId");
            RenameColumn(table: "dbo.StaffDeparts", name: "Employee_Id", newName: "EmployeeId");
            DropPrimaryKey("dbo.Employees");
            CreateTable(
                "dbo.StatusStations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Stations", "StatusStationId", c => c.Int(nullable: false));
            AddColumn("dbo.StaffDeparts", "Salt", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Employees", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Shifts", "ShiftOpened", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Shifts", "ShiftClosed", c => c.DateTime());
            AlterColumn("dbo.Shifts", "EmployeeId", c => c.Int(nullable: false));
            AlterColumn("dbo.StaffDeparts", "EmployeeId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Employees", "Id");
            CreateIndex("dbo.Stations", "StatusStationId");
            CreateIndex("dbo.Shifts", "EmployeeId");
            CreateIndex("dbo.StaffDeparts", "EmployeeId");
            AddForeignKey("dbo.Stations", "StatusStationId", "dbo.StatusStations", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Shifts", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StaffDeparts", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            DropColumn("dbo.Posts", "DivisionId");
            DropTable("dbo.Divisions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Divisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Posts", "DivisionId", c => c.Int(nullable: false));
            DropForeignKey("dbo.StaffDeparts", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Shifts", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Stations", "StatusStationId", "dbo.StatusStations");
            DropIndex("dbo.StaffDeparts", new[] { "EmployeeId" });
            DropIndex("dbo.Shifts", new[] { "EmployeeId" });
            DropIndex("dbo.Stations", new[] { "StatusStationId" });
            DropPrimaryKey("dbo.Employees");
            AlterColumn("dbo.StaffDeparts", "EmployeeId", c => c.Long());
            AlterColumn("dbo.Shifts", "EmployeeId", c => c.Long());
            AlterColumn("dbo.Shifts", "ShiftClosed", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.Shifts", "ShiftOpened", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Employees", "Id", c => c.Long(nullable: false, identity: true));
            DropColumn("dbo.StaffDeparts", "Salt");
            DropColumn("dbo.Stations", "StatusStationId");
            DropTable("dbo.StatusStations");
            AddPrimaryKey("dbo.Employees", "Id");
            RenameColumn(table: "dbo.StaffDeparts", name: "EmployeeId", newName: "Employee_Id");
            RenameColumn(table: "dbo.Shifts", name: "EmployeeId", newName: "Employee_Id");
            AddColumn("dbo.StaffDeparts", "EmployeeId", c => c.Int(nullable: false));
            AddColumn("dbo.Shifts", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.StaffDeparts", "Employee_Id");
            CreateIndex("dbo.Shifts", "Employee_Id");
            CreateIndex("dbo.Posts", "DivisionId");
            AddForeignKey("dbo.StaffDeparts", "Employee_Id", "dbo.Employees", "Id");
            AddForeignKey("dbo.Shifts", "Employee_Id", "dbo.Employees", "Id");
            AddForeignKey("dbo.Posts", "DivisionId", "dbo.Divisions", "Id", cascadeDelete: true);
        }
    }
}
