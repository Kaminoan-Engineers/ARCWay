using ARCWay.API.Models.DataTransferObjects;

namespace ARCWay.API.Services.Interfaces;

public interface IUserService
{
    Task<IEnumerable<UserDTO>> GetAllUsersAsync();
    Task<UserDTO> GetUserByIdAsync(string id);
}