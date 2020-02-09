namespace FingerprintAttendanceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pictureadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Staffs", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Staffs", "ImageUrl");
        }
    }
}
