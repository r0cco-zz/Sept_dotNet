using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;

namespace BattleShip.UI
{
    class GameFlow
    {
        public Player player1 { get; set; }
        public Player player2 { get; set; }

        Board _player1Board = new Board();
        Board _player2Board = new Board();

        int[,] boardarray = new int[10,10];

        //private bool _isPlayerOnesTurn;

        static string[] aToJ = {" A "," B "," C "," D "," E "," F "," G "," H "," I "," J "};

        public static void DisplayGameBoard()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("   {0} ",aToJ[i]);
            }

            Console.Write("\n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("\n" + i);
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("   x   ");
                }
            }
        }

    }
}
