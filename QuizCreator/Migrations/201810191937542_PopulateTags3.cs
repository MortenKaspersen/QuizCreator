namespace QuizCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTags3 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Tags ON");
            Sql("INSERT INTO Tags (Id, Name) VALUES (1, 'Anatomi')");
            Sql("INSERT INTO Tags (Id, Name) VALUES (2, 'Genetik')");
            Sql("INSERT INTO Tags (Id, Name) VALUES (3, 'Fysiologi')");
            Sql("SET IDENTITY_INSERT Tags OFF");
        }

        public override void Down()
        {
        }
    }
}
