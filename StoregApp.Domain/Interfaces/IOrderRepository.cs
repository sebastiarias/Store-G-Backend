using StoregApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Domain.Interfaces
{
    public interface IOrderRepository
    {
        Order GetOrderById(int idOrder);

        IEnumerable<Order> GetOrders();

        void InsertOrder(Order order);

        void UpdateOrder(Order order);

        void DeleteOrder(int idOrder);
        
    }
}
