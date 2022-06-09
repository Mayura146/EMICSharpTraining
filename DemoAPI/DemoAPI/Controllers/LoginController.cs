using DemoAPI.DataModel.Enities;
using DemoAPI.DataModel.Repository.Interface;
using DemoAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        readonly IUserService _userService;
        private readonly IConfiguration _config;
        readonly ITokenService _tokenService;

        public LoginController(IConfiguration config, IUserService userService, ITokenService tokenService)
        {
            _config = config;
            _userService = userService;
            _tokenService = tokenService;
        }


        [HttpPost]
        public IActionResult Login([FromBody] UserMaster login)
        {
            IActionResult response = Unauthorized();
            UserMaster user = _userService.AuthenticateUser(login);

            if (user != null)
            {
                var tokenString = _tokenService.CreateToken(user);
                response = Ok(new
                {
                    token = tokenString,
                    userDetails = user,
                });
            }

            return response;
        }


    }
}