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
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Pizza_App.Models.AceOfSpadesDb context)
        {
            context.PizzaTypes.AddOrUpdate(t => t.Id,
                new PizzaType
                {
                    Id = 001,
                    Type = "The One",
                    Price = 9.99M
                });
        }
    }
}
