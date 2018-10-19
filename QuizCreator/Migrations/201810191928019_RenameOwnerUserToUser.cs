namespace QuizCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameOwnerUserToUser : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.OwnerUsers", newName: "Users");
            DropForeignKey("dbo.Questions", "OwnerUserId", "dbo.OwnerUsers");
            DropIndex("dbo.Questions", new[] { "OwnerUserId" });
            AddColumn("dbo.Questions", "User_Id", c => c.Int());
            CreateIndex("dbo.Questions", "User_Id");
            AddForeignKey("dbo.Questions", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "User_Id", "dbo.Users");
            DropIndex("dbo.Questions", new[] { "User_Id" });
            DropColumn("dbo.Questions", "User_Id");
            CreateIndex("dbo.Questions", "OwnerUserId");
            AddForeignKey("dbo.Questions", "OwnerUserId", "dbo.OwnerUsers", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.Users", newName: "OwnerUsers");
        }
    }
}
