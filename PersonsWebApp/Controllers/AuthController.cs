using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsWebApp.DAL.Entities;
using PersonsWebApp.Services;

namespace PersonsWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public AuthController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult> LoginAsync([FromBody] UserDto userDto)
        {
            if (string.IsNullOrEmpty(userDto.Username)
                || string.IsNullOrEmpty(userDto.Password))
            {
                return BadRequest("Invalid username or password");
            }

            var token = await _loginService.LoginAsync(userDto);
            if (token == null)
            {
                return Unauthorized();
            }

            SetTokenCookie(token.RefreshToken);

            return Ok(new { Token = token.Token });
        }

        [HttpPost]
        [Route("Refresh")]
        public async Task<ActionResult> RefreshAsync()
        {
            string? oldRefreshToken = Request.Cookies["refreshToken"];
            if (oldRefreshToken == null)
                return Unauthorized();

            LoginResponse? token = await _loginService.RefreshAsync(oldRefreshToken);

            if (token == null)
                return Unauthorized();

            SetTokenCookie(token.RefreshToken);

            return Ok(new { Token = token.Token });
        }

        private void SetTokenCookie(string refreshToken)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(7)
            };
            Response.Cookies.Append("refreshToken", refreshToken, cookieOptions);

        }
    }
}
