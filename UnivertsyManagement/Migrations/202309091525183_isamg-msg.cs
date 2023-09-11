namespace UnivertsyManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isamgmsg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        AcademicianID = c.Int(),
                        StudentID = c.Int(),
                        MessageTitle = c.String(),
                        MessageContent = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.Academicians", t => t.AcademicianID)
                .ForeignKey("dbo.Students", t => t.StudentID)
                .Index(t => t.AcademicianID)
                .Index(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Messages", "AcademicianID", "dbo.Academicians");
            DropIndex("dbo.Messages", new[] { "StudentID" });
            DropIndex("dbo.Messages", new[] { "AcademicianID" });
            DropTable("dbo.Messages");
        }
    }
}
