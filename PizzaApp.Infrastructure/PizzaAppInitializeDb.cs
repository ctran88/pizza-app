using PizzaApp.DAL;
using System.Data.Entity;

namespace PizzaApp.Infrastructure
{
    public class PizzaAppInitializeDb : DropCreateDatabaseIfModelChanges<PizzaAppContext>
    {
        protected override void Seed(PizzaAppContext context)
        {
            context.Pizzas.Add(
                new Pizza
                {
                    PizzaId = 1,
                    Type = "The One",
                    Price = 9.99M
                });

            context.CustomerOrders.Add(
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
                });
            context.CustomerOrders.Add(
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
                });
            context.CustomerOrders.Add(
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

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
