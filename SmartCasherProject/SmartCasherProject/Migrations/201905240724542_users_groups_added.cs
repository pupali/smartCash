namespace SmartCasherProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class users_groups_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserGroups",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        groupName = c.String(),
                        groupDescription = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Users", "groupId", c => c.Int());
            CreateIndex("dbo.Users", "groupId");
            AddForeignKey("dbo.Users", "groupId", "dbo.UserGroups", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "groupId", "dbo.UserGroups");
            DropIndex("dbo.Users", new[] { "groupId" });
            DropColumn("dbo.Users", "groupId");
            DropTable("dbo.UserGroups");
        }
    }
}
