namespace UnivertsyManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgltable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LessonStuationForGradudations",
                c => new
                    {
                        LessonStuationForGradudationID = c.Int(nullable: false, identity: true),
                        LessonID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        IsPassed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LessonStuationForGradudationID)
                .ForeignKey("dbo.Lessons", t => t.LessonID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.LessonID)
                .Index(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LessonStuationForGradudations", "StudentID", "dbo.Students");
            DropForeignKey("dbo.LessonStuationForGradudations", "LessonID", "dbo.Lessons");
            DropIndex("dbo.LessonStuationForGradudations", new[] { "StudentID" });
            DropIndex("dbo.LessonStuationForGradudations", new[] { "LessonID" });
            DropTable("dbo.LessonStuationForGradudations");
        }
    }
}
