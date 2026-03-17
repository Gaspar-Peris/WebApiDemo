using DataAccess.Models;

namespace WebApiDemo.Authen.Token
{
    public interface IAuthTokenProcessor
    {
        (string jwtToken, DateTime expiresAtUtc) GenerateJwtToken(User user, IList<string> roles);
        string GenerateRefreshToken();
    }
}
