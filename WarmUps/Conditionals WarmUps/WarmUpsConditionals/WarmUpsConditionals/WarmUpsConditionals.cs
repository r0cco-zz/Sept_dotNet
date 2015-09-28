using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WarmUpsConditionals
{
    public class WarmUpsConditionals
    {
        // warmups exercise for conditionals

        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if ((aSmile && bSmile) || (!aSmile && !bSmile))
            {
                return true;
            }
            return false;
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if (!isWeekday || isVacation)
            {
                return true;
            }
            return false;
        }

        public int SumDouble(int a, int b)
        {
            if (a == b)
            {
                return (2*(a + b));
            }
            return (a + b);
        }

        public int Diff21(int n)
        {
            if (n > 21)
            {
                return (2*Math.Abs(21 - n));
            }
            return Math.Abs(21 - n);
        }

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if (isTalking && (hour < 7 || hour > 20))
            {
                return true;
            }
            return false;
        }

        public bool Makes10(int a, int b)
        {
            if ((a + b == 10) || (a == 10 || b == 10))
            {
                return true;
            }
            return false;
        }

        public string FrontBack(string str)
        {
            if (str.Length < 2)
            {
                return str;
            }
            return str[str.Length - 1] + str.Substring(1, str.Length - 2) + str[0];
        }

        public string Front3(string str)
        {
            if (str.Length < 3)
            {
                return str + str + str;
            }
            return str.Substring(0, 3) + str.Substring(0, 3) + str.Substring(0, 3);
        }

        public string BackAround(string str)
        {
            return str[str.Length - 1] + str + str[str.Length - 1];
        }

        public bool Multiple3Or5(int number)
        {
            if (number == 0)
            {
                return false;
            }
            if (number%3 == 0 || number%5 == 0)
            {
                return true;
            }
            return false;
        }

        public bool StartHi(string str)
        {
            if (str.ToLower() == "hi")
            {
                return true;
            }
            if (str.Substring(0, 2).ToLower() == "hi" && str[2] == ' ')
            {
                return true;
            }
            return false;
        }

        public bool IcyHot(int temp1, int temp2)
        {
            if ((temp1 < 0 && temp2 > 100) || (temp1 > 100 && temp2 < 0))
            {
                return true;
            }
            return false;
        }

        public bool Between10And20(int a, int b)
        {
            if ((a >= 10 && a <= 20) || (b >= 10 && b <= 20))
            {
                return true;
            }
            return false;
        }

        public bool HasTeen(int a, int b, int c)
        {
            if ((a >= 13 && a <= 19) || (b >= 13 && b <= 19) || (c >= 13 && c <= 19))
            {
                return true;
            }
            return false;
        }

        public bool SoAlone(int a, int b)
        {
            if ((a >= 13 && a <= 19) ^ (b >= 13 && b <= 19))
            {
                return true;
            }
            return false;
        }

        public string RemoveDel(string str)
        {
            if (str.Substring(1, 3) == "del")
            {
                return str[0] + str.Substring(4);
            }
            return str;
        }

        public bool IxStart(string str)
        {
            if (str.Substring(1, 2) == "ix")
            {
                return true;
            }
            return false;
        }

        public string StartOz(string str)
        {
            if (str[0] == 'o')
            {
                if (str[1] == 'z')
                {
                    return "oz";
                }
                return "o";
            }
            if (str[1] == 'z')
            {
                return "z";
            }
            return "";
        }

        public int Max(int a, int b, int c)
        {
            if (Math.Max(a, b) > c)
            {
                return Math.Max(a, b);
            }
            return c;
        }

        public int Closer(int a, int b)
        {
            if (Math.Abs(10 - a) < Math.Abs(10 - b))
            {
                return a;
            }
            if (Math.Abs(10 - a) > Math.Abs(10 - b))
            {
                return b;
            }
            return 0;
        }

        public bool GotE(string str)
        {
            int numberOfEs = 0;
            foreach (char e in str)
            {
                if (e == 'e')
                {
                    numberOfEs++;
                }
            }
            if (numberOfEs >= 1 && numberOfEs <= 3)
            {
                return true;
            }
            return false;
        }

        public string EndUp(string str)
        {
            if (str.Length <= 3)
            {
                return str.ToUpper();
            }
            return str.Substring(0, str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
        }

        public string EveryNth(string str, int n)
        {
            string newstr = "";
            if (str == "")
            {
                return str;
            }
            for (int i = 0; i*n < str.Length; i++)
            {
                newstr += str[i*n].ToString();
            }
            return newstr;
        }
    }
}
