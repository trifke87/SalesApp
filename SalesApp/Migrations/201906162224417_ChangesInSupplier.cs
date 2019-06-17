namespace SalesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInSupplier : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Materials", "Supplier_PartNumber", "dbo.Suppliers");
            DropIndex("dbo.Materials", new[] { "Supplier_PartNumber" });
            DropPrimaryKey("dbo.Suppliers");
            AddColumn("dbo.Suppliers", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Suppliers", "PartNumber", c => c.String(maxLength: 20));
            AddPrimaryKey("dbo.Suppliers", "Id");
            CreateIndex("dbo.Suppliers", "PartNumber");
            AddForeignKey("dbo.Suppliers", "PartNumber", "dbo.Materials", "PartNumber");
            DropColumn("dbo.Materials", "Supplier_PartNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Materials", "Supplier_PartNumber", c => c.String(maxLength: 20));
            DropForeignKey("dbo.Suppliers", "PartNumber", "dbo.Materials");
            DropIndex("dbo.Suppliers", new[] { "PartNumber" });
            DropPrimaryKey("dbo.Suppliers");
            AlterColumn("dbo.Suppliers", "PartNumber", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Suppliers", "Id");
            AddPrimaryKey("dbo.Suppliers", "PartNumber");
            CreateIndex("dbo.Materials", "Supplier_PartNumber");
            AddForeignKey("dbo.Materials", "Supplier_PartNumber", "dbo.Suppliers", "PartNumber");
        }
    }
}
