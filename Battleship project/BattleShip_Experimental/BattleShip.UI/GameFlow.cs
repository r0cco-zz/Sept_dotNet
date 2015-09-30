using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
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

        private bool _isPlayerOnesTurn = true;
        private bool _gameOver = false;

        // get player 1 to place ships
        public void Player1ShipPlacement()
        {
            // display empty game board for player1 (I put this in the loop)

            // prompt player1 for coordinate entry (use letterconverter for xcoordinate)
            foreach (ShipType stype in Enum.GetValues(typeof (ShipType)))
            {
                BoardUI.DisplayGameBoard(_player1Board);
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
            // display empty game board for player1 (I put this in the loop)

            // prompt player1 for coordinate entry (use letterconverter for xcoordinate)
            foreach (ShipType stype in Enum.GetValues(typeof (ShipType)))
            {
                BoardUI.DisplayGameBoard(_player2Board);
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

        // actual shooting and gameplay
        public void GamePlay()
        {
            while (!_gameOver)
            {
                while (_isPlayerOnesTurn)
                {
                    BoardUI.DisplayGameBoard(_player2Board);

                    Console.Write("{0}, Take a shot! : ", "player1.name");
                    string p1shot = Console.ReadLine();
                    //checks

                    string p1shotx = p1shot.Substring(0, 1);
                    int p1shotxasint = LetterConverter.ConvertToNumber(p1shotx);
                    int p1shoty = int.Parse(p1shot.Substring(1));

                    Coordinate shotcoord = new Coordinate(p1shotxasint, p1shoty);

                    var p1FireShotResponse = _player2Board.FireShot(shotcoord);

                    if (p1FireShotResponse.ShotStatus == ShotStatus.Hit)
                    {
                        Console.WriteLine("Hit! (Press enter)");
                        Console.ReadLine();
                        Console.Clear();
                        _isPlayerOnesTurn = false;
                    }
                    if (p1FireShotResponse.ShotStatus == ShotStatus.Duplicate)
                    {
                        Console.WriteLine("You already shot at that spot! (Press enter)");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if (p1FireShotResponse.ShotStatus == ShotStatus.HitAndSunk)
                    {
                        Console.WriteLine("Hit, and you sunk it! (Press enter)");
                        Console.ReadLine();
                        Console.Clear();
                        _isPlayerOnesTurn = false;
                    }
                    if (p1FireShotResponse.ShotStatus == ShotStatus.Invalid)
                    {
                        Console.WriteLine("Invalid coordinate, try again! (Press enter)");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if (p1FireShotResponse.ShotStatus == ShotStatus.Miss)
                    {
                        Console.WriteLine("Miss! (Press enter)");
                        Console.ReadLine();
                        Console.Clear();
                        _isPlayerOnesTurn = false;
                    }
                    if (p1FireShotResponse.ShotStatus == ShotStatus.Victory)
                    {
                        Console.WriteLine("Congrats, you won!! (Press enter)");
                        Console.ReadLine();
                        Console.Clear();
                        _gameOver = true;
                    }

                }

                while (!_isPlayerOnesTurn)
                {
                    BoardUI.DisplayGameBoard(_player1Board);

                    Console.Write("{0}, Take a shot! : ", "player2.name");
                    string p1shot = Console.ReadLine();
                    //checks

                    string p2shotx = p1shot.Substring(0, 1);
                    int p2shotxasint = LetterConverter.ConvertToNumber(p2shotx);
                    int p2shoty = int.Parse(p1shot.Substring(1));

                    Coordinate shotcoord = new Coordinate(p2shotxasint, p2shoty);

                    var p2FireShotResponse = _player1Board.FireShot(shotcoord);

                    if (p2FireShotResponse.ShotStatus == ShotStatus.Hit)
                    {
                        Console.WriteLine("Hit! (Press enter)");
                        Console.ReadLine();
                        Console.Clear();
                        _isPlayerOnesTurn = true;
                    }
                    if (p2FireShotResponse.ShotStatus == ShotStatus.Duplicate)
                    {
                        Console.WriteLine("You already shot at that spot! (Press enter)");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if (p2FireShotResponse.ShotStatus == ShotStatus.HitAndSunk)
                    {
                        Console.WriteLine("Hit, and you sunk it! (Press enter)");
                        Console.ReadLine();
                        Console.Clear();
                        _isPlayerOnesTurn = true;
                    }
                    if (p2FireShotResponse.ShotStatus == ShotStatus.Invalid)
                    {
                        Console.WriteLine("Invalid coordinate, try again! (Press enter)");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if (p2FireShotResponse.ShotStatus == ShotStatus.Miss)
                    {
                        Console.WriteLine("Miss! (Press enter)");
                        Console.ReadLine();
                        Console.Clear();
                        _isPlayerOnesTurn = true;
                    }
                    if (p2FireShotResponse.ShotStatus == ShotStatus.Victory)
                    {
                        Console.WriteLine("Congrats, you won!! (Press enter)");
                        Console.ReadLine();
                        Console.Clear();
                        _gameOver = true;
                    }

                }
            }
        }
    }
}
