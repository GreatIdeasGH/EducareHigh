using GreatIdeas.EducareHigh.Web.Responses;

namespace GreatIdeas.EducareHigh.Web;

public interface IAccountDataservice 
{ 
    // Login with username and password
    Task<LoginResponse> Login(LoginRequest request);
    // Register with username and password
    Task<RegisterResponse> Register(RegisterRequest request);
}

public class AccountDataservice : IAccountDataservice
{
    public Task<LoginResponse> Login(LoginRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<RegisterResponse> Register(RegisterRequest request)
    {
        throw new NotImplementedException();
    }
}
