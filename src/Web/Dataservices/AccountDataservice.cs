using GreatIdeas.EducareHigh.Web.DTOs;
using GreatIdeas.EducareHigh.Web.Responses;

namespace GreatIdeas.EducareHigh.Web.Dataservices;

public interface IAccountDataservice
{
    // Login with username and password
    Task<LoginResponse?> Login(LoginRequest request);

    // Register with username and password
    Task<RegisterResponse?> Register(RegisterRequest request);

    // Logout
    Task Logout();

    // Get the current user
    Task<UserDto?> GetCurrentUser();

    // Delete user
    Task DeleteUser(string id);

    // Forgot password
    Task ForgotPassword(string email);
}

public class AccountDataservice(HttpClient httpClient) : IAccountDataservice
{
    public async Task DeleteUser(string id)
    {
        var response = await httpClient.DeleteAsync($"api/account/{id}");
        response.EnsureSuccessStatusCode();
    }

    public async Task ForgotPassword(string email)
    {
        var response = await httpClient.PostAsJsonAsync("api/account/forgotpassword", new { email });
        response.EnsureSuccessStatusCode();
    }

    public async Task<UserDto?> GetCurrentUser()
    {
        var response = await httpClient.GetFromJsonAsync<UserDto>("api/account/currentuser");
        return response;
    }

    public async Task<LoginResponse?> Login(LoginRequest request)
    {
        var response = await httpClient.PostAsJsonAsync("api/account/login", request);
        var loginResponse = await response.Content.ReadFromJsonAsync<LoginResponse>();
        return loginResponse;
    }

    public async Task Logout()
    {
        var response = await httpClient.PostAsync("api/account/logout", null);
        response.EnsureSuccessStatusCode();
        if (response.IsSuccessStatusCode)
        {
            await httpClient.SendAsync(new HttpRequestMessage
            {
                Method = new HttpMethod("GET"),
                RequestUri = new Uri(httpClient.BaseAddress + "api/account/logout"),
                Content = new StringContent("")
            });
        }
    }

    public async Task<RegisterResponse?> Register(RegisterRequest request)
    {
        var response = await httpClient.PostAsJsonAsync("api/account/register", request);
        var registerResponse = await response.Content.ReadFromJsonAsync<RegisterResponse>();
        return registerResponse;
    }
}
