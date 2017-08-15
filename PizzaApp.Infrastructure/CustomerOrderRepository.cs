using PizzaApp.DAL.Interfaces;
using PizzaApp.DAL;
using System.Collections.Generic;
using System.Data.Entity;

namespace PizzaApp.Infrastructure
{
    public class CustomerOrderRepository : ICustomerOrderRepository
    {
        PizzaAppContext context = new PizzaAppContext();

        public void Add(CustomerOrder o)
        {
            context.CustomerOrders.Add(o);
            context.SaveChanges();
        }

        public void Edit(CustomerOrder o)
        {
            context.Entry(o).State = EntityState.Modified;
        }

        public IEnumerable<CustomerOrder> GetCustomerOrders()
        {
            return context.CustomerOrders;
        }

        public void Remove(int Id)
        {
            CustomerOrder o = context.CustomerOrders.Find(Id);
            context.CustomerOrders.Remove(o);
            context.SaveChanges();
        }
    }
}
