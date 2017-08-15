namespace PizzaApp.DAL.Migrations
{
    using PizzaApp.DAL.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<PizzaAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PizzaAppContext context)
        {
            context.Pizzas.AddOrUpdate(p => p.PizzaId,
                new Pizza
                {
                    PizzaId = 1,
                    Type = "The One",
                    Price = 9.99M
                });

            context.CustomerOrders.AddOrUpdate(o => o.CustomerOrderId,
                new CustomerOrder
                {
                    CustomerOrderId = 1,
                    FirstName = "Michael",
                    LastName = "Scott",
                    PhoneNumber = "1112223333",
                    PizzaId = 1,
                    Quantity = 1,
                    DeliveryDate = System.DateTime.Now,
                    TotalCost = 9.99M
                },
                new CustomerOrder
                {
                    CustomerOrderId = 2,
                    FirstName = "Dwight",
                    LastName = "Schrute",
                    PhoneNumber = "2223334444",
                    PizzaId = 1,
                    Quantity = 2,
                    DeliveryDate = System.DateTime.Now,
                    TotalCost = 19.98M
                },
                new CustomerOrder
                {
                    CustomerOrderId = 3,
                    FirstName = "Jim",
                    LastName = "Halpert",
                    PhoneNumber = "3334445555",
                    PizzaId = 1,
                    Quantity = 3,
                    DeliveryDate = System.DateTime.Now,
                    TotalCost = 29.97M
                });
        }
    }
}
