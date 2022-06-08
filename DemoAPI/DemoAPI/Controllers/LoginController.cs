using DemoAPI.DataModel.Enities;
using DemoAPI.DataModel.Repository.Interface;
using DemoAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUserService _userService;
        private readonly ITokenService _tokenService;

        public LoginController (IUserService userService,ITokenService tokenService)
        {
            _userService = userService;
            _tokenService = tokenService;
        }

        [HttpPost]
        public IActionResult Login ([FromBody] UserMaster login)
        {
            IActionResult response = Unauthorized();
            UserMaster user = _userService.AuthenticateUser(login);
            if(user != null)
            {
                var tokenString=_tokenService.CreateToken(user);
                response = Ok(new
                {
                    token = tokenString,
                    userDetails = user
                });
            }

            return response;
        }
    }
}

// header=> token type,hash algorithm=> HS256
//payload=> subject=> ,name=>,admin=> true
//Signature=>
// symmetricKey=> claim=> 