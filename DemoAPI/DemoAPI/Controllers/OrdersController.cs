using DemoAPI.DataModel.DTO;
using DemoAPI.DataModel.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

       
 
        [HttpGet("{userId}")]
        public async Task<List<OrderDto>> Get(int userId)
        {
            return await Task.FromResult(_orderService.GetOrderList(userId)).ConfigureAwait(true);
        }
    }
}
