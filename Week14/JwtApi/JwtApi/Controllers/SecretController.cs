using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretController : ControllerBase
    {
        [Authorize]
        [HttpGet("protected")]
        public IActionResult GetSecret()
        {
            return Ok(new { message = "Burası JWT ile korunuyor!" });
        }
    }
}
