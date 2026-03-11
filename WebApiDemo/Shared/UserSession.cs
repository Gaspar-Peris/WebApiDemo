using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public static class UserSession
    {
        public static Guid UserId { get; set; }
        public static string Email { get; set; }
        public static Role CurrentRole { get; set; }
    }
}
