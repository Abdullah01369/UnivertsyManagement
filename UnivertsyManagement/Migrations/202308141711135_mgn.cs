namespace UnivertsyManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consultants",
                c => new
                    {
                        ConsultantID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        TC = c.String(),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ConsultantID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
           
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "AcademicianID", "dbo.Academicians");
            DropForeignKey("dbo.Consultants", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "AcademicianID" });
            DropIndex("dbo.Consultants", new[] { "DepartmentID" });
            DropColumn("dbo.Students", "AcademicianID");
            DropTable("dbo.Consultants");
        }
    }
}
