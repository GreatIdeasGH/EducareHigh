using GreatIdeas.EducareHigh.Web.Responses;

namespace GreatIdeas.EducareHigh.Web;

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
    
}

public class AccountDataservice(HttpClient httpClient) : IAccountDataservice
{
    public async Task<UserDto?> GetCurrentUser()
    {
        var response = await httpClient.GetFromJsonAsync<UserDto>("api/account/currentuser");
        return response;
    }

    public async Task<LoginResponse?> Login(LoginRequest request)
    {
        // Call the API to login
        var response = await httpClient.PostAsJsonAsync("api/account/login", request);
        // Read the response
        var loginResponse = await response.Content.ReadFromJsonAsync<LoginResponse>();
        return loginResponse;
    }

    public async Task Logout()
    {
        var response = await httpClient.PostAsync("api/account/logout", null);
        response.EnsureSuccessStatusCode();        
    }

    public async Task<RegisterResponse?> Register(RegisterRequest request)
    {
        // Call the API to register
        var response = await httpClient.PostAsJsonAsync("api/account/register", request);
        // Read the response
        var registerResponse = await response.Content.ReadFromJsonAsync<RegisterResponse>();
        return registerResponse;
    }
}
