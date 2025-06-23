using ARCWay.API.Models.DataTransferObjects;
using ARCWay.API.Repositories.Interfaces;
using ARCWay.API.Services.Interfaces;

namespace ARCWay.API.Services.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repo;
    public UserService(IUserRepository repo) => _repo = repo;

    public async Task<UserDTO> GetUserByIdAsync(string id)
    {
        var user = await _repo.GetByIdAsync(id);
        return new UserDTO { Id = user.Id, Name = user.Name };
    }
}