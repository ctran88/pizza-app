﻿using System.Data.Entity;

namespace PizzaApp.DAL.Models
{
    public class PizzaAppContext : DbContext
    {
        public PizzaAppContext() : base("name = PizzaAppDbConnection") { }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
