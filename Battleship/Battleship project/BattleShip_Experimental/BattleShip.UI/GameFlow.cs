using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Ships;

namespace BattleShip.UI
{
    internal class GameFlow
    {
        public Player player1 { get; set; }
        public Player player2 { get; set; }

        private Board _player1Board = new Board();
        private Board _player2Board = new Board();

        //private int[,] boardarray = new int[10, 10];

        //private bool _isPlayerOnesTurn;

        // get player 1 to place a ship
        public object Player1ShipPlacement()
        {
            // display empty game board for player1 (I put this in the loop)

            // prompt player1 for coordinate entry (use letterconverter for xcoordinate)
            foreach (ShipType stype in Enum.GetValues(typeof (ShipType)))
            {
                BoardUI.DisplayGameBoard();
                Console.Write("{0}, pick a coordinate for your {1} : ", "player1.Name", stype);
                string shipplacecoord = Console.ReadLine();
                string xAsLetter = shipplacecoord.Substring(0, 1);
                int shipX = LetterConverter.ConvertToNumber(xAsLetter); //Convert 1st char from player input to int.
                int shipY = int.Parse(shipplacecoord.Substring(1)); //Assign 2nd coord.
                Coordinate shipcoord = new Coordinate(shipX, shipY);

                // and then, asking for ship direction
                Console.Write("{0}, Enter a direction for your {1} (up, down, left, right) : ", "player1.Name", stype);
                string shipPlacementDirection = Console.ReadLine();
                if (shipPlacementDirection == "up")
                {
                    this.;
                }
                if (shipPlacementDirection == "down")
                {
                    return ShipDirection.Down;
                }
                if (shipPlacementDirection == "left")
                {
                    return ShipDirection.Left;
                }
                if (shipPlacementDirection == "right")
                {
                    return ShipDirection.Right;
                }
                return 42;
            }
            return 42;
        }
    }
}
