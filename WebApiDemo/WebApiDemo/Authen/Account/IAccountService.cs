
using DataAccess.Models;
using Shared;

namespace WebApiDemo.Authen.Account
{
    public interface IAccountService
    {
        Task RegisterAsync(RegisterRequest registerRequest);
        Task<AuthResults> LoginAsync(LoginRequest loginRequest);
        Task<AuthResults> RefreshTokenAsync(string? refreshToken);
        Task UpdateUserRoleAsync(Guid userId, Role nuevoRol);
    }
}
