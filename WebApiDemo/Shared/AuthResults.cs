using DataAccess.Models;
using System.Text.Json.Serialization;

namespace Shared
{
    public class AuthResults
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime ExpiresAt { get; set; }
        [JsonPropertyName("role")]
        public string? Role { get; set; }
    }
}
