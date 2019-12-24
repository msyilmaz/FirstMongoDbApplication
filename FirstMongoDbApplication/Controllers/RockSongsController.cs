using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstMongoDbApplication.Model;
using FirstMongoDbApplication.Services.MongoRepository;
using Microsoft.AspNetCore.Mvc;

namespace FirstMongoDbApplication.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RockSongsController : BaseMongoController<RockSong>
    {

        public RockSongsController(RockSongsRepository rockSongsRepository) : base(rockSongsRepository)
        {
        }
    }
}
