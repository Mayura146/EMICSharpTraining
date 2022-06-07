using DemoAPI.DataModel.Enities;
using DemoAPI.DataModel.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ICartService _cartService;
        public UserController(IUserService userService,ICartService cartService)
        {
            _userService = userService;
            _cartService = cartService;
        }

        [HttpGet("{userId}")]

        public int GetCartItemCount(int userId)
        {
            int cartItemCount=_cartService.GetCartItemCount(userId);
            return cartItemCount;
        }

        [HttpGet]
        [Route("validateUserName/{userName}")]
        public bool ValidateUser(string userName)
        {
            return _userService.CheckUserAvailabity(userName);
        }

        [HttpPost("Sigup")]
        public void SignUp([FromBody] UserMaster userData)
        {
            _userService.RegisterUser(userData);
        }
     }
}
