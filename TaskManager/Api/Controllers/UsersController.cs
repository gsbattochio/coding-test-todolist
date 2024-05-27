using Api.Models;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] string userName, string password, string email)
    {
        var result = await _userService.RegisterUser(
            userName,
            password,
            email);
        
        if (!result)
            return BadRequest("User already exists");

        return Ok("User registered successfully");
    }
    
    // [HttpGet]
    // public async Task<IActionResult> GetAll()
    // {
    //     var users = await _userService.GetAllUsersAsync();
    //     return Ok(users);
    // }
    //
    // [HttpPost]
    // public async Task<IActionResult> Create([FromBody] User user)
    // {
    //     await _userService.AddUserAsync(user);
    //     return Ok();
    // }
    //
    // [HttpDelete("{id}")]
    // public async Task<IActionResult> Delete(int id)
    // {
    //     await _userService.RemoveUserAsync(id);
    //     return Ok();
    // }
}