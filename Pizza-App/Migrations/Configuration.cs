namespace Pizza_App.Migrations
{
    using Pizza_App.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Pizza_App.Models.AceOfSpadesDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Pizza_App.Models.AceOfSpadesDb context)
        {
            context.Pizzas.AddOrUpdate(t => t.PizzaId,
                new Pizza
                {
                    PizzaId = 1,
                    Type = "The One",
                    Price = 9.99M
                });
        }
    }
}
