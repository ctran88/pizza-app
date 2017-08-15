namespace PizzaApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PizzaAppDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerOrders",
                c => new
                    {
                        CustomerOrderId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        PizzaId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        DeliveryDate = c.DateTime(nullable: false),
                        TotalCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CustomerOrderId)
                .ForeignKey("dbo.Pizzas", t => t.PizzaId, cascadeDelete: true)
                .Index(t => t.PizzaId);
            
            CreateTable(
                "dbo.Pizzas",
                c => new
                    {
                        PizzaId = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PizzaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerOrders", "PizzaId", "dbo.Pizzas");
            DropIndex("dbo.CustomerOrders", new[] { "PizzaId" });
            DropTable("dbo.Pizzas");
            DropTable("dbo.CustomerOrders");
        }
    }
}
