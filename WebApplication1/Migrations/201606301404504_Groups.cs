namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Groups : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ParticipantGroups",
                c => new
                    {
                        Participant_Id = c.Int(nullable: false),
                        Group_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Participant_Id, t.Group_Id })
                .ForeignKey("dbo.Participants", t => t.Participant_Id, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.Group_Id, cascadeDelete: true)
                .Index(t => t.Participant_Id)
                .Index(t => t.Group_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParticipantGroups", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.ParticipantGroups", "Participant_Id", "dbo.Participants");
            DropIndex("dbo.ParticipantGroups", new[] { "Group_Id" });
            DropIndex("dbo.ParticipantGroups", new[] { "Participant_Id" });
            DropTable("dbo.ParticipantGroups");
            DropTable("dbo.Groups");
        }
    }
}
