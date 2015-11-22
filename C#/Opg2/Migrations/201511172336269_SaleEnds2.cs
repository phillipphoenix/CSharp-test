namespace Opg2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SaleEnds2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Prices", "SaleEnds", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Prices", "SaleEnds", c => c.DateTime(nullable: false));
        }
    }
}
