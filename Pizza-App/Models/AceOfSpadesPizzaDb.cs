using System;
using System.Data.Entity;

namespace Pizza_App.Models
{
    public class Pizza_AppDb : DbContext
    {
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<PizzaType> PizzaTypes { get; set; }
    }
}
