using DemoAPI.DataModel.DTO;
using DemoAPI.DataModel.Enities;
using DemoAPI.DataModel.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoAPI.DataModel.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BookStoreContext _context;

        public OrderRepository(BookStoreContext context)
        {
            _context = context;
        }

        public void CreateOrder(int userId, OrderDto orderDetails)
        {
            try
            {
                StringBuilder orderid = new StringBuilder();
                orderid.Append(CreateRandomNumber(3));
                orderid.Append('-');
                orderid.Append(CreateRandomNumber(6));

                CustomerOrder customerOrder = new CustomerOrder
                {
                    OrderId = orderid.ToString(),
                    UserId = userId,
                    DateCreated = DateTime.Now.Date,
                    CartTotal = orderDetails.CartTotal
                };
                _context.CustomerOrders.Add(customerOrder);
                _context.SaveChanges();

                foreach (CartIitemDto order in orderDetails.OrderDetails)
                {
                    CustomerOrderDetail productDetails = new CustomerOrderDetail
                    {
                        OrderId = orderid.ToString(),
                        ProductId = order.Book.BookId,
                        Quantity = order.Quantity,
                        Price = order.Book.Price
                    };
                    _context.CustomerOrderDetails.Add(productDetails);
                    _context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public List<OrderDto> GetOrderList(int userId)
        {
            List<OrderDto> userOrders = new List<OrderDto>();
            List<string> userOrderId = new List<string>();

            userOrderId = _context.CustomerOrders.Where(x => x.UserId == userId)
                .Select(x => x.OrderId).ToList();

            foreach (string orderid in userOrderId)
            {
                OrderDto order = new OrderDto
                {
                    OrderId = orderid,
                    CartTotal = _context.CustomerOrders.FirstOrDefault(x => x.OrderId == orderid).CartTotal,
                    OrderDate = _context.CustomerOrders.FirstOrDefault(x => x.OrderId == orderid).DateCreated
                };

                List<CustomerOrderDetail> orderDetail = _context.CustomerOrderDetails.Where(x => x.OrderId == orderid).ToList();

                order.OrderDetails = new List<CartIitemDto>();

                foreach (CustomerOrderDetail customerOrder in orderDetail)
                {
                    CartIitemDto item = new CartIitemDto();

                    Book book = new Book
                    {
                        BookId = customerOrder.ProductId,
                        Title = _context.Books.FirstOrDefault(x => x.BookId == customerOrder.ProductId
                        && customerOrder.OrderId == orderid).Title,
                        Price = _context.CustomerOrderDetails.FirstOrDefault(x => x.ProductId == customerOrder.ProductId && customerOrder.OrderId == orderid).Price
                    };

                    item.Book = book;
                    item.Quantity = _context.CustomerOrderDetails.FirstOrDefault(x => x.ProductId == customerOrder.ProductId && x.OrderId == orderid).Quantity;

                    order.OrderDetails.Add(item);
                }
                userOrders.Add(order);
            }
            return userOrders.OrderByDescending(x => x.OrderDate).ToList();
        }

        int CreateRandomNumber(int length)
        {
            Random rnd = new Random();
            return rnd.Next(Convert.ToInt32(Math.Pow(10, length - 1)), Convert.ToInt32(Math.Pow(10, length)));
        }
    }
}

