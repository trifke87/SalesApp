namespace SalesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePrimaryKeyBarcode : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Barcodes");
            AlterColumn("dbo.Barcodes", "BarcodeNumber", c => c.String(nullable: false, maxLength: 50));
            AddPrimaryKey("dbo.Barcodes", "BarcodeNumber");
            DropColumn("dbo.Barcodes", "PartNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Barcodes", "PartNumber", c => c.String(nullable: false, maxLength: 20));
            DropPrimaryKey("dbo.Barcodes");
            AlterColumn("dbo.Barcodes", "BarcodeNumber", c => c.String(maxLength: 50));
            AddPrimaryKey("dbo.Barcodes", "PartNumber");
        }
    }
}
