namespace GreatIdeas.EducareHigh.Web.DTOs;

public sealed record class AccountDto(
    string? Id,
    string? UserName,
    string? Email,
    string? FirstName,
    string? LastName,
    string? PhoneNumber
);