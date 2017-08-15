using PizzaApp.DAL;
using System.Data.Entity;

namespace PizzaApp.Infrastructure
{
    public class PizzaAppContext : DbContext
    {
        public PizzaAppContext() : base("name=PizzaAppConnection") { }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
