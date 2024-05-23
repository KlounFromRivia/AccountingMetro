namespace AccountingMetro.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountMetroDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Divisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        DivisionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Divisions", t => t.DivisionId, cascadeDelete: true)
                .Index(t => t.DivisionId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        ContractDay = c.DateTime(nullable: false),
                        EmploymentDay = c.DateTime(nullable: false),
                        PhoneWork = c.String(),
                        PostId = c.Int(nullable: false),
                        StationId = c.Int(nullable: false),
                        TrainId = c.Int(),
                        NormShift = c.Int(nullable: false),
                        Salary = c.Int(nullable: false),
                        Allowance = c.Int(nullable: false),
                        Vacation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .ForeignKey("dbo.Stations", t => t.StationId, cascadeDelete: true)
                .ForeignKey("dbo.Trains", t => t.TrainId)
                .Index(t => t.PersonId)
                .Index(t => t.PostId)
                .Index(t => t.StationId)
                .Index(t => t.TrainId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        Patronymic = c.String(),
                        BirthDay = c.DateTime(nullable: false),
                        ImagePreview = c.Binary(),
                        Phone = c.String(),
                        Email = c.String(),
                        ResidentAddress = c.String(),
                        GenderId = c.Int(nullable: false),
                        StatusMariId = c.Int(nullable: false),
                        DocumentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Documents", t => t.DocumentId, cascadeDelete: true)
                .ForeignKey("dbo.Genders", t => t.GenderId, cascadeDelete: true)
                .ForeignKey("dbo.StatusMaris", t => t.StatusMariId, cascadeDelete: true)
                .Index(t => t.GenderId)
                .Index(t => t.StatusMariId)
                .Index(t => t.DocumentId);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PassportSeries = c.String(),
                        PassportNomer = c.String(nullable: false),
                        Issued = c.String(),
                        DateIssued = c.DateTime(nullable: false),
                        INN = c.String(nullable: false),
                        InsCertific = c.String(nullable: false),
                        RegistratAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StatusMaris",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        VetkaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vetkas", t => t.VetkaId, cascadeDelete: true)
                .Index(t => t.VetkaId);
            
            CreateTable(
                "dbo.Vetkas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nomer = c.String(),
                        StatusTrainId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StatusTrains", t => t.StatusTrainId, cascadeDelete: true)
                .Index(t => t.StatusTrainId);
            
            CreateTable(
                "dbo.StatusTrains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        ShiftOpened = c.DateTimeOffset(nullable: false, precision: 7),
                        ShiftClosed = c.DateTimeOffset(precision: 7),
                        StatusChangeId = c.Int(nullable: false),
                        Employee_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .ForeignKey("dbo.StatusShifts", t => t.StatusChangeId, cascadeDelete: true)
                .Index(t => t.StatusChangeId)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.StatusShifts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StaffDeparts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Employee_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StaffDeparts", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Shifts", "StatusChangeId", "dbo.StatusShifts");
            DropForeignKey("dbo.Shifts", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Trains", "StatusTrainId", "dbo.StatusTrains");
            DropForeignKey("dbo.Employees", "TrainId", "dbo.Trains");
            DropForeignKey("dbo.Stations", "VetkaId", "dbo.Vetkas");
            DropForeignKey("dbo.Employees", "StationId", "dbo.Stations");
            DropForeignKey("dbo.Employees", "PostId", "dbo.Posts");
            DropForeignKey("dbo.People", "StatusMariId", "dbo.StatusMaris");
            DropForeignKey("dbo.People", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.Employees", "PersonId", "dbo.People");
            DropForeignKey("dbo.People", "DocumentId", "dbo.Documents");
            DropForeignKey("dbo.Posts", "DivisionId", "dbo.Divisions");
            DropIndex("dbo.StaffDeparts", new[] { "Employee_Id" });
            DropIndex("dbo.Shifts", new[] { "Employee_Id" });
            DropIndex("dbo.Shifts", new[] { "StatusChangeId" });
            DropIndex("dbo.Trains", new[] { "StatusTrainId" });
            DropIndex("dbo.Stations", new[] { "VetkaId" });
            DropIndex("dbo.People", new[] { "DocumentId" });
            DropIndex("dbo.People", new[] { "StatusMariId" });
            DropIndex("dbo.People", new[] { "GenderId" });
            DropIndex("dbo.Employees", new[] { "TrainId" });
            DropIndex("dbo.Employees", new[] { "StationId" });
            DropIndex("dbo.Employees", new[] { "PostId" });
            DropIndex("dbo.Employees", new[] { "PersonId" });
            DropIndex("dbo.Posts", new[] { "DivisionId" });
            DropTable("dbo.StaffDeparts");
            DropTable("dbo.StatusShifts");
            DropTable("dbo.Shifts");
            DropTable("dbo.StatusTrains");
            DropTable("dbo.Trains");
            DropTable("dbo.Vetkas");
            DropTable("dbo.Stations");
            DropTable("dbo.StatusMaris");
            DropTable("dbo.Genders");
            DropTable("dbo.Documents");
            DropTable("dbo.People");
            DropTable("dbo.Employees");
            DropTable("dbo.Posts");
            DropTable("dbo.Divisions");
        }
    }
}
