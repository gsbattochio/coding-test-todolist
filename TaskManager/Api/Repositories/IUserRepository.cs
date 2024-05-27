using Api.Models;

namespace Api.Repositories;

public interface IUserRepository
{
    Task<User> GetUserByIdAsync(int id);
    Task AddUserAsync(User user);
    Task<User> GetUserByUsername(string username);
    Task<IEnumerable<User>> GetAllUsersAsync();
    Task RemoveUserAsync(User user);
    Task<User> GetUserByUserNameAsync(string username);
}