using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.Requests;

namespace BattleShip.UI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GameFlow gf = new GameFlow();
            StartMenu sm = new StartMenu();
            //Player player1;
            //Player player2;

            sm.DisplayStart();
            Console.Clear();

            Console.WriteLine("{0}, press enter to start placing ships.\n\n{1} LOOK AWAY!!", "player1.Name",
                "player2.Name");
            Console.ReadLine();
            Console.Clear();

            gf.Player1ShipPlacement();
            Console.Clear();

            Console.WriteLine("{0}, press enter to start placing ships.\n\n{1} LOOK AWAY!!", "player2.Name",
                "player1.Name");
            Console.ReadLine();
            Console.Clear();

            gf.Player2ShipPlacement();
            Console.ReadLine();
            Console.Clear();

            gf.GamePlay();

            Console.ReadLine();
        }
    }
}
