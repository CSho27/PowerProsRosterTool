using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PowerProsRosterTool.Players
{
    public class GlobalPlayer
    {
        public ILazyLoader LazyLoader { get; set; }
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public PlayerType PlayerType { get; private set; }

        protected GlobalPlayer() {  }

        public GlobalPlayer(GlobalPlayerParameters parameters)
        {
            FirstName = parameters.FirstName;
            LastName = parameters.LastName;
            PlayerType = parameters.PlayerType;
        }
    }

    public class GlobalPlayerParameters
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PlayerType PlayerType { get; set; }
    }
}
