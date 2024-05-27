using Api.Models;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] string userName, [FromBody] string password)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        // var user = await _userService.GetUserByUserNameAsync(userName);
        // var token = await _authService.AuthenticateUser(user, password);

        if (token == null)
            return Unauthorized("Invalid username or password");

        return Ok(new { Token = token });
    }
}