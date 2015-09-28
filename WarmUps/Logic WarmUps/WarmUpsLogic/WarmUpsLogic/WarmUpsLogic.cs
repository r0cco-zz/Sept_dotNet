using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUpsLogic
{
    public class WarmUpsLogic
    {
        public bool GreatParty(int cigars, bool isWeekend)
        {
            if (isWeekend)
            {
                if (cigars >= 40)
                {
                    return true;
                }
            }
            if (!isWeekend)
            {
                if (cigars >= 40 && cigars <= 60)
                {
                    return true;
                }
            }
            return false;
        }

        public int CanHazTable(int yourStyle, int dateStyle)
        {
            if (yourStyle >= 8 && dateStyle >= 3)
            {
                return 2;
            }
            if (yourStyle >= 3)
            {
                if (dateStyle >= 8)
                {
                    return 2;
                }
                if (dateStyle >= 3)
                {
                    return 1;
                }
                return 0;
            }
            return 0;
        }

        public bool PlayOutside(int temp, bool isSummer)
        {
            if (isSummer)
            {
                if (temp <= 100 && temp >= 60)
                {
                    return true;
                }
            }
            else if (temp <= 90 && temp >= 60)
            {
                return true;
            }
            return false;
        }

        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            if (isBirthday)
            {
                if (speed <= 65)
                {
                    return 0;
                }
                if (speed > 65 && speed <= 85)
                {
                    return 1;
                }
                if (speed > 85)
                {
                    return 2;
                }
            }
            if (speed <= 60)
            {
                return 0;
            }
            if (speed > 60 && speed <= 80)
            {
                return 1;
            }
            if (speed > 80)
            {
                return 2;
            }
            return 0;
        }

        public int SkipSum(int a, int b)
        {
            int sum = a + b;
            if (sum >= 10 && sum < 20)
            {
                return 20;
            }
            return sum;
        }

        public string AlarmClock(int day, bool vacation)
        {
            if (vacation)
            {
                if (day == 0 || day == 6)
                {
                    return "off";
                }
                return "10:00";
            }
            if (day == 0 || day == 6)
            {
                return "10:00";
            }
            return "7:00";
        }

        public bool LoveSix(int a, int b)
        {
            if (a == 6 || b == 6)
            {
                return true;
            }
            if (a + b == 6 || a - b == 6)
            {
                return true;
            }
            return false;
        }

        public bool InRange(int n, bool outsideMode)
        {
            if (outsideMode)
            {
                if (n <= 1 || n >= 10)
                {
                    return true;
                }
                return false;
            }
            if (n <= 10 && n >= 1)
            {
                return true;
            }
            return false;
        }

        public bool SpecialEleven(int n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            if (n%11 == 0 || n%11 == 1)
            {
                return true;
            }
            return false;
        }

        public bool Mod20(int n)
        {
            if (n%20 == 1 || n%20 == 2)
            {
                return true;
            }
            return false;
        }

        public bool Mod35(int n)
        {
            if (n%3 == 0 || n%5 == 0)
            {
                if (n%3 == 0 && n%5 == 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (!isAsleep)
            {
                if (isMorning)
                {
                    if (isMom)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }

        public bool TwoIsOne(int a, int b, int c)
        {
            if (a + b == c)
            {
                return true;
            }
            return false;
        }

        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            if (bOk)
            {
                if (c > a)
                {
                    return true;
                }
            }
            if (c > b && b > a)
            {
                return true;
            }
            return false;
        }

        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            if (equalOk)
            {
                if (c >= b && b >= a)
                {
                    return true;
                }
            }
            if (c > b && b > a)
            {
                return true;
            }
            return false;
        }

        public bool LastDigit(int a, int b, int c)
        {
            if (int.Parse(a.ToString().Substring(a.ToString().Length - 1)) ==
                int.Parse(b.ToString().Substring(b.ToString().Length - 1)) ||
                int.Parse(a.ToString().Substring(a.ToString().Length - 1)) ==
                int.Parse(c.ToString().Substring(c.ToString().Length - 1)) ||
                int.Parse(b.ToString().Substring(b.ToString().Length - 1)) ==
                int.Parse(c.ToString().Substring(c.ToString().Length - 1)))
            {
                return true;
            }
            return false;
        }

        public int RollDice(int die1, int die2, bool noDoubles)
        {
            if (noDoubles)
            {
                if (die1 == die2)
                {
                    if (die1 == 6)
                    {
                        return 1 + die2;
                    }
                    return die1 + die2 + 1;
                }
            }
            return die1 + die2;
        }
    }
}
