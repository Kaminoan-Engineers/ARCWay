using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ARCWay.API.Models.Entities;

public class UserEntity
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;

    [BsonElement("name")]
    public string Name { get; set; } = string.Empty;

    [BsonElement("email")]
    public string? Email { get; set; }
}
