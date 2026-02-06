using GreatIdeas.EducareHigh.Web.DTOs;

namespace GreatIdeas.EducareHigh.Web.Dataservices;

public class UserDataservice : IUserDataservice
{
    private readonly HttpClient _httpClient;

    public UserDataservice(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<UserDto?> GetUser(string id)
    {
        var response = await _httpClient.GetFromJsonAsync<UserDto>($"api/user/{id}");
        return response;
    }

    public async Task<UserDto?> UpdateUser(UserUpdateDto user)
    {
        var response = await _httpClient.PutAsJsonAsync("api/user", user);
        var userResponse = await response.Content.ReadFromJsonAsync<UserDto>();
        return userResponse;
    }

    public async Task<UserDto?> CreateUser(UserCreateDto user)
    {
        var response = await _httpClient.PostAsJsonAsync("api/user", user);
        var userResponse = await response.Content.ReadFromJsonAsync<UserDto>();
        return userResponse;
    }

    public async Task DeleteUser(string id)
    {
        var response = await _httpClient.DeleteAsync($"api/user/{id}");
        response.EnsureSuccessStatusCode();
    }
}
