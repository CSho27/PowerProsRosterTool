using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace PowerProsRosterTool.Players
{
    public enum PlayerType
    {
        Pitcher, Hitter
    }

    public static class PlayerTypeMethods
    {
		public static string toString(this PlayerType playerType)
		{
			switch (playerType)
			{
				case PlayerType.Pitcher:
					return "Pitcher";
				case PlayerType.Hitter:
					return "Hitter";
				default:
					return "";
			}
		}

		public static PlayerType fromString(string typeString)
		{
			switch (typeString)
			{
				case "Pitcher":
					return PlayerType.Pitcher;
				case "Hitter":
					return PlayerType.Hitter;
				default:
					return 0;
			}
		}
	}


}
