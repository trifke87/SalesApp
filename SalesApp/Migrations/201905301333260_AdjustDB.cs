namespace SalesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Materials", "Barcode_Id", "dbo.Barcodes");
            DropIndex("dbo.Materials", new[] { "Barcode_Id" });
            DropPrimaryKey("dbo.Barcodes");
            AddColumn("dbo.Materials", "Error", c => c.String());
            AddPrimaryKey("dbo.Barcodes", "PartNumber");
            DropColumn("dbo.Barcodes", "Id");
            DropColumn("dbo.Materials", "Barcode_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Materials", "Barcode_Id", c => c.Int());
            AddColumn("dbo.Barcodes", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Barcodes");
            DropColumn("dbo.Materials", "Error");
            AddPrimaryKey("dbo.Barcodes", "Id");
            CreateIndex("dbo.Materials", "Barcode_Id");
            AddForeignKey("dbo.Materials", "Barcode_Id", "dbo.Barcodes", "Id");
        }
    }
}
