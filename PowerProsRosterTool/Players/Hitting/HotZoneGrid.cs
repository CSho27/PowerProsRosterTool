using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerProsRosterTool.Players.Hitting
{
    public class HotZoneGrid
    {
        private HotZone[] LocationPreferences { get; set; }

        public HotZoneGrid()
        {
            LocationPreferences = new HotZone[9];
        }

        public HotZonePreference? GetZone(int zoneNumber)
        {
            if (zoneNumber >= 0 && zoneNumber < 9)
                return LocationPreferences[zoneNumber].LocationPreference;
            else
                return null;
        }

        public void SetZone(int zoneNumber, HotZonePreference locationPreference)
        {
            if (zoneNumber >= 0 && zoneNumber < 9)
                LocationPreferences[zoneNumber].LocationPreference = locationPreference;
        }
    }

    public class HotZone
    {
        public int LocationPreferenceGridId { get; } 
        public HotZonePreference LocationPreference { get; set; }

        public HotZone(int locationPreferenceGridId, HotZonePreference locationPreference) 
        {
            LocationPreferenceGridId = locationPreferenceGridId;
            LocationPreference = LocationPreference;
        }
    }
}
