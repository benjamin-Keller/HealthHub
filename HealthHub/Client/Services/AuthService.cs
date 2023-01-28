using HealthHub.Shared;
using System.Net.Http.Json;

namespace HealthHub.Client.Services;

public class AuthService
{
    private readonly HttpClient _httpClient;

    public AuthService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<HttpResponseMessage> SaveUserAsync(AddUserViewModel user)
    {
        var uri = $"api/v1/user?returnUrl={""}";
        return await _httpClient.PostAsJsonAsync(uri, user);
    }
}
