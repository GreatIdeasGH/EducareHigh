namespace GreatIdeas.EducareHigh.Web.Responses
{
    public sealed record LoginResponse(string Token, string Username, string Role);

    public sealed record LoginRequest(string Username, string Password);

    public sealed record RegisterRequest(string Username, string Password, string Role);

    public sealed record RegisterResponse(string Username, string Role);
}