namespace SalesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIdToBarcode : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Barcodes");
            AddColumn("dbo.Barcodes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Barcodes", "BarcodeNumber", c => c.String(maxLength: 50));
            AddPrimaryKey("dbo.Barcodes", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Barcodes");
            AlterColumn("dbo.Barcodes", "BarcodeNumber", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Barcodes", "Id");
            AddPrimaryKey("dbo.Barcodes", "BarcodeNumber");
        }
    }
}
