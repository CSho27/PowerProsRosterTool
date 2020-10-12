using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PowerProsRosterTool.Players;

namespace PowerProsRosterTool.ApiControllers
{
    [Route("api/test")]
    [ApiController]
    public class TestApiController : ControllerBase
    {

        public TestApiController() { }

        [HttpGet("get-data")]
        public IEnumerable<TestResponse> GetData()
        {
            var context = new PowerProsDbContext();
            var playerParams = new PlayerParameters()
            {
                GlobalPlayer = new GlobalPlayer(new GlobalPlayerParameters()
                {
                    FirstName = "Tony",
                    LastName = "Gwymnn",
                    PlayerType = PlayerType.Hitter
                }),
                Year = 1998,
                Number = 24
            };
            var player = new Player(playerParams);
            context.Player.Add(player);
            context.SaveChanges();
            var players = context.Player.ToList();
            return players.Select(p => TestResponse.ForPlayer(p));
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
                Name = $"{player.LastName}, {player.FirstName}",
                Number = player.Number
            };
        }
    }
}
