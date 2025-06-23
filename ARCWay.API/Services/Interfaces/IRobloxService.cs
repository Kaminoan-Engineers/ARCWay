using ARCWay.API.Models.DataTransferObjects;

namespace ARCWay.API.Services.Interfaces;

public interface IRobloxService
{
    Task<RobloxUserDTO?> GetUserByUsernameAsync(string username);
}
