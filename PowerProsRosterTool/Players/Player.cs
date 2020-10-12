using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerProsRosterTool.Players
{
    public class Player
    {
        public int Id { get; private set; }
        public int GlobalPlayerId { get; private set; }
        public virtual GlobalPlayer GlobalPlayer { get; private set;}
        public string FirstName => GlobalPlayer.FirstName;
        public string LastName => GlobalPlayer.LastName;
        public PlayerType PlayerType => GlobalPlayer.PlayerType;
        public int Number { get; private set; }
        public int Year { get; private set; }
        public int PositionId { get; private set; }
        public virtual Position Position { get; private set; }

        protected Player() { }

        public Player(PlayerParameters parameters)
        {
            GlobalPlayer = parameters.GlobalPlayer;
            Number = parameters.Number;
            Year = parameters.Year;
            Position = parameters.Position;
        }
    }

    public class PlayerParameters
    {
        public GlobalPlayer GlobalPlayer { get; set; }
        public int Number { get; set; }
        public int Year { get; set; }
        public Position Position { get; set; }
    }
}
