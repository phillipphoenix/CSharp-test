namespace Opg2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeparateAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        PostalCode = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "CurrentAddress_Id", c => c.Int());
            AddColumn("dbo.Orders", "AddressId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "CurrentAddress_Id");
            CreateIndex("dbo.Orders", "AddressId");
            AddForeignKey("dbo.Customers", "CurrentAddress_Id", "dbo.Addresses", "Id");
            AddForeignKey("dbo.Orders", "AddressId", "dbo.Addresses", "Id", cascadeDelete: true);
            DropColumn("dbo.Orders", "Address1");
            DropColumn("dbo.Orders", "Address2");
            DropColumn("dbo.Orders", "PostalCode");
            DropColumn("dbo.Orders", "City");
            DropColumn("dbo.Orders", "State");
            DropColumn("dbo.Orders", "Country");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Country", c => c.String());
            AddColumn("dbo.Orders", "State", c => c.String());
            AddColumn("dbo.Orders", "City", c => c.String());
            AddColumn("dbo.Orders", "PostalCode", c => c.String());
            AddColumn("dbo.Orders", "Address2", c => c.String());
            AddColumn("dbo.Orders", "Address1", c => c.String());
            DropForeignKey("dbo.Orders", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.Customers", "CurrentAddress_Id", "dbo.Addresses");
            DropIndex("dbo.Orders", new[] { "AddressId" });
            DropIndex("dbo.Customers", new[] { "CurrentAddress_Id" });
            DropColumn("dbo.Orders", "AddressId");
            DropColumn("dbo.Customers", "CurrentAddress_Id");
            DropTable("dbo.Addresses");
        }
    }
}
