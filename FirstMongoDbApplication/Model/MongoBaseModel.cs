using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FirstMongoDbApplication.Model
{
    public class MongoBaseModel
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
