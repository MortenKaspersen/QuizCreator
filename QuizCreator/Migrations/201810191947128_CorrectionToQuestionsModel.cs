namespace QuizCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectionToQuestionsModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Questions", "User_Id", "dbo.Users");
            DropIndex("dbo.Questions", new[] { "User_Id" });
            RenameColumn(table: "dbo.Questions", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.Questions", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Questions", "UserId");
            AddForeignKey("dbo.Questions", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            DropColumn("dbo.Questions", "OwnerUserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "OwnerUserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Questions", "UserId", "dbo.Users");
            DropIndex("dbo.Questions", new[] { "UserId" });
            AlterColumn("dbo.Questions", "UserId", c => c.Int());
            RenameColumn(table: "dbo.Questions", name: "UserId", newName: "User_Id");
            CreateIndex("dbo.Questions", "User_Id");
            AddForeignKey("dbo.Questions", "User_Id", "dbo.Users", "Id");
        }
    }
}
