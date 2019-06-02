namespace SmartCasherProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
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
                        moduleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Modules", t => t.moduleId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .Index(t => t.userId)
                .Index(t => t.moduleId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        createdAt = c.DateTime(nullable: false),
                        updatedAt = c.DateTime(nullable: false),
                        deletedAt = c.DateTime(),
                        firstName = c.String(),
                        lastName = c.String(),
                        nickName = c.String(),
                        address = c.String(),
                        description = c.String(),
                        imageUrl = c.String(),
                        password = c.String(),
                        isAdmin = c.Boolean(nullable: false),
                        groupId = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.UserGroups", t => t.groupId)
                .Index(t => t.groupId);
            
            CreateTable(
                "dbo.ProductCatagories",
                c => new
                    {
                        catagoryId = c.Int(nullable: false, identity: true),
                        catagoryName = c.String(),
                        catagoryImage = c.String(),
                    })
                .PrimaryKey(t => t.catagoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productId = c.Int(nullable: false, identity: true),
                        productName = c.String(),
                        barCode = c.Long(nullable: false),
                        productImage = c.String(),
                        createdAt = c.DateTime(nullable: false),
                        updatedAt = c.DateTime(nullable: false),
                        productCatagoryId = c.Int(),
                    })
                .PrimaryKey(t => t.productId)
                .ForeignKey("dbo.ProductCatagories", t => t.productCatagoryId)
                .Index(t => t.productCatagoryId);
            
            CreateTable(
                "dbo.ProductPrices",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        sellingPrice = c.Int(nullable: false),
                        purchasePrice = c.Int(nullable: false),
                        startDate = c.DateTime(nullable: false),
                        endDate = c.DateTime(nullable: false),
                        productId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Products", t => t.productId, cascadeDelete: true)
                .Index(t => t.productId);
            
            CreateTable(
                "dbo.ProductUnits",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        unitName = c.String(),
                        unitAmount = c.Int(nullable: false),
                        unitPrice = c.Int(nullable: false),
                        defaultUnit = c.Boolean(nullable: false),
                        productid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Products", t => t.productid, cascadeDelete: true)
                .Index(t => t.productid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductUnits", "productid", "dbo.Products");
            DropForeignKey("dbo.Products", "productCatagoryId", "dbo.ProductCatagories");
            DropForeignKey("dbo.ProductPrices", "productId", "dbo.Products");
            DropForeignKey("dbo.Users", "groupId", "dbo.UserGroups");
            DropForeignKey("dbo.GroupPermissions", "moduleId", "dbo.Modules");
            DropForeignKey("dbo.UserPermissions", "userId", "dbo.Users");
            DropForeignKey("dbo.UserPermissions", "moduleId", "dbo.Modules");
            DropForeignKey("dbo.GroupPermissions", "groupId", "dbo.UserGroups");
            DropIndex("dbo.ProductUnits", new[] { "productid" });
            DropIndex("dbo.ProductPrices", new[] { "productId" });
            DropIndex("dbo.Products", new[] { "productCatagoryId" });
            DropIndex("dbo.Users", new[] { "groupId" });
            DropIndex("dbo.UserPermissions", new[] { "moduleId" });
            DropIndex("dbo.UserPermissions", new[] { "userId" });
            DropIndex("dbo.GroupPermissions", new[] { "moduleId" });
            DropIndex("dbo.GroupPermissions", new[] { "groupId" });
            DropTable("dbo.ProductUnits");
            DropTable("dbo.ProductPrices");
            DropTable("dbo.Products");
            DropTable("dbo.ProductCatagories");
            DropTable("dbo.Users");
            DropTable("dbo.UserPermissions");
            DropTable("dbo.Modules");
            DropTable("dbo.GroupPermissions");
            DropTable("dbo.UserGroups");
        }
    }
}
