using StoregApp.Domain.Entities;
using StoregApp.Domain.Interfaces;
using StoregApp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private StoreGContext _context;

        public OrderRepository(StoreGContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders;
        }
        public Order GetOrderById(int idOrder)
        {
            return _context.Orders.FirstOrDefault(x => x.IdOrder == idOrder);
        }

        public void InsertOrder(Order order)
        {
           _context.Orders.Add(order);
           _context.SaveChanges();
        }
        public void UpdateOrder(Order order)
        {
            var orderExistente = _context.Orders.FirstOrDefault(x => x.IdOrder == order.IdOrder);
            orderExistente.OrderEmail = order.OrderEmail;
            orderExistente.ShippingAddress = order.ShippingAddress;
            orderExistente.OrderDate = order.OrderDate;
            _context.SaveChanges();
        }

        public void DeleteOrder(int idOrder)
        {
            var orderExistente = _context.Orders.FirstOrDefault(x => x.IdOrder == idOrder);
            _context.Orders.Remove(orderExistente);
            _context.SaveChanges();
        }          
            
                
    }
}
