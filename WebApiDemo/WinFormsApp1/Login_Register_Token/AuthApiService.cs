using DataAccess.Models;
using Shared;
using System.Net.Http.Json;


namespace WinFormsApp1.Login_Register_Token
{
    public class AuthApiService
    {
        private readonly HttpClient _httpClient;

        public AuthApiService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7164/")
            };
        }

        public async Task<AuthResults?> LoginAsync(string email, string password)
        {
            var response = await _httpClient.PostAsJsonAsync("https://localhost:7164/api/account/login", new LoginRequest
            {
                Email = email,
                Password = password
            });

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<AuthResults>();
        }

        public async Task<bool> RegisterAsync(string FirstName, string LastName, string email, string password)
        {   
            var response = await _httpClient.PostAsJsonAsync("https://localhost:7164/api/account/register", new RegisterRequest
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
            
            var response = await _httpClient.PatchAsJsonAsync("api/user/role", updateDto);
            return response.IsSuccessStatusCode;
        }
        public async Task<List<User>> GetAllUsersAsync()
        {
            var response = await _httpClient.GetAsync("api/users");

            if (!response.IsSuccessStatusCode)
                return new List<User>();

            return await response.Content.ReadFromJsonAsync<List<User>>();
        }
    }
}