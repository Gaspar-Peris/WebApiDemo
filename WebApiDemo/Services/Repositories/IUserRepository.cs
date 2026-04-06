

using DataAccess.Models;

namespace Services.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetUserByRefreshTokenAsync(string refreshToken);
        Task<List<User>> GetAllAsync();

    }
}
