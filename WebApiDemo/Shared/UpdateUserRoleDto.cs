using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class UpdateUserRoleDto
    {
        public Guid UserId { get; set; }
        public Role Role { get; set; }
    }
}

