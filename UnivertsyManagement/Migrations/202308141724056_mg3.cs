namespace UnivertsyManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "ConsultantID", c => c.Int());
            CreateIndex("dbo.Students", "ConsultantID");
            AddForeignKey("dbo.Students", "ConsultantID", "dbo.Consultants", "ConsultantID");
        }
        
        public override void Down()
        {
          
        }
    }
}
