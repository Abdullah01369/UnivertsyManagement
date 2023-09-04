namespace UnivertsyManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgpro : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "DepartmentNum", c => c.String());
            AddColumn("dbo.Faculties", "FacultyNum", c => c.String());
        }
        
        public override void Down()
        {
           
        }
    }
}
