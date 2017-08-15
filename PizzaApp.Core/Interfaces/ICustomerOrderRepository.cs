using System.Collections.Generic;

namespace PizzaApp.DAL.Interfaces
{
    public interface ICustomerOrderRepository
    {
        void Add(CustomerOrder o);
        void Edit(CustomerOrder o);
        void Remove(int Id);
        IEnumerable<CustomerOrder> GetCustomerOrders();
    }
}