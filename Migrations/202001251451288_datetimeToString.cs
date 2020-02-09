namespace FingerprintAttendanceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetimeToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AttendanceRegisters", "ArrivalTime", c => c.String());
            AlterColumn("dbo.AttendanceRegisters", "DepartureTime", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AttendanceRegisters", "DepartureTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AttendanceRegisters", "ArrivalTime", c => c.DateTime(nullable: false));
        }
    }
}
