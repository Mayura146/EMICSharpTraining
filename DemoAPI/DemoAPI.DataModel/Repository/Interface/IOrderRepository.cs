using DemoAPI.DataModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.DataModel.Repository.Interface
{
    public interface IOrderRepository
    {
        void CreateOrder(int userId, OrderDto orderDetails);
        List<OrderDto> GetOrderList(int userId);
    }
}
