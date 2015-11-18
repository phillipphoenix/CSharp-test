namespace Opg2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SaleEndsRemoved : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Prices", "SaleEnds");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Prices", "SaleEnds", c => c.DateTime());
        }
    }
}
