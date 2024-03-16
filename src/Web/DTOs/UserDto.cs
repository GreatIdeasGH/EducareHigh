﻿namespace GreatIdeas.EducareHigh.Web;

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