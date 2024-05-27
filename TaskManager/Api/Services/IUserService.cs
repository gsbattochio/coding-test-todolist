using Api.Models;

namespace Api.Services;

public interface IUserService
{
    // Task<User> GetUserByIdAsync(int id);
    // Task<IEnumerable<User>> GetAllUsersAsync();
    // Task AddUserAsync(User user);
    // Task RemoveUserAsync(int id);
    // Task<User> GetUserByUserNameAsync(string username);
    Task<bool> RegisterUser(string userName, string password, string email);
}