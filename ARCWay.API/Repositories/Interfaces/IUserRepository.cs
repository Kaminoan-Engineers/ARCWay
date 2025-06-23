using ARCWay.API.Models.Entities;

namespace ARCWay.API.Repositories.Interfaces;

public interface IUserRepository
{
    Task<UserEntity?> GetByIdAsync(string id);
    Task<List<UserEntity>> GetAllAsync();
    Task CreateAsync(UserEntity user);
    Task UpdateAsync(string id, UserEntity user);
    Task DeleteAsync(string id);
}