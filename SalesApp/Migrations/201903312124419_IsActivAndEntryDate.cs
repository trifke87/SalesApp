namespace SalesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsActivAndEntryDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Barcodes", "IsActiv", c => c.Boolean(nullable: false));
            AddColumn("dbo.Barcodes", "EntryDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Dimensions", "IsActiv", c => c.Boolean(nullable: false));
            AddColumn("dbo.Dimensions", "EntryDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Materials", "EntryDate", c => c.Int(nullable: false));
            AddColumn("dbo.Suppliers", "IsActiv", c => c.Boolean(nullable: false));
            AddColumn("dbo.Suppliers", "EntryDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Suppliers", "EntryDate");
            DropColumn("dbo.Suppliers", "IsActiv");
            DropColumn("dbo.Materials", "EntryDate");
            DropColumn("dbo.Dimensions", "EntryDate");
            DropColumn("dbo.Dimensions", "IsActiv");
            DropColumn("dbo.Barcodes", "EntryDate");
            DropColumn("dbo.Barcodes", "IsActiv");
        }
    }
}
