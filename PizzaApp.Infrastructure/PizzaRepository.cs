using PizzaApp.DAL;
using PizzaApp.DAL.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;

namespace PizzaApp.Infrastructure
{
    public class PizzaRepository : IPizzaRepository
    {
        PizzaAppContext context = new PizzaAppContext();

        public void Add(Pizza p)
        {
            context.Pizzas.Add(p);
            context.SaveChanges();
        }

        public void Edit(Pizza p)
        {
            context.Entry(p).State = EntityState.Modified;
        }

        public IEnumerable<Pizza> GetPizzas()
        {
            return context.Pizzas;
        }

        public void Remove(int Id)
        {
            Pizza p = context.Pizzas.Find(Id);
            context.Pizzas.Remove(p);
            context.SaveChanges();
        }
    }
}
