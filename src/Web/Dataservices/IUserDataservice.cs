using GreatIdeas.EducareHigh.Web.DTOs;

namespace GreatIdeas.EducareHigh.Web;

public interface IUserDataservice
{
    Task<UserDto?> GetUser(string id);
    Task<UserDto?> UpdateUser(UserUpdateDto user);
    Task<UserDto?> CreateUser(UserCreateDto user);
    Task DeleteUser(string id);
}
