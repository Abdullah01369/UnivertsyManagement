namespace UnivertsyManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class academician_prop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Academicians", "GenderID", c => c.Int());
            AddColumn("dbo.Academicians", "Birthdate", c => c.String());
            CreateIndex("dbo.Academicians", "GenderID");
            AddForeignKey("dbo.Academicians", "GenderID", "dbo.Genders", "GenderID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Academicians", "GenderID", "dbo.Genders");
            DropIndex("dbo.Academicians", new[] { "GenderID" });
            DropColumn("dbo.Academicians", "Birthdate");
            DropColumn("dbo.Academicians", "GenderID");
        }
    }
}
