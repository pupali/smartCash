namespace SmartCasherProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_key_type_product : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductPrices", "productId", "dbo.Products");
            DropForeignKey("dbo.ProductUnits", "productid", "dbo.Products");
            DropIndex("dbo.ProductPrices", new[] { "productId" });
            DropIndex("dbo.ProductUnits", new[] { "productid" });
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "productId", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.ProductPrices", "productId", c => c.Long(nullable: false));
            AlterColumn("dbo.ProductUnits", "productid", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.Products", "productId");
            CreateIndex("dbo.ProductPrices", "productId");
            CreateIndex("dbo.ProductUnits", "productid");
            AddForeignKey("dbo.ProductPrices", "productId", "dbo.Products", "productId", cascadeDelete: true);
            AddForeignKey("dbo.ProductUnits", "productid", "dbo.Products", "productId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductUnits", "productid", "dbo.Products");
            DropForeignKey("dbo.ProductPrices", "productId", "dbo.Products");
            DropIndex("dbo.ProductUnits", new[] { "productid" });
            DropIndex("dbo.ProductPrices", new[] { "productId" });
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.ProductUnits", "productid", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductPrices", "productId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "productId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Products", "productId");
            CreateIndex("dbo.ProductUnits", "productid");
            CreateIndex("dbo.ProductPrices", "productId");
            AddForeignKey("dbo.ProductUnits", "productid", "dbo.Products", "productId", cascadeDelete: true);
            AddForeignKey("dbo.ProductPrices", "productId", "dbo.Products", "productId", cascadeDelete: true);
        }
    }
}
