using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens.Jwt;
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
                var secretKey=new System
            }
        }
    }
}