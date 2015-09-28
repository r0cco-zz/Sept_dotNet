using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.Requests;

namespace BattleShip.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            GameFlow gf = new GameFlow();

            StartMenu.DisplayStart();
            BoardUI.DisplayGameBoard();
            Console.Clear();
            gf.Player1ShipPlacement();
            


            Console.ReadLine();
        }
    }
}
