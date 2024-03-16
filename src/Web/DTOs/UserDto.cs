namespace GreatIdeas.EducareHigh.Web;

public sealed record class UserDto(
    string? Id,
    string? UserName,
    string? Email,
    string? FirstName,
    string? LastName,
    string? PhoneNumber
);

public sealed record class UserEmailUpdateDto(
    string? Id,
    string? Email
);

public sealed record class UserPasswordUpdateDto(
    string? Id,
    string? OldPassword,
    string? NewPassword
);

public sealed record class UserPhoneUpdateDto(
    string? Id,
    string? PhoneNumber
);

public sealed record class UserUpdateDto(
    string? Id,
    string? UserName,
    string? Email,
    string? FirstName,
    string? LastName,
    string? PhoneNumber
);

public sealed record class UserCreateDto(
    string? UserName,
    string? Email,
    string? FirstName,
    string? LastName,
    string? PhoneNumber,
    string? Password
);