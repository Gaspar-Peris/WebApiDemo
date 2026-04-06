using WebApiDemo.Data;
using Microsoft.EntityFrameworkCore;
using DataAccess.Models;

namespace Services.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AplicationDbContext _AplicationDbContext;
        public UserRepository(AplicationDbContext AplicationDbContext)
        {
            _AplicationDbContext = AplicationDbContext;
        }

        public async Task<User?> GetUserByRefreshTokenAsync(string refreshToken)
        {
            var user = await _AplicationDbContext.Users.FirstOrDefaultAsync(x => x.RefreshToken == refreshToken);

            return user;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _AplicationDbContext.Users.ToListAsync();
        }
    }
}
