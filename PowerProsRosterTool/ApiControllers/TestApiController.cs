using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PowerProsRosterTool.ApiControllers
{
    [Route("api/test")]
    [ApiController]
    public class TestApiController : ControllerBase
    {

        public TestApiController() { }

        [HttpGet("get-data")]
        public TestResponse GetData()
        {
            var context = new PowerProsDbContext();
            var player = context.Player.First();
            return TestResponse.ForPlayer(player);
        }
    }

    public class TestResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public static TestResponse ForPlayer(Player player)
        {
            return new TestResponse() { 
                Id = player.Id,
                Name = player.Name,
                Number = player.Number
            };
        }
    }
}
