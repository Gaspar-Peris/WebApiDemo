using DataAccess.Models;
using Services.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task UpdateUserRoleAsync(Guid userId, Role role)
        {
            await _userRepository.UpdateUserRoleAsync(userId, role);
        }
        public async Task<List<User>> GetAllAsync()
        {
            return await _userRepository.GetAllAsync();
        }
    }
}
