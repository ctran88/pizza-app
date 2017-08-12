using System;
using System.Data.Entity;

namespace Pizza_App.Models
{
    public class AceOfSpadesDb : DbContext
    {
        public AceOfSpadesDb() : base("name = AceOfSpadesDb") { }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<PizzaType> PizzaTypes { get; set; }
    }
}
