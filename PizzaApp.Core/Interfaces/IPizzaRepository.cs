using System.Collections.Generic;

namespace PizzaApp.DAL.Interfaces
{
    public interface IPizzaRepository
    {
        void Add(Pizza o);
        void Edit(Pizza o);
        void Remove(int Id);
        IEnumerable<Pizza> GetPizzas();
    }
}