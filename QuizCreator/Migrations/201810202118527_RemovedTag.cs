namespace QuizCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedTag : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Questions", "TagId", "dbo.Tags");
            DropIndex("dbo.Questions", new[] { "TagId" });
            DropColumn("dbo.Questions", "TagId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "TagId", c => c.Int(nullable: false));
            CreateIndex("dbo.Questions", "TagId");
            AddForeignKey("dbo.Questions", "TagId", "dbo.Tags", "Id", cascadeDelete: true);
        }
    }
}
