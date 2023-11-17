using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace jwt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public  IActionResult Login([FromBody] LoginModel user)
        {
            if(user is null)
            {
                return BadRequest("Invalid Client Request");
            }
            if(user.UserName=="Tom" && user.Password=="Jerry")
            {
                var secretKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredential=new SignInCredentials(secretKey,SecurityAlgorithms.HmacSha256);
                var tokenOptions=new JwtSecurityToken(
                    issuer:"http://0.0.0.0:8080",
                    audience:"http://0.0.0.0:8080",
                    claims:new List<Claim>(),
                    expires:DateTime.Now.AddMinutes(10),
                    signingCredentials:signinCredentials
                );
                var tokenString=new JwtSecurityTokenHandler().writeToken(tokenOptions);
                return ok(new AuthenticateResponse(tokenOptions=tokenString));
            }
            return Unauthorized();
        }
    }
}