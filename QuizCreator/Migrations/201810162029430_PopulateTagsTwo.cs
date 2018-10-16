namespace QuizCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTagsTwo : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Tags SET Name = 'Anatomi' WHERE ID = 1");
        }
        
        public override void Down()
        {
        }
    }
}
