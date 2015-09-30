using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UI
{
    class LetterConverter
    {
        public static int ConvertToNumber(string xAxisGuess)
        {
            if (xAxisGuess.ToLower() == "a")
            {
                return 1;
            }
            if (xAxisGuess.ToLower() == "b")
            {
                return 2;
            }
            if (xAxisGuess.ToLower() == "c")
            {
                return 3;
            }
            if (xAxisGuess.ToLower() == "d")
            {
                return 4;
            }
            if (xAxisGuess.ToLower() == "e")
            {
                return 5;
            }
            if (xAxisGuess.ToLower() == "f")
            {
                return 6;
            }
            if (xAxisGuess.ToLower() == "g")
            {
                return 7;
            }
            if (xAxisGuess.ToLower() == "h")
            {
                return 8;
            }
            if (xAxisGuess.ToLower() == "i")
            {
                return 9;
            }
            if (xAxisGuess.ToLower() == "j")
            {
                return 10;
            }
            return 42;
        }
    }
}
