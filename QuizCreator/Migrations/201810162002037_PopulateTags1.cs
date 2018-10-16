using System.Diagnostics.Eventing.Reader;
using System.Web.UI.WebControls;

namespace QuizCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTags1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tags", "Anatomi", c => c.Int(nullable: false));
            AlterColumn("dbo.Tags", "Genetik", c => c.Int(nullable: false));
            AlterColumn("dbo.Tags", "Fysiologi", c => c.Int(nullable: false));

            
        }

        public override void Down()
        {
            AlterColumn("dbo.Tags", "Fysiologi", c => c.String());
            AlterColumn("dbo.Tags", "Genetik", c => c.String());
            AlterColumn("dbo.Tags", "Anatomi", c => c.String());
        }
    }
}
