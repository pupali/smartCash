namespace SmartCasherProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        createdAt = c.DateTime(nullable: false),
                        updatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(nullable: false),
                        firstName = c.String(),
                        lastName = c.String(),
                        nickName = c.String(),
                        address = c.String(),
                        description = c.String(),
                        imageUrl = c.String(),
                        password = c.String(),
                        isAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
