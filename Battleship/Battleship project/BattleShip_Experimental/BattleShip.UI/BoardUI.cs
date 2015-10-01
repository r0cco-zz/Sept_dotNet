using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;

namespace BattleShip.UI
{
    class BoardUI
    {
        private static readonly string[] _aToJ = {" A ", " B ", " C ", " D ", " E ", " F ", " G ", " H ", " I ", " J "};

        public static void DisplayGameBoard(Board playerBoard)
        {
            //Board newBoard = new Board();

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

            for (int i = 0; i < 9; i++) //9
            {
                Console.Write("\n" + (i + 1) + " |");
                for (int j = 0; j < 10; j++) //10
                {
                    Coordinate coord = new Coordinate(j+1, i+1);
                    if (playerBoard.ShotHistory.ContainsKey(coord) && playerBoard.ShotHistory[coord].Equals(ShotHistory.Hit)) //Make sure Shot is valid && is a hit.
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Displaychar = "H";
                        Console.Write("  {0}    ", Displaychar);

                        Console.ResetColor();
                        
                    }
                    else if (playerBoard.ShotHistory.ContainsKey(coord) && playerBoard.ShotHistory[coord].Equals(ShotHistory.Miss))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Displaychar = "M";
                        Console.Write("  {0}    ", Displaychar);

                        Console.ResetColor();
                    }
                    else //(playerBoard.ShotHistory.ContainsKey(coord) && playerBoard.ShotHistory.ContainsValue(ShotHistory.Unknown))
                    {
                        Displaychar = " ";
                        Console.Write("  {0}    ", Displaychar);
                    }
                }
                Console.Write("\n  |");
            }
            // loop again for row 10 because of the extra char in the label
            for (int i = 9; i < 10; i++) //10
            {
                Console.Write("\n" + (i + 1) + "|");
                for (int j = 0; j < 10; j++) //10
                {
                    Coordinate coord = new Coordinate(j+1, i+1);
                    if (playerBoard.ShotHistory.ContainsKey(coord) && playerBoard.ShotHistory.ContainsValue(ShotHistory.Hit))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Displaychar = "H";
                        Console.Write("  {0}    ", Displaychar);

                        Console.ResetColor();

                    }
                    if (playerBoard.ShotHistory.ContainsKey(coord) && playerBoard.ShotHistory.ContainsValue(ShotHistory.Miss))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Displaychar = "M";
                        Console.Write("  {0}    ", Displaychar);

                        Console.ResetColor();
                    }
                    else //(playerBoard.ShotHistory.ContainsKey(coord) && playerBoard.ShotHistory.ContainsValue(ShotHistory.Unknown))
                    {
                        Displaychar = " ";
                        Console.Write("  {0}    ", Displaychar);
                    }
                    //Console.Write("  {0}    ", Displaychar);
                }
                Console.WriteLine("\n  |");

            }
        }
    }
}
