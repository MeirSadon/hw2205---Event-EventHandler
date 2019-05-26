using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_2205___EventAndEventHandler
{
    interface IGameViewer
    {
        void GoodSpaceShipHpChangedEventHandler(object sender, PointsEventsArgs e);
        void GoodSpaceShipLocationChangedEventHandler(object sender, LocationEventsArgs e);
        void GoodSpaceShipDestroyedEventHandler(object sender, LocationEventsArgs e);
        void BadShipExplodedEventHandler(object sender, BadShipsExplodedEventsArgs e);
        void LevelUpReachedEventHandler(object sender, LevelEventsArgs e);
    }
}
