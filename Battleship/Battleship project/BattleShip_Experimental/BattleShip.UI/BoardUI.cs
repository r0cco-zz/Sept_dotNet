using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.Requests;

namespace BattleShip.UI
{
    internal class BoardUI
    {
        private static readonly Coordinate shipcoord;
        private static readonly string[] _aToJ = {" A ", " B ", " C ", " D ", " E ", " F ", " G ", " H ", " I ", " J "};

        public static void DisplayGameBoard()
        {
            string Displaychar = "0";
            //get Displaychar to change based on ship placement & shot history

            for (int i = 0; i < 10; i++)
            {
                Console.Write("    {0}", _aToJ[i]);
            }

            Console.Write("\n");

            for (int i = 0; i < 35; i++)
            {
                Console.Write("__");
            }

            // loop to get all values (including row 10) for values to fill coordinate object (necessary?)

            for (int i = 0; i < 9; i++)
            {
                Console.Write("\n" + (i + 1) + " |");
                for (int j = 0; j < 10; j++)
                {
                    Coordinate coord = new Coordinate(i, j);
                    if (coord.Equals(shipcoord))
                    {
                        Displaychar = "X";
                    }
                    Console.Write("  {0}    ", Displaychar);
                }
                Console.Write("\n  |");
            }
            // loop again for row 10 because of the extra char in the label
            for (int i = 9; i < 10; i++)
            {
                Console.Write("\n" + (i + 1) + "|");
                for (int j = 0; j < 10; j++)
                {
                    Coordinate coord = new Coordinate(i, j);
                    if (coord.Equals(shipcoord))
                    {
                        Displaychar = "X";
                    }
                    Console.Write("  {0}    ", Displaychar);
                }
                Console.WriteLine("\n  |");

            }
            Console.ReadLine();
        }
    }
}
