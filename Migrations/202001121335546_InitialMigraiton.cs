namespace FingerprintAttendanceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigraiton : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AttendanceRegisters",
                c => new
                    {
                        AttendanceRegisterId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        ArrivalTime = c.DateTime(nullable: false),
                        DepartureTime = c.DateTime(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        Remark = c.String(),
                        Staff_StaffId = c.Int(),
                    })
                .PrimaryKey(t => t.AttendanceRegisterId)
                .ForeignKey("dbo.Staffs", t => t.Staff_StaffId)
                .Index(t => t.Staff_StaffId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Middlename = c.String(),
                        Lastname = c.String(),
                        Department = c.String(),
                        OnLeave = c.Boolean(nullable: false),
                        Fingerprint = c.Binary(),
                    })
                .PrimaryKey(t => t.StaffId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AttendanceRegisters", "Staff_StaffId", "dbo.Staffs");
            DropIndex("dbo.AttendanceRegisters", new[] { "Staff_StaffId" });
            DropTable("dbo.Staffs");
            DropTable("dbo.AttendanceRegisters");
        }
    }
}
