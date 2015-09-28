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

        // get player 1 to place ships
        public void Player1ShipPlacement()
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
                Console.Write("{0}, Enter a direction (up, down, left, right) for your {1} (length {2}) : ",
                    "player1.Name", stype, "ship length");
                string shipPlacementDirection = Console.ReadLine();
                if (shipPlacementDirection.ToLower() == "up")
                {
                    PlaceShipRequest shipRequest = new PlaceShipRequest
                    {
                        Coordinate = shipcoord,
                        Direction = ShipDirection.Up,
                        ShipType = stype
                    };
                    _player1Board.PlaceShip(shipRequest);
                    //checks
                    ShipCreator.CreateShip(stype);
                }
                if (shipPlacementDirection.ToLower() == "down")
                {
                    PlaceShipRequest shipRequest = new PlaceShipRequest
                    {
                        Coordinate = shipcoord,
                        Direction = ShipDirection.Down,
                        ShipType = stype
                    };
                    _player1Board.PlaceShip(shipRequest);
                    //checks
                    ShipCreator.CreateShip(stype);
                }
                if (shipPlacementDirection.ToLower() == "left")
                {
                    PlaceShipRequest shipRequest = new PlaceShipRequest
                    {
                        Coordinate = shipcoord,
                        Direction = ShipDirection.Left,
                        ShipType = stype
                    };
                    _player1Board.PlaceShip(shipRequest);
                    //checks
                    ShipCreator.CreateShip(stype);
                }
                if (shipPlacementDirection.ToLower() == "right")
                {
                    PlaceShipRequest shipRequest = new PlaceShipRequest
                    {
                        Coordinate = shipcoord,
                        Direction = ShipDirection.Right,
                        ShipType = stype
                    };
                    _player1Board.PlaceShip(shipRequest);
                    //checks
                    ShipCreator.CreateShip(stype);
                }

                Console.Clear();
            }
        }

        // get player 2 to place ships
        public void Player2ShipPlacement()
        {
            // display empty game board for player2 (I put this in the loop)

            // prompt player2 for coordinate entry (use letterconverter for xcoordinate)
            foreach (ShipType stype in Enum.GetValues(typeof (ShipType)))
            {
                BoardUI.DisplayGameBoard(); //this is gonna have to be player specific
                Console.Write("{0}, pick a coordinate for your {1} : ", "player2.Name", stype);
                string shipplacecoord = Console.ReadLine();
                string xAsLetter = shipplacecoord.Substring(0, 1);
                int shipX = LetterConverter.ConvertToNumber(xAsLetter); //Convert 1st char from player input to int.
                int shipY = int.Parse(shipplacecoord.Substring(1)); //Assign 2nd coord.
                Coordinate shipcoord = new Coordinate(shipX, shipY);

                // and then, asking for ship direction
                Console.Write("{0}, Enter a direction (up, down, left, right) for your {1} (length {2}) : ",
                    "player2.Name", stype, "ship length");
                string shipPlacementDirection = Console.ReadLine();
                if (shipPlacementDirection.ToLower() == "up")
                {
                    PlaceShipRequest shipRequest = new PlaceShipRequest
                    {
                        Coordinate = shipcoord,
                        Direction = ShipDirection.Up,
                        ShipType = stype
                    };
                    _player2Board.PlaceShip(shipRequest);
                    //checks
                    ShipCreator.CreateShip(stype);
                }
                if (shipPlacementDirection.ToLower() == "down")
                {
                    PlaceShipRequest shipRequest = new PlaceShipRequest
                    {
                        Coordinate = shipcoord,
                        Direction = ShipDirection.Down,
                        ShipType = stype
                    };
                    _player2Board.PlaceShip(shipRequest);
                    //checks
                    ShipCreator.CreateShip(stype);
                }
                if (shipPlacementDirection.ToLower() == "left")
                {
                    PlaceShipRequest shipRequest = new PlaceShipRequest
                    {
                        Coordinate = shipcoord,
                        Direction = ShipDirection.Left,
                        ShipType = stype
                    };
                    _player2Board.PlaceShip(shipRequest);
                    //checks
                    ShipCreator.CreateShip(stype);
                }
                if (shipPlacementDirection.ToLower() == "right")
                {
                    PlaceShipRequest shipRequest = new PlaceShipRequest
                    {
                        Coordinate = shipcoord,
                        Direction = ShipDirection.Right,
                        ShipType = stype
                    };
                    _player2Board.PlaceShip(shipRequest);
                    //checks
                    ShipCreator.CreateShip(stype);
                }

                Console.Clear();
            }
        }
    }
}
