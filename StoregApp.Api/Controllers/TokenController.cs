using Microsoft.AspNetCore.Mvc;
using StoregApp.Domain.Entities;

namespace StoregApp.Api.Controllers
{
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
            return string.Empty;
        }

    }
}
