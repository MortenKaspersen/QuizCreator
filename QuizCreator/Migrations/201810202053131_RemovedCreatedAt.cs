namespace QuizCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedCreatedAt : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Questions", "CreatedAt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "CreatedAt", c => c.DateTime(nullable: false));
        }
    }
}
