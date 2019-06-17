namespace SalesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDataTypeToDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Materials", "EntryDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Materials", "EntryDate", c => c.Int(nullable: false));
        }
    }
}
