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
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private StoreGContext _context;

        public OrderDetailRepository(StoreGContext context)
        {
            _context = context;
        }

        public IEnumerable<OrderDetail> GetOrderDetail()
        {
            return _context.OrderDetails;
        }

        public OrderDetail GetOrderDetailById(int IdDetail)
        {
            return _context.OrderDetails.FirstOrDefault(x => x.IdDetail == IdDetail);
        }

        public void InsertOrderDetail(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            var detailExistente = _context.OrderDetails.FirstOrDefault(x => x.IdDetail == orderDetail.IdDetail);
            detailExistente.Price = detailExistente.Price;
            detailExistente.Quantity = detailExistente.Quantity;
            _context.SaveChanges();
        }

        public void DeleteOrderDetail(int IdDetail)
        {
            var detailExistente = _context.OrderDetails.FirstOrDefault(x => x.IdDetail == IdDetail);
            _context.OrderDetails.Remove(detailExistente);
            _context.SaveChanges();

        }
    }
}
