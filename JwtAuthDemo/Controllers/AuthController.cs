using Microsoft.AspNetCore.Mvc;
using JwtAuthDemo.Models;
using JwtAuthDemo.Services;
using Microsoft.AspNetCore.Authorization;
using JwtAuthDemo.Services.Interfaces;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService tokenService)
        {
            _authService = tokenService;
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request.Username == "Teste" && request.Password == "123")
            {
                var token = _authService.GenerateToken(request.Username);
                return Ok(new { Token = token });
            }

            return Unauthorized();
        }
    }
}