using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UI
{
    public class Player
    {
        BoardUI PlayerSpecificBoard = new BoardUI();

        public string Name { get; set; }

        public Player(string Name)
        {
            this.Name = Name;
        }
    }
}
