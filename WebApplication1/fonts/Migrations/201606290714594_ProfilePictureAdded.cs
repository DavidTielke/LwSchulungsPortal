namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfilePictureAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Participants", "ProfilePicture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Participants", "ProfilePicture");
        }
    }
}
