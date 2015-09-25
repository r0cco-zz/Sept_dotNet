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
            Player player1 = new Player(player1Name);

            Console.Write("Player 2, what is your name? : ");
            string player2name = Console.ReadLine();
            if (player2name == "")
            {
                player2name = "Player2";
            }
            Player player2 = new Player(player2name);

            Console.Clear();
        }
    }
}
