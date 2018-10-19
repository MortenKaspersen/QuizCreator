namespace QuizCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberSinceToUserModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "MemberSince", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "MemberSince", c => c.DateTime(nullable: false));
        }
    }
}
