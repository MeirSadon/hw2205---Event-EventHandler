using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace hw_2205___EventAndEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            GameViewer GV = new GameViewer();
            SpaceQuestGameManager SQGM = new SpaceQuestGameManager(100, 20, 30);
            Random r = new Random();
            System.Timers.Timer timer = new System.Timers.Timer(1000);

            SQGM.GoodSpaceShipHpChanged += GV.GoodSpaceShipHpChangedEventHandler;
            SQGM.GoodSpaceShipLocationChanged += GV.GoodSpaceShipLocationChangedEventHandler;
            SQGM.BadShipExploded += GV.BadShipExplodedEventHandler;
            SQGM.LevelUpReached += GV.LevelUpReachedEventHandler;
            SQGM.GoodSpaceShipDestroyed += GV.GoodSpaceShipDestroyedEventHandler;


            timer.Elapsed += (sender, e) =>
            {
                    int x = r.Next(1, 4);
                    if (SQGM.WaitForNewGame == false)
                    {
                        switch (x)
                        {
                            case 1:
                                SQGM.GoodShipSpaceGetDamage(r.Next(3,40));
                                break;
                            case 2:
                                SQGM.EnemyShipDestroyed(r.Next(1,7));
                                break;
                            case 3:
                                SQGM.MoveSpaceShip(r.Next(1500), r.Next(1500));
                                break;
                            default: break;
                        }
                    }
            };
            timer.Start();
            while (true)
            {

            }
        }
    }
}
