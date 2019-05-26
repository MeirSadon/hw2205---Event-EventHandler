using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_2205___EventAndEventHandler
{
    public class PointsEventsArgs : EventArgs
    {
        public int HpPoints { get; set; }
    }

    public class LocationEventsArgs : EventArgs
    {
        public int X { get; set; }
        public int Y { get; set; }

    }

    public class BadShipsExplodedEventsArgs : EventArgs
    {
        public int NumberOfBadShips { get; set; }
    }

    public class LevelEventsArgs : EventArgs
    {
        public int CurrentLevel { get; set; }
    }
}