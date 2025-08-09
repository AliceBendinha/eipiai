using eipiai.Applications.Services;
using Microsoft.AspNetCore.Mvc;

namespace eipiai.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string Username, string password)
        {
            if (Username == "Alice" && password == "112233")
            {
                var token = TokenService.GenerateToken(new Dominio.Model.Livros());
                return Ok(token);
            }

            return BadRequest("User ou Pass. inválida");

        }
    }
}
