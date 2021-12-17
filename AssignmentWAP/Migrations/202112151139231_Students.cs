namespace AssignmentWAP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Students : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "SoChongDay", c => c.String());
            AlterColumn("dbo.Students", "SoTienNopPhat", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "SoTienNopPhat", c => c.Int(nullable: false));
            DropColumn("dbo.Students", "SoChongDay");
        }
    }
}
