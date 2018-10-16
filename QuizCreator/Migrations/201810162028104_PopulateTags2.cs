namespace QuizCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTags2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Tags SET Name = 'Dude' WHERE ID = 1");

            
        }

        public override void Down()
        {
        }
    }
}
