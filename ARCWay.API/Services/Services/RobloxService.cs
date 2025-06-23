namespace ARCWay.API.Services.Services;

using ARCWay.API.Models.DataTransferObjects;
using ARCWay.API.Services.Interfaces;
using System.Net.Http.Json;

public class RobloxService : IRobloxService
{
    private readonly HttpClient _http;

    public RobloxService(HttpClient http)
    {
        _http = http;
    }

    public async Task<RobloxUserDTO?> GetUserByUsernameAsync(string username)
    {
        var body = new
        {
            usernames = new[] { username },
            excludeBannedUsers = false
        };

        var response = await _http.PostAsJsonAsync("https://users.roblox.com/v1/usernames/users", body);

        if (!response.IsSuccessStatusCode)
            return null;

        var result = await response.Content.ReadFromJsonAsync<UserLookupResponse>();
        return result?.Data.FirstOrDefault();
    }

    private class UserLookupResponse
    {
        public List<RobloxUserDTO> Data { get; set; } = new();
    }
}
