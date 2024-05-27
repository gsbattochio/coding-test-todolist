using Api.Services;

namespace Api.Domain;

public class User : IUser
{
    private IUserService _userService;
    
    public int UserId { get; private set; }
    public string Name { get; private set; }
    public string UserName { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public ICollection<TaskItem> Tasks { get; private set; }

    public User(
        IUserService userService,
        int userId = default,
        string name = null,
        string userName = null,
        string email = null,
        string passwordHash = null,
        ICollection<TaskItem> tasks = null)
    {
        _userService = userService;
        UserId = userId;
        Name = name;
        UserName = userName;
        Email = email;
        PasswordHash = passwordHash;
        Tasks = tasks;
    }

    public async Task<bool> RegisterUser(string password)
    {
        var existingUser = await _userRepository
            .GetUserByUsername(userName);

        // User already exists
        if (existingUser != null)
            return false;

        var passwordHash = _authService.HashPassword(password);
        var user = new User
        {
            Username = userName,
            PasswordHash = passwordHash,
            Email = email
        };

        await _userRepository.AddUserAsync(user);
    }
}