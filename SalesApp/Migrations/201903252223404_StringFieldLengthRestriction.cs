namespace SalesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StringFieldLengthRestriction : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Barcodes", "Material_PartNumber", "dbo.Materials");
            DropForeignKey("dbo.Pictures", "Material_PartNumber", "dbo.Materials");
            DropForeignKey("dbo.Materials", "Supplier_PartNumber", "dbo.Suppliers");
            DropIndex("dbo.Barcodes", new[] { "Material_PartNumber" });
            DropIndex("dbo.Materials", new[] { "Supplier_PartNumber" });
            DropIndex("dbo.Pictures", new[] { "Material_PartNumber" });
            DropPrimaryKey("dbo.Materials");
            DropPrimaryKey("dbo.Suppliers");
            DropPrimaryKey("dbo.Prices");
            AlterColumn("dbo.Barcodes", "PartNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Barcodes", "Material_PartNumber", c => c.String(maxLength: 20));
            AlterColumn("dbo.Materials", "PartNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Materials", "Supplier_PartNumber", c => c.String(maxLength: 20));
            AlterColumn("dbo.Pictures", "PartNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Pictures", "Material_PartNumber", c => c.String(maxLength: 20));
            AlterColumn("dbo.Suppliers", "PartNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Suppliers", "SupplierNumber", c => c.String(maxLength: 40));
            AlterColumn("dbo.Suppliers", "SupplierName", c => c.String(maxLength: 255));
            AlterColumn("dbo.Prices", "PartNumber", c => c.String(nullable: false, maxLength: 20));
            AddPrimaryKey("dbo.Materials", "PartNumber");
            AddPrimaryKey("dbo.Suppliers", "PartNumber");
            AddPrimaryKey("dbo.Prices", "PartNumber");
            CreateIndex("dbo.Barcodes", "Material_PartNumber");
            CreateIndex("dbo.Materials", "Supplier_PartNumber");
            CreateIndex("dbo.Pictures", "Material_PartNumber");
            AddForeignKey("dbo.Barcodes", "Material_PartNumber", "dbo.Materials", "PartNumber");
            AddForeignKey("dbo.Pictures", "Material_PartNumber", "dbo.Materials", "PartNumber");
            AddForeignKey("dbo.Materials", "Supplier_PartNumber", "dbo.Suppliers", "PartNumber");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Materials", "Supplier_PartNumber", "dbo.Suppliers");
            DropForeignKey("dbo.Pictures", "Material_PartNumber", "dbo.Materials");
            DropForeignKey("dbo.Barcodes", "Material_PartNumber", "dbo.Materials");
            DropIndex("dbo.Pictures", new[] { "Material_PartNumber" });
            DropIndex("dbo.Materials", new[] { "Supplier_PartNumber" });
            DropIndex("dbo.Barcodes", new[] { "Material_PartNumber" });
            DropPrimaryKey("dbo.Prices");
            DropPrimaryKey("dbo.Suppliers");
            DropPrimaryKey("dbo.Materials");
            AlterColumn("dbo.Prices", "PartNumber", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Suppliers", "SupplierName", c => c.String());
            AlterColumn("dbo.Suppliers", "SupplierNumber", c => c.String());
            AlterColumn("dbo.Suppliers", "PartNumber", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Pictures", "Material_PartNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.Pictures", "PartNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Materials", "Supplier_PartNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.Materials", "PartNumber", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Barcodes", "Material_PartNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.Barcodes", "PartNumber", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Prices", "PartNumber");
            AddPrimaryKey("dbo.Suppliers", "PartNumber");
            AddPrimaryKey("dbo.Materials", "PartNumber");
            CreateIndex("dbo.Pictures", "Material_PartNumber");
            CreateIndex("dbo.Materials", "Supplier_PartNumber");
            CreateIndex("dbo.Barcodes", "Material_PartNumber");
            AddForeignKey("dbo.Materials", "Supplier_PartNumber", "dbo.Suppliers", "PartNumber");
            AddForeignKey("dbo.Pictures", "Material_PartNumber", "dbo.Materials", "PartNumber");
            AddForeignKey("dbo.Barcodes", "Material_PartNumber", "dbo.Materials", "PartNumber");
        }
    }
}
