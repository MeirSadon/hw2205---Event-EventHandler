using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hw_2205___EventAndEventHandler
{
    class GameViewer : IGameViewer
    {
        public void GoodSpaceShipHpChangedEventHandler(object sender, PointsEventsArgs e)
        {
            Console.WriteLine($"Now, Your Hp Is: {e.HpPoints}.");
            //Thread.Sleep(1000);
        }
        public void GoodSpaceShipLocationChangedEventHandler(object sender, LocationEventsArgs e)
        {
            Console.WriteLine($"Your Location Is Change To: {e.X}/{e.Y}.");
            //Thread.Sleep(1000);
        }
        public void GoodSpaceShipDestroyedEventHandler(object sender, LocationEventsArgs e)
        {
            Console.WriteLine($"\n\nThe Game Is Over! Your Ship Destroyed At: {e.X}/{e.Y} ):");
            //Thread.Sleep(2000);
        }
        public void BadShipExplodedEventHandler(object sender, BadShipsExplodedEventsArgs e)
        {
            Console.WriteLine($"BOOMM ! ! ! You Need To Explode More {e.NumberOfBadShips} Bad Ships.");
            //Thread.Sleep(1000);
        }
        public void LevelUpReachedEventHandler(object sender, LevelEventsArgs e)
        {
            Console.WriteLine($"Excellent!!! You Reached {e.CurrentLevel} Level !!");
            //Thread.Sleep(1000);
        }
    }
}
