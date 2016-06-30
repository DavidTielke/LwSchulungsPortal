namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Links : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Links",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(maxLength: 255),
                        URL = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Participants", t => t.CreatedBy_Id, cascadeDelete: true)
                .Index(t => t.CreatedBy_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Links", "CreatedBy_Id", "dbo.Participants");
            DropIndex("dbo.Links", new[] { "CreatedBy_Id" });
            DropTable("dbo.Links");
        }
    }
}
