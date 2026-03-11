

using DataAccess.Models;

namespace Services.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetUserByRefreshTokenAsync(string refreshToken);
        Task UpdateUserRoleAsync(Guid userId, Role role);
        Task<List<User>> GetAllAsync();

    }
}
