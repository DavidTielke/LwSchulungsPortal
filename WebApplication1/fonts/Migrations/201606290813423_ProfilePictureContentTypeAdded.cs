namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfilePictureContentTypeAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Participants", "ProfilePictureContentType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Participants", "ProfilePictureContentType");
        }
    }
}
