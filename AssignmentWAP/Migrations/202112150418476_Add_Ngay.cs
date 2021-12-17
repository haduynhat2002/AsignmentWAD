namespace AssignmentWAP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Ngay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "NgayNopPhat", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "NgayNopPhat");
        }
    }
}
