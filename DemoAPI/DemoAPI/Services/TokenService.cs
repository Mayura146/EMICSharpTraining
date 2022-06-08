using DemoAPI.DataModel.Enities;
using DemoAPI.Services.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DemoAPI.Services
{
    public class TokenService : ITokenService
    {
        private readonly SymmetricSecurityKey _symmetricSecurityKey;
        public TokenService(IConfiguration configuration)
        {
            _symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["TokenKey"]));
        }
        public string CreateToken(UserMaster userInfo)
        {
            var claim = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.Username.ToString(CultureInfo.InvariantCulture)),
              new Claim("userid", userInfo.UserId.ToString(CultureInfo.InvariantCulture)),
                new Claim("userTypeId", userInfo.UserTypeId.ToString(CultureInfo.InvariantCulture))
                        
            };
            var credential=new SigningCredentials(_symmetricSecurityKey,SecurityAlgorithms.HmacSha256);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claim),
                Expires = DateTime.Now.AddDays(10),
                SigningCredentials = credential,
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token= tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
