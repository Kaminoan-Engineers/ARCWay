using ARCWay.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ARCWay.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RobloxController : ControllerBase
{
    private readonly IRobloxService _roblox;

    public RobloxController(IRobloxService roblox)
    {
        _roblox = roblox;
    }

    [HttpGet("user/{username}")]
    public async Task<IActionResult> GetUser(string username)
    {
        var user = await _roblox.GetUserByUsernameAsync(username);
        return user == null ? NotFound() : Ok(user);
    }
}
