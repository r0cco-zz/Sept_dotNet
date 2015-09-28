using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUpsLoops
{
    public class WarmupsLoops
    {
        public string StringTimes(string str, int n)
        {
            string newstr = "";
            for (int i = 0; i < n; i++)
            {
                newstr += str;
            }
            return newstr;
        }

        public string FrontTimes(string str, int n)
        {
            string newstr = "";
            for (int i = 0; i < n; i++)
            {
                if (str.Length < 3)
                {
                    newstr += str;
                }
                else if (str.Length >= 3)
                {
                    newstr += str.Substring(0, 3);
                }
            }
            return newstr;
        }

        public int CountXX(string str)
        {
            int numberofxxs = 0;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == 'x' && str[i - 1] == 'x')
                {
                    numberofxxs++;
                }
            }
            return numberofxxs;
        }

        public bool DoubleX(string str)
        {
            int posx = 0;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == 'x')
                {
                    posx++;
                    if (posx == 1 && (str[i + 1] == 'x' || str[i - 1] == 'x'))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public string EveryOther(string str)
        {
            string newstr = "";
            for (int i = 0; i < str.Length; i += 2)
            {
                newstr += str[i].ToString();
            }
            return newstr;
        }

        public string StringSplosion(string str)
        {
            string newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                newstr += str.Substring(0, i + 1);
            }
            return newstr;
        }

        public int CountLast2(string str)
        {
            int count = 0;
            string last2 = str.Substring(str.Length - 2);
            for (int i = 0; i < (str.Length - 2); i++)
            {
                if ((str[i].ToString() + str[i+1].ToString()) == last2)
                {
                    count++;
                }
            }
            return count;
        }

        public int Count9(int[] numbers)
        {
            int count = 0;
            foreach (int check in numbers)
            {
                if (check == 9)
                {
                    count++;
                }
            }
            return count;
        }

        public bool ArrayFront9(int[] numbers)
        {
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] == 9)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Array123(int[] numbers)
        {
            if (numbers.Length < 3)
            {
                return false;
            }
            for (int i = 0; i < (numbers.Length - 2); i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
                {
                    return true;
                }
            }
            return false;
        }

        public int SubStringMatch(string a, string b)
        {
            int count = 0;
            string check2a;
            string check2b;
            for (int i = 0; i < a.Length - 1; i++)
            {
                check2a = a.Substring(i, 2);
                for (int j = 0; j < b.Length - 1; j++)
                {
                    check2b = b.Substring(j, 2);
                    if (check2a == check2b)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public string StringX(string str)
        {
            string newstr = "";
            for (int i = 1; i < str.Length-1; i++)
            {
                if (str[i] != 'x')
                {
                    newstr += str[i];
                }
            }
            return str[0] + newstr + str[str.Length - 1];
        }

        public string AltPairs(string str)
        {
            string newstr = "";
            for (int i = 0; i < str.Length; i+=4)
            {
                if (i == str.Length-1)
                {
                    return newstr += str[i];
                }
                newstr += str.Substring(i, 2);
            }
            return newstr;
        }

        public string DoNotYak(string str)
        {
            for (int i = 0; i < str.Length-2; i++)
            {
                if (str[i] == 'y')
                {
                    if (str[i + 2] == 'k')
                    {
                        str = str.Remove(i, 3);
                    }
                }
            }
            return str;
        }

        public int Array667(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] == 6 && (numbers[i + 1] == 6 || numbers[i + 1] == 7))
                {
                    count++;
                }
            }
            return count;
        }

        public bool NoTriples(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-2; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i] == numbers[i + 2])
                {
                    return false;
                }
            }
            return true;
        }

        public bool Pattern51(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                int x = numbers[i];
                if (numbers[i+1] == x+5 && numbers[i+2] == x-1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
