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

    [BsonElement("rid")]
    public int RId { get; set; }
}
