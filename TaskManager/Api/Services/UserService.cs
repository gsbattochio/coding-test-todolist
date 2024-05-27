using Api.Models;
using Api.Repositories;
using Microsoft.AspNetCore.Identity;

namespace Api.Services;

public class UserService : IUserService
{
    private readonly IAuthService _authService;
    private readonly IUserRepository _userRepository;
    private readonly IPasswordHasher<User> _passwordHasher;

    public UserService(IAuthService authService, IUserRepository userRepository, IPasswordHasher<User> passwordHasher)
    {
        _authService = authService;
        _userRepository = userRepository;
        _passwordHasher = passwordHasher;
    }

    public async Task<User> GetUserByIdAsync(int id)
    {
        return await _userRepository.GetUserByIdAsync(id);
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return await _userRepository.GetAllUsersAsync();
    }

    public async Task AddUserAsync(User user)
    {
        user.PasswordHash = _passwordHasher.HashPassword(user, user.PasswordHash);
        await _userRepository.AddUserAsync(user);
    }

    public async Task RemoveUserAsync(int id)
    {
        var user = await _userRepository.GetUserByIdAsync(id);
        if (user != null)
        {
            await _userRepository.RemoveUserAsync(user);
        }
    }

    public async Task<User> GetUserByUserNameAsync(string username)
    {
        var user = await _userRepository.GetUserByUserNameAsync(username);
        return user;
    }

    public async Task<User> AuthenticateAsync(string username, string password)
    {
        var user = await _userRepository.GetUserByUserNameAsync(username);
        if (user != null && _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password) ==
            PasswordVerificationResult.Success)
        {
            return user;
        }

        return null;
    }

    public async Task<bool> RegisterUser(
        string userName,
        string password,
        string email)
    {
        var User = new Domain.User(
            this,
            userName: userName,
            email: email);

        var isSuccess = await User.RegisterUser(password);
        return isSuccess;
    }
}