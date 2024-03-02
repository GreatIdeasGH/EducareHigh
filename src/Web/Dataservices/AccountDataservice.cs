using GreatIdeas.EducareHigh.Web.Responses;

namespace GreatIdeas.EducareHigh.Web;

public interface IAccountDataservice 
{ 
    // Login with username and password
    Task<LoginResponse?> Login(LoginRequest request);
    // Register with username and password
    Task<RegisterResponse> Register(RegisterRequest request);
}

public class AccountDataservice(HttpClient httpClient) : IAccountDataservice
{
    public async Task<LoginResponse?> Login(LoginRequest request)
    {
        // Call the API to login
        var response = await httpClient.PostAsJsonAsync("api/account/login", request);
        // Read the response
        var loginResponse = await response.Content.ReadFromJsonAsync<LoginResponse>();
        return loginResponse;
    }

    public Task<RegisterResponse> Register(RegisterRequest request)
    {
        throw new NotImplementedException();
    }
}
