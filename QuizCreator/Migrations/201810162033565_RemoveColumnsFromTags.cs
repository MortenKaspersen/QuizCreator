namespace QuizCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveColumnsFromTags : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tags", "Anatomi");
            DropColumn("dbo.Tags", "Genetik");
            DropColumn("dbo.Tags", "Fysiologi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tags", "Fysiologi", c => c.Int(nullable: false));
            AddColumn("dbo.Tags", "Genetik", c => c.Int(nullable: false));
            AddColumn("dbo.Tags", "Anatomi", c => c.Int(nullable: false));
        }
    }
}
