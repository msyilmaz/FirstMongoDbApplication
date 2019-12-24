using MongoDB.Bson.Serialization.Attributes;

namespace FirstMongoDbApplication.Model
{
    public class RockSong:MongoBaseModel
    {
        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Singer")]
        public string Singer { get; set; }
    }
}
