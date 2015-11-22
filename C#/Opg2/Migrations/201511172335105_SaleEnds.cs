namespace Opg2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SaleEnds : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Prices", "SaleEnds", c => c.DateTime(nullable: false));
            DropColumn("dbo.Prices", "OnSale");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Prices", "OnSale", c => c.Boolean(nullable: false));
            DropColumn("dbo.Prices", "SaleEnds");
        }
    }
}
