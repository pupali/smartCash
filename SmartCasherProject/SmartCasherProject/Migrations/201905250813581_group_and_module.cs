namespace SmartCasherProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class group_and_module : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GroupPermissions",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        delete = c.Boolean(nullable: false),
                        create = c.Boolean(nullable: false),
                        edit = c.Boolean(nullable: false),
                        read = c.Boolean(nullable: false),
                        groupId = c.Int(nullable: false),
                        moduleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.UserGroups", t => t.groupId, cascadeDelete: true)
                .ForeignKey("dbo.Modules", t => t.moduleId, cascadeDelete: true)
                .Index(t => t.groupId)
                .Index(t => t.moduleId);
            
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        moduleName = c.String(),
                        moduleDescription = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.UserPermissions", "moduleId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserPermissions", "moduleId");
            AddForeignKey("dbo.UserPermissions", "moduleId", "dbo.Modules", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GroupPermissions", "moduleId", "dbo.Modules");
            DropForeignKey("dbo.UserPermissions", "moduleId", "dbo.Modules");
            DropForeignKey("dbo.GroupPermissions", "groupId", "dbo.UserGroups");
            DropIndex("dbo.UserPermissions", new[] { "moduleId" });
            DropIndex("dbo.GroupPermissions", new[] { "moduleId" });
            DropIndex("dbo.GroupPermissions", new[] { "groupId" });
            DropColumn("dbo.UserPermissions", "moduleId");
            DropTable("dbo.Modules");
            DropTable("dbo.GroupPermissions");
        }
    }
}
