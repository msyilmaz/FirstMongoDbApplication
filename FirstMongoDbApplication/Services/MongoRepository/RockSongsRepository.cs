using FirstMongoDbApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMongoDbApplication.Services.MongoRepository
{
    public class RockSongsRepository : BaseMongoRepository<RockSong>
    {
        public RockSongsRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
    }
}