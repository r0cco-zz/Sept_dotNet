using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UI
{
    class StartMenu
    {
        public void DisplayStart()
        {

            Console.Write("Battleship!! \n\nPlayer 1, What is your name? : ");
            string player1Name = Console.ReadLine();
            if (player1Name == "")
            {
                player1Name = "Player1";
            }

            //Player player1 = new Player(player1Name);
            Player.Name1 = player1Name;
            Console.Write("Player 2, what is your name? : ");
            string player2Name = Console.ReadLine();
            if (player2Name == "")
            {
                player2Name = "Player2";
            }
            //Player player2 = new Player(player2Name);
            Player.Name2 = player2Name;

            Console.Clear();
        }
    }
}
