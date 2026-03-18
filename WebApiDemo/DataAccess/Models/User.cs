using Microsoft.AspNetCore.Identity;

namespace DataAccess.Models
{
    public class User : IdentityUser<Guid>
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpireAtUtc {  get; set; }
        public required Role Role { get; set; }



        public static User Create(string email, string firstName, string lastName, Role Role)
        {
            return new User
            {
                Email = email,
                UserName = email,
                FirstName = firstName,
                LastName = lastName,
                Role = Role
            };
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
