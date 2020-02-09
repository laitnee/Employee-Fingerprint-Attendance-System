namespace FingerprintAttendanceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employeeIdToStaffId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AttendanceRegisters", "Staff_StaffId", "dbo.Staffs");
            DropIndex("dbo.AttendanceRegisters", new[] { "Staff_StaffId" });
            RenameColumn(table: "dbo.AttendanceRegisters", name: "Staff_StaffId", newName: "StaffId");
            AlterColumn("dbo.AttendanceRegisters", "StaffId", c => c.Int(nullable: false));
            CreateIndex("dbo.AttendanceRegisters", "StaffId");
            AddForeignKey("dbo.AttendanceRegisters", "StaffId", "dbo.Staffs", "StaffId", cascadeDelete: true);
            DropColumn("dbo.AttendanceRegisters", "EmployeeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AttendanceRegisters", "EmployeeId", c => c.Int(nullable: false));
            DropForeignKey("dbo.AttendanceRegisters", "StaffId", "dbo.Staffs");
            DropIndex("dbo.AttendanceRegisters", new[] { "StaffId" });
            AlterColumn("dbo.AttendanceRegisters", "StaffId", c => c.Int());
            RenameColumn(table: "dbo.AttendanceRegisters", name: "StaffId", newName: "Staff_StaffId");
            CreateIndex("dbo.AttendanceRegisters", "Staff_StaffId");
            AddForeignKey("dbo.AttendanceRegisters", "Staff_StaffId", "dbo.Staffs", "StaffId");
        }
    }
}
