using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Service;
using Shared;
using Shared.Dto;
using WebApiDemo.Authen.Account;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IAccountService accountService, IMapper mapper)
        {
            _userService = userService;
            _accountService = accountService;
            _mapper = mapper;
        }
        [Authorize(Roles = "Admin")]
        [HttpPut("role")]
        public async Task<IActionResult> UpdateRole(UpdateUserRoleDto dto)
        {
            await _accountService.UpdateUserRoleAsync(dto.UserId, dto.Role);

            return Ok("Role updated");
        }

        [Authorize]
        [HttpGet("GetAny")]
        public async Task<IActionResult> GetAny(string algo)
        {
            

            return Ok($"{algo} mas autorizado");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAllAsync();

            var dto = _mapper.Map<IEnumerable<UserResponseDto>>(users);
            return Ok(dto);
        }
    }
}
