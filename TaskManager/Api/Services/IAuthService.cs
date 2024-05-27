using Api.Models;

namespace Api.Services;

public interface IAuthService
{
    Task<string> AuthenticateUser(User user, string password);
    string HashPassword(string password);
}