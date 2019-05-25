namespace SmartCasherProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class permission_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserPermissions",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        delete = c.Boolean(nullable: false),
                        create = c.Boolean(nullable: false),
                        edit = c.Boolean(nullable: false),
                        read = c.Boolean(nullable: false),
                        userId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .Index(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserPermissions", "userId", "dbo.Users");
            DropIndex("dbo.UserPermissions", new[] { "userId" });
            DropTable("dbo.UserPermissions");
        }
    }
}
