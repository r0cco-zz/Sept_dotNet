using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UI.GameFlowResponses
{
    public class IsDirectionValid
    {
        public bool IsGood { get; set; }

        public bool TrueFalseDirection(string isValid)
        {
            switch (isValid.ToLower()) //Is ship placement valid?
            {
                case "up":
                case "u":
                case "down":
                case "d":
                case "left":
                case "l":
                case "right":
                case "r":
                    return true;
                default:
                    return false;
            }
        }
    }
}
