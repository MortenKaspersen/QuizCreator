namespace QuizCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberSinceToUserModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "MemberSince", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "MemberSince");
        }
    }
}
