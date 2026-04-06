using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Authen.Account;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Shared.LoginRequest loginRequest)
        {
            var result = await _accountService.LoginAsync(loginRequest);
            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] Shared.RegisterRequest registerRequest)
        {
            await _accountService.RegisterAsync(registerRequest);
            return Ok();
        }
        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken([FromBody] string refreshToken)
        {
            var result = await _accountService.RefreshTokenAsync(refreshToken);
            return Ok(result);
        }
    }
}
