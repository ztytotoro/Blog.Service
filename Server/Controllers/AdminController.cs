using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IDistributedCache _cache;

        public AdminController(IConfiguration configuration, IDistributedCache cache)
        {
            _configuration = configuration;
            _cache = cache;
        }
        [HttpPost("Auth")]
        public IActionResult Post(string username, string password)
        {
            if (username == "admin" && password == "123456")
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, username)
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SecurityKey"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "test",
                    audience: "test",
                    claims: claims,
                    expires: DateTime.Now.AddHours(12),
                    signingCredentials: creds);

                var tokenString = new JwtSecurityTokenHandler().WriteToken(token: token);
                _cache.Set("token", Encoding.UTF8.GetBytes(tokenString));
                return Ok(new
                {
                    token = tokenString
                });
            }

            return BadRequest("用户名密码错误");
        }
    }
}