using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerProsRosterTool.Players.Hitting
{
    public class PositionCapabilityList
    {
        public int PitcherId { get; private set; }
        public virtual PositionCapability Pitcher { get; private set; }

        public int CatcherId { get; private set; }
        public PositionCapability Catcher { get; private set; }

        public int FirstBaseId { get; private set; }
        public PositionCapability FirstBase { get; private set; }

        public int SecondBaseId { get; private set; }
        public PositionCapability SecondBase { get; private set; }

        public int ThirdBaseId { get; private set; }
        public PositionCapability ThirdBase { get; private set; }

        public int ShortstopId { get; private set; }
        public PositionCapability Shortstop { get; private set; }

        public int LeftFieldId { get; private set; }
        public PositionCapability LeftField { get; private set; }

        public int CenterFieldId { get; private set; }
        public PositionCapability CenterField { get; private set; }

        public int RightFieldId { get; private set; }
        public PositionCapability RightField { get; private set; }

        public IEnumerable<PositionCapability> PositionCapabilities => new PositionCapability[] 
        { 
            Pitcher,
            Catcher,
            FirstBase,
            SecondBase,
            ThirdBase,
            Shortstop,
            LeftField,
            CenterField,
            RightField,

        };
    }

    public class PositionCapability
    {
        public int PositionId { get; private set; }
        public Position Position { get; private set; }
        public Grade Grade { get; private set; }
    }
}
