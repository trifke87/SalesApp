namespace SalesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BarcodeForeignKey : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Barcodes", name: "Material_PartNumber", newName: "PartNumber");
            RenameIndex(table: "dbo.Barcodes", name: "IX_Material_PartNumber", newName: "IX_PartNumber");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Barcodes", name: "IX_PartNumber", newName: "IX_Material_PartNumber");
            RenameColumn(table: "dbo.Barcodes", name: "PartNumber", newName: "Material_PartNumber");
        }
    }
}
