using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Service
{
    public interface IUserService
    {
        

        Task<List<User>> GetAllAsync();
    }
}
