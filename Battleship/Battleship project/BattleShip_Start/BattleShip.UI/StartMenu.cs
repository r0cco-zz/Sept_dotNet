using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UI
{
    class StartMenu
    {
        public static void DisplayStart()
        {
            Console.Write("Battleship!! \n\nPlayer 1, What is your name? : ");
            string player1Name = Console.ReadLine();
            if (player1Name == "")
            {
                player1Name = "Player1";
            }

            Console.Write("\nPlayer 2, what is your name? : ");
            string player2Name = Console.ReadLine();
            if (player2Name == "")
            {
                player2Name = "Player2";
            }
        }
    }
}
