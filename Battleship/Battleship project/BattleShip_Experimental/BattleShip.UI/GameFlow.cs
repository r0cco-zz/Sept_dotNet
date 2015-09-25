using System;
using System.Collections.Generic;
using System.Linq;
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

        // get player 1 to place a carrier
        public void Player1CarrierPlacement()
        {
            // display empty game board for player1
            BoardUI.DisplayGameBoard();

            // prompt player1 for coordinate entry (use letterconverter for xcoordinate)

            Console.Write("{0}, pick a coordinate for your Carrier : ", "player1.name");
            string player1CarrierPlacement = Console.ReadLine();
            string xAsLetter = player1CarrierPlacement.Substring(0, 1);
            int carrierX = LetterConverter.ConvertToNumber(xAsLetter);
            int carrierY = int.Parse(player1CarrierPlacement.Substring(1));

            Coordinate carrierPlacementCoord = new Coordinate(carrierX,carrierY);

            Console.Clear();

            // display game board with coordinate highlighted
            BoardUI.DisplayGameBoard();
             Console.ForegroundColor = ConsoleColor.Red;

            // prompt player1 for carrier direction
        }
    }
}
