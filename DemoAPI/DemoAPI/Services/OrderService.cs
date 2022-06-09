using DemoAPI.DataModel.DTO;
using DemoAPI.DataModel.Repository.Interface;
using System.Collections.Generic;

namespace DemoAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService (IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public void CreateOrder(int userId, OrderDto orderDetails)
        {
           _orderRepository.CreateOrder(userId, orderDetails);
        }

        public List<OrderDto> GetOrderList(int userId)
        {
           return _orderRepository.GetOrderList(userId);
        }
    }
}
