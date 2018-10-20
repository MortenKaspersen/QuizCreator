namespace QuizCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUserFromQuestion : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Questions", "UserId", "dbo.Users");
            DropIndex("dbo.Questions", new[] { "UserId" });
            DropColumn("dbo.Questions", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Questions", "UserId");
            AddForeignKey("dbo.Questions", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
