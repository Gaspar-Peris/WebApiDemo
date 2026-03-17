using DataAccess.Models;
using Shared;
using System.Net.Http.Json;
using System.Net.Http.Headers; 

namespace WinFormsApp1.Login_Register_Token
{
    public class AuthApiService
    {
        private static readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7164/")
        };
        private static string? _jwtToken;

        public AuthApiService()
        {
        }

        public async Task<AuthResults?> LoginAsync(string email, string password)
        {
            var response = await _httpClient.PostAsJsonAsync("api/account/login", new LoginRequest
            {
                Email = email,
                Password = password
            });

            if (!response.IsSuccessStatusCode)
                return null;

            var authResults = await response.Content.ReadFromJsonAsync<AuthResults>();

            if (authResults != null && !string.IsNullOrEmpty(authResults.AccessToken))
            {
                _jwtToken = authResults.AccessToken;
                _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _jwtToken);
            }

            return authResults;
        }

        public async Task<bool> RegisterAsync(string FirstName, string LastName, string email, string password)
        {   
            var response = await _httpClient.PostAsJsonAsync("api/account/register", new RegisterRequest
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = email,
                Password = password,
                Role = Role.Employee 
            });

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateRoleAsync(UpdateUserRoleDto updateDto)
        {
            
            var response = await _httpClient.PutAsJsonAsync("api/users/role", updateDto);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            
            var response = await _httpClient.GetAsync("api/users");

            if (!response.IsSuccessStatusCode)
                return new List<User>();

            return await response.Content.ReadFromJsonAsync<List<User>>() ?? new List<User>();
        }
    }
}