using ARCWay.API.Config;
using ARCWay.API.Models;
using ARCWay.API.Models.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ARCWay.API.Data;
public class MongoDbContext
{
    private readonly IMongoDatabase _database;

    public MongoDbContext(IOptions<MongoDBSettings> settings, IMongoClient client)
    {
        _database = client.GetDatabase(settings.Value.DatabaseName);
    }

    public IMongoCollection<UserEntity> Users =>
        _database.GetCollection<UserEntity>("Users");
}
