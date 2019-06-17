namespace SalesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Barcodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PartNumber = c.String(nullable: false),
                        BarcodeNumber = c.String(maxLength: 50),
                        Material_PartNumber = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Materials", t => t.Material_PartNumber)
                .Index(t => t.Material_PartNumber);
            
            CreateTable(
                "dbo.Dimensions",
                c => new
                    {
                        PartNumber = c.String(nullable: false, maxLength: 128),
                        Height = c.Single(nullable: false),
                        Length = c.Single(nullable: false),
                        Width = c.Single(nullable: false),
                        Weight = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.PartNumber);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        PartNumber = c.String(nullable: false, maxLength: 128),
                        PartDescription = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Barcode_Id = c.Int(),
                        Dimensions_PartNumber = c.String(maxLength: 128),
                        PartCategory_Id = c.Int(),
                        Picture_Id = c.Int(),
                        Supplier_PartNumber = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PartNumber)
                .ForeignKey("dbo.Barcodes", t => t.Barcode_Id)
                .ForeignKey("dbo.Dimensions", t => t.Dimensions_PartNumber)
                .ForeignKey("dbo.PartCategories", t => t.PartCategory_Id)
                .ForeignKey("dbo.Pictures", t => t.Picture_Id)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_PartNumber)
                .Index(t => t.Barcode_Id)
                .Index(t => t.Dimensions_PartNumber)
                .Index(t => t.PartCategory_Id)
                .Index(t => t.Picture_Id)
                .Index(t => t.Supplier_PartNumber);
            
            CreateTable(
                "dbo.PartCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PartCategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PartNumber = c.String(nullable: false),
                        PicturePath = c.String(),
                        Material_PartNumber = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Materials", t => t.Material_PartNumber)
                .Index(t => t.Material_PartNumber);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        PartNumber = c.String(nullable: false, maxLength: 128),
                        SupplierNumber = c.String(),
                        SupplierName = c.String(),
                    })
                .PrimaryKey(t => t.PartNumber);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        PartNumber = c.String(nullable: false, maxLength: 128),
                        PartPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PartNumber);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Materials", "Supplier_PartNumber", "dbo.Suppliers");
            DropForeignKey("dbo.Pictures", "Material_PartNumber", "dbo.Materials");
            DropForeignKey("dbo.Materials", "Picture_Id", "dbo.Pictures");
            DropForeignKey("dbo.Materials", "PartCategory_Id", "dbo.PartCategories");
            DropForeignKey("dbo.Materials", "Dimensions_PartNumber", "dbo.Dimensions");
            DropForeignKey("dbo.Barcodes", "Material_PartNumber", "dbo.Materials");
            DropForeignKey("dbo.Materials", "Barcode_Id", "dbo.Barcodes");
            DropIndex("dbo.Pictures", new[] { "Material_PartNumber" });
            DropIndex("dbo.Materials", new[] { "Supplier_PartNumber" });
            DropIndex("dbo.Materials", new[] { "Picture_Id" });
            DropIndex("dbo.Materials", new[] { "PartCategory_Id" });
            DropIndex("dbo.Materials", new[] { "Dimensions_PartNumber" });
            DropIndex("dbo.Materials", new[] { "Barcode_Id" });
            DropIndex("dbo.Barcodes", new[] { "Material_PartNumber" });
            DropTable("dbo.Prices");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Pictures");
            DropTable("dbo.PartCategories");
            DropTable("dbo.Materials");
            DropTable("dbo.Dimensions");
            DropTable("dbo.Barcodes");
        }
    }
}
