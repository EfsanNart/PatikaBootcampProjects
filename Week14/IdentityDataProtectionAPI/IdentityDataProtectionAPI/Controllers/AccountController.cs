using IdentityDataProtectionAPI.DTOs;
using IdentityDataProtectionAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityDataProtectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterDto model)
        {
            var result = await _userService.CreateUserAsync(model.Email, model.Password);
            if (result)
                return Ok(new { message = "Kullanıcı başarıyla oluşturuldu!" });
            return BadRequest(new { message = "Kullanıcı oluşturulamadı!" });
        }

        
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto model)
        {
            var user = await _userService.GetUserByEmailAsync(model.Email);
            if (user == null)
                return Unauthorized(new { message = "Kullanıcı bulunamadı!" });

            bool isPasswordValid = await _userService.CheckPasswordAsync(user, model.Password);
            if (!isPasswordValid)
                return Unauthorized(new { message = "Şifre hatalı!" });

            return Ok(new { message = "Giriş başarılı!", user = user.Email });
        }
    }
}
