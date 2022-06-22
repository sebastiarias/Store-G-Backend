using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using StoregApp.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StoregApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [Authorize]
    public class TokenController:ControllerBase
    {

        [HttpPost]
        public IActionResult Authentication(UserLogin login)
        {
           if (IsValidUser(login))
            {
                var token = GenerateToken();
                return Ok (new { token });
            }

            return NotFound();
        }
        private bool IsValidUser(UserLogin login)
        {
            return true;
        }

        private string GenerateToken()
        {
            // Header
            var privateKey = "asdfawdfsdfqwerwefcwaefewtwassdas";
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(privateKey));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var header = new JwtHeader(signingCredentials);
            

            //Payload
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, "angie"),
                new Claim(ClaimTypes.Role, "Administrador"),
            };

            var payload = new JwtPayload
            (
                "https://localhost:7234", // Issuer
                "https://localhost:7234", // Audience
                claims,
                DateTime.Now, // Fecha de generación del token
                DateTime.Now.AddMinutes(5) // Fecha expiración del token
            );


            //Signature
            var token = new JwtSecurityToken(header, payload);
            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return jwtToken;
        }

    }
}
