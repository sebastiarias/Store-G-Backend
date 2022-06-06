using StoregApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Domain.Interfaces
{
    public interface IOrderDetailRepository
    {
        OrderDetail GetOrderDetailById(int IdDetail);

        IEnumerable<OrderDetail> GetOrderDetail();

        void InsertOrderDetail(OrderDetail orderDetail);

        void UpdateOrderDetail(OrderDetail orderDetail);

        void DeleteOrderDetail(int idDetail);

    }
}
