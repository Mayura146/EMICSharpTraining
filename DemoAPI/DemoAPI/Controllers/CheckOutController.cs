using DemoAPI.DataModel.DTO;
using DemoAPI.DataModel.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CheckOutController : ControllerBase
    {
        readonly IOrderService _orderService;
        readonly ICartService _cartService;

        public CheckOutController(IOrderService orderService, ICartService cartService)
        {
            _orderService = orderService;
            _cartService = cartService;
        }

        [HttpPost("{userId}")]
        public int Post(int userId, [FromBody] OrderDto checkedOutItems)
        {
            _orderService.CreateOrder(userId, checkedOutItems);
            return _cartService.ClearCart(userId);
        }
    }
}
