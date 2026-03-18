using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public static class IdentityRoleConstants
    {
        public static readonly Guid AdminRoleGuid = new Guid("7940e1a3-4b28-4c71-8de4-7789925009bd");

        public static readonly Guid DirectorGuid = new Guid("BCD6511A-FAFF-45B6-B29B-DFDE66EB3AD9");

        public static readonly Guid RegularEmployeeGuid = new Guid("A839D242-DF2C-48E2-8C55-C19F9E499328");

        public const string Admin = "Admin";
        public const string Director = "Director";
        public const string Employee = "Employee";
    }
}
