using DataAccess.Models; // Tus modelos (User, Role)
using Microsoft.AspNetCore.Identity;
using Services.Repositories;
using Shared;
using WebApiDemo.Authen.Exceptions;
using WebApiDemo.Authen.Token;

namespace WebApiDemo.Authen.Account
{
    public class AccountService : IAccountService
    {
        private readonly IAuthTokenProcessor _authTokenProcessor;
        private readonly UserManager<User> _userManager;
        private readonly IUserRepository _userRepository;

        public AccountService(IAuthTokenProcessor authTokenProcessor, UserManager<User> userManager, IUserRepository userRepository)
        {
            _authTokenProcessor = authTokenProcessor;
            _userManager = userManager;
            _userRepository = userRepository;
        }

        public async Task RegisterAsync(RegisterRequest registerRequest)
        {
            var userExists = await _userManager.FindByEmailAsync(registerRequest.Email) != null;
            if (userExists)
            {
                throw new UserAlreadyExistsException(registerRequest.Email);
            }

            var user = User.Create(registerRequest.Email, registerRequest.FirstName, registerRequest.LastName, registerRequest.Role);

            var result = await _userManager.CreateAsync(user, registerRequest.Password);

            if (!result.Succeeded)
            {
                var errorMessages = string.Join(", ", result.Errors.Select(e => e.Description));
                throw new Exception($"La contraseña no cumple los requisitos: {errorMessages}");
            }

            
            string roleName = registerRequest.Role switch
            {
                Role.Admin => "Admin", 
                Role.Director => "Director",
                _ => "Employee"
            };

            await _userManager.AddToRoleAsync(user, roleName);
        }
        
        public async Task<AuthResults> LoginAsync(LoginRequest loginRequest)
        {
            var user = await _userManager.FindByEmailAsync(loginRequest.Email);

            if (user == null || !await _userManager.CheckPasswordAsync(user, loginRequest.Password))
            {
                throw new LoginFailedException(loginRequest.Email);
            }

            var roles = await _userManager.GetRolesAsync(user);
            var (jwtToken, expirationDateInUtc) = _authTokenProcessor.GenerateJwtToken(user, roles);

            return new AuthResults
            {
                AccessToken = jwtToken,
                RefreshToken = user.RefreshToken,
                ExpiresAt = expirationDateInUtc
            };
        }

        public async Task<AuthResults> RefreshTokenAsync(string? refreshToken)
        {
            if (string.IsNullOrEmpty(refreshToken))
            {
                throw new RefreshTokenException("Refresh token is missing");
            }

            var user = await _userRepository.GetUserByRefreshTokenAsync(refreshToken);

            if (user == null)
            {
                throw new RefreshTokenException("Unable to retrieve user for refresh token");
            }

            if (user.RefreshTokenExpireAtUtc < DateTime.UtcNow)
            {
                throw new RefreshTokenException("Refresh token is expired");
            }

            var roles = await _userManager.GetRolesAsync(user);

            var (jwtToken, expirationDateInUtc) = _authTokenProcessor.GenerateJwtToken(user, roles);
            var refreshTokenValue = _authTokenProcessor.GenerateRefreshToken();

            var refreshTokenExpirationDateInUtc = DateTime.UtcNow.AddDays(7);

            user.RefreshToken = refreshTokenValue;
            user.RefreshTokenExpireAtUtc = refreshTokenExpirationDateInUtc;

            await _userManager.UpdateAsync(user);

            return new AuthResults
            {
                AccessToken = jwtToken,
                RefreshToken = refreshTokenValue,
                ExpiresAt = expirationDateInUtc,
            };
        }
    }
}