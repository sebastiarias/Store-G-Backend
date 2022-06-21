using StoregApp.Application.Requests;
using StoregApp.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Interfaces
{
    public interface IOrderDetailService
    {
        OrderDetailResponse GetOrderDetailById(int idOrderDetail);

        IEnumerable<OrderDetailResponse> GetOrderDetails();

        void InsertOrderDetail(CreateOrderDetailRequest orderDetail);

        void UpdateOrderDetail(UpdateOrderDetailRequest orderDetail);

        void DeleteOrderDetail(int idOrderDetail);
    }
}
