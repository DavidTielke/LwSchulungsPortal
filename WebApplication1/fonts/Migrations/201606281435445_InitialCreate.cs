namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        Firstname = c.String(nullable: false, maxLength: 255),
                        ID = c.Int(nullable: false, identity: true),
                        Lastname = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Website = c.String(nullable: false),
                        Company = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Participants");
        }
    }
}
