namespace UnivertsyManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgn6 : DbMigration
    {
        public override void Up()
        {
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "AcademicianID", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "AcademicianID");
            AddForeignKey("dbo.Students", "AcademicianID", "dbo.Academicians", "AcademicianID", cascadeDelete: true);
        }
    }
}
