using StoregApp.Application.Requests;
using StoregApp.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Interfaces
{
    public interface IOrderService
    {
        OrderResponse GetOrderById(int idOrder);

        IEnumerable<OrderResponse> GetOrders();

        void InsertOrder(CreateOrderRequest order);

        void UpdateOrder(UpdateOrderRequest order);

        void DeleteOrder(int idOrder);
    }
}
