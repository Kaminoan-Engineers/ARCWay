using ARCWay.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ARCWay.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _service;
    public UsersController(IUserService service) => _service = service;

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUser(string id) =>
        Ok(await _service.GetUserByIdAsync(id));
}
