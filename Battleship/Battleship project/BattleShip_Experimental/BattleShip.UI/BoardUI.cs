using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.Requests;

namespace BattleShip.UI
{
    class BoardUI
    {
        private static readonly string[] _aToJ = { " A ", " B ", " C ", " D ", " E ", " F ", " G ", " H ", " I ", " J " };

        public static void DisplayGameBoard()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("    {0}", _aToJ[i]);
            }

            Console.Write("\n");

            for (int i = 0; i < 9; i++)
            {
                Console.Write("\n" + (i + 1) + " |");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("  {0},{1}  ", i, j);
                }
                Console.Write("\n  |");
            }
            // loop again for row 10 because of the extra char in the label
            for (int i = 9; i < 10; i++)
            {
                Console.Write("\n" + (i + 1) + "|");
                for (int j = 0; j < 10; j++)
                {
                    // end goal is to write a character indicating shot history (and ship placement?)
                    Console.Write("  {0},{1}  ", i, j);
                }
                Console.WriteLine("\n  |");

            }
            Console.ReadLine();

            // loop again to get all values (including row 10) for values to fill coordinate object
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Coordinate coord = new Coordinate(i,j);
                }
            }
        }
    }
}
