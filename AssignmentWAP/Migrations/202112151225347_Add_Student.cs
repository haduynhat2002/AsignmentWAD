namespace AssignmentWAP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Student : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "TienNopPhat", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "ChongDay", c => c.Int(nullable: false));
            DropColumn("dbo.Students", "SoTienNopPhat");
            DropColumn("dbo.Students", "SoChongDay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "SoChongDay", c => c.String());
            AddColumn("dbo.Students", "SoTienNopPhat", c => c.String());
            DropColumn("dbo.Students", "ChongDay");
            DropColumn("dbo.Students", "TienNopPhat");
        }
    }
}
