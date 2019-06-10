namespace SmartCasherProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class suppliers_and_storages : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductPrices", "productId", "dbo.Products");
            DropIndex("dbo.ProductPrices", new[] { "productId" });
            CreateTable(
                "dbo.PurchaseRecipts",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        reciptCost = c.Int(nullable: false),
                        type_cash = c.Boolean(nullable: false),
                        type_postponed = c.Boolean(nullable: false),
                        type_cAndP = c.Boolean(nullable: false),
                        cashPayed = c.Int(),
                        ammountLeft = c.Int(),
                        supplierId = c.Int(nullable: false),
                        createdAt = c.DateTime(nullable: false),
                        updatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Suppliers", t => t.supplierId, cascadeDelete: true)
                .Index(t => t.supplierId);
            
            CreateTable(
                "dbo.StoredProducts",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        productId = c.Long(nullable: false),
                        unitId = c.Int(),
                        supplierId = c.Int(nullable: false),
                        storageId = c.Int(),
                        reciptId = c.Long(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Products", t => t.productId, cascadeDelete: true)
                .ForeignKey("dbo.PurchaseRecipts", t => t.reciptId)
                .ForeignKey("dbo.Storages", t => t.storageId)
                .ForeignKey("dbo.Suppliers", t => t.supplierId, cascadeDelete: true)
                .ForeignKey("dbo.ProductUnits", t => t.unitId)
                .Index(t => t.productId)
                .Index(t => t.unitId)
                .Index(t => t.supplierId)
                .Index(t => t.storageId)
                .Index(t => t.reciptId);
            
            CreateTable(
                "dbo.Storages",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        storageName = c.String(),
                        storageAddress = c.String(),
                        storagePhone = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        suplierName = c.String(),
                        address = c.String(),
                        phoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Products", "currentPrice", c => c.Int(nullable: false));
            AddColumn("dbo.ProductUnits", "unitAvgPrice", c => c.Int(nullable: false));
            AddColumn("dbo.ProductUnits", "unitSellingPrice", c => c.Int(nullable: false));
            DropTable("dbo.ProductPrices");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductPrices",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        sellingPrice = c.Int(nullable: false),
                        purchasePrice = c.Int(nullable: false),
                        startDate = c.DateTime(nullable: false),
                        endDate = c.DateTime(nullable: false),
                        productId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            DropForeignKey("dbo.PurchaseRecipts", "supplierId", "dbo.Suppliers");
            DropForeignKey("dbo.StoredProducts", "unitId", "dbo.ProductUnits");
            DropForeignKey("dbo.StoredProducts", "supplierId", "dbo.Suppliers");
            DropForeignKey("dbo.StoredProducts", "storageId", "dbo.Storages");
            DropForeignKey("dbo.StoredProducts", "reciptId", "dbo.PurchaseRecipts");
            DropForeignKey("dbo.StoredProducts", "productId", "dbo.Products");
            DropIndex("dbo.StoredProducts", new[] { "reciptId" });
            DropIndex("dbo.StoredProducts", new[] { "storageId" });
            DropIndex("dbo.StoredProducts", new[] { "supplierId" });
            DropIndex("dbo.StoredProducts", new[] { "unitId" });
            DropIndex("dbo.StoredProducts", new[] { "productId" });
            DropIndex("dbo.PurchaseRecipts", new[] { "supplierId" });
            DropColumn("dbo.ProductUnits", "unitSellingPrice");
            DropColumn("dbo.ProductUnits", "unitAvgPrice");
            DropColumn("dbo.Products", "currentPrice");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Storages");
            DropTable("dbo.StoredProducts");
            DropTable("dbo.PurchaseRecipts");
            CreateIndex("dbo.ProductPrices", "productId");
            AddForeignKey("dbo.ProductPrices", "productId", "dbo.Products", "productId", cascadeDelete: true);
        }
    }
}
