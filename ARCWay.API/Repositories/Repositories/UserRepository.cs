using ARCWay.API.Config;
using MongoDB.Driver;
using ARCWay.API.Models.Entities;
using ARCWay.API.Repositories.Interfaces;
using Microsoft.Extensions.Options;

namespace ARCWay.API.Repositories.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IMongoCollection<UserEntity> _collection;

    public UserRepository(IOptions<MongoDBSettings> options, IMongoClient client)
    {
        var database = client.GetDatabase(options.Value.DatabaseName);
        _collection = database.GetCollection<UserEntity>(options.Value.UsersCollectionName);
    }

    public async Task<UserEntity?> GetByIdAsync(string id) =>
        await _collection.Find(u => u.Id == id).FirstOrDefaultAsync();

    public async Task<List<UserEntity>> GetAllAsync() =>
        await _collection.Find(_ => true).ToListAsync();

    public async Task CreateAsync(UserEntity user) =>
        await _collection.InsertOneAsync(user);

    public async Task UpdateAsync(string id, UserEntity user) =>
        await _collection.ReplaceOneAsync(u => u.Id == id, user);

    public async Task DeleteAsync(string id) =>
        await _collection.DeleteOneAsync(u => u.Id == id);
}