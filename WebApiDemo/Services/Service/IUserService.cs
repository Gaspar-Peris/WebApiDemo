using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Service
{
    public interface IUserService
    {
        Task UpdateUserRoleAsync(Guid userId, Role role);

        Task<List<User>> GetAllAsync();
    }
}
