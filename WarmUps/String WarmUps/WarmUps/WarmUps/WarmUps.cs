using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUps
{
    public class WarmUps
    {
        // string warmup methods
        public string SayHi(string name)
        {
            return "Hello " + name + "!";
        }

        public string Abba(string stringA, string stringB)
        {
            return stringA + stringB + stringB + stringA;
        }

        public string MakeTags(string tag, string content)
        {
            return "<" + tag + ">" + content + "<" + tag + ">";
        }

        public string InsertWord(string container, string word)
        {
            return container.Substring(0, 2) + word + container.Substring(2, 2);
        }

        public string MultipleEndings(string str)
        {
            return str.Substring(str.Length - 2) + str.Substring(str.Length - 2) + str.Substring(str.Length - 2);
        }

        public string FirstHalf(string str)
        {
            return str.Substring((0), (str.Length/2));
        }

        public string TrimOne(string str)
        {
            return str.Substring(1, (str.Length - 2));
        }

        public string LongInMiddle(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return b + a + b;
            }

            return a + b + a;
        }

        public string RotateLeft2(string str)
        {
            return str.Substring(2) + str.Substring(0, 2);
        }

        public string RotateRight2(string str)
        {
            return str.Substring((str.Length - 2)) + str.Substring(0, (str.Length - 2));
        }

        public string TakeOne(string str, bool fromFront)
        {
            if (fromFront)
            {
                return str.Substring(0, 1);
            }
            return str.Substring((str.Length - 1), 1);
        }

        public string MiddleTwo(string str)
        {
            return str.Substring(((str.Length/2) - 1), 2);
        }

        public bool EndsWithLy(string str)
        {
            if (str.Length < 2)
            {
                return false;
            }
            if (str.Substring(str.Length - 2) == "ly")
            {
                return true;
            }
            return false;
        }

        public string FrontAndBack(string str, int n)
        {
            return str.Substring(0, n) + str.Substring(str.Length - n);
        }

        public string TakeTwoFromPosition(string str, int n)
        {
            if (str.Substring(n).Length < 2)
            {
                return str.Substring(0, 2);
            }
            return str.Substring(n, 2);
        }

        public bool HasBad(string str)
        {
            if (str.Length < 3 || (str.Length == 3 && str != "bad"))
            {
                return false;
            }
            if (str.Substring(0, 3) == "bad" || str.Substring(1, 3) == "bad")
            {
                return true;
            }
            return false;

        }

        public string AtFirst(string str)
        {
            if (str.Length == 0)
            {
                return "@@";
            }
            if (str.Length == 1)
            {
                return str + "@";
            }
            return str.Substring(0, 2);
        }

        public string LastChars(string a, string b)
        {
            if (a.Length == 0)
            {
                a = "@";
            }
            if (b.Length == 0)
            {
                b = "@";
            }
            return a.Substring(0, 1) + b.Substring(b.Length - 1);
        }

        public string ConCat(string a, string b)
        {
            if (a.Length == 0 || b.Length == 0)
            {
                return a + b;
            }
            if (a[(a.Length - 1)] == b[0])
            {
                return a + b.Substring(1);
            }
            return a + b;
        }

        public string SwapLast(string str)
        {
            if (str.Length == 0 || str.Length == 1)
            {
                return str;
            }
            return str.Substring(0, (str.Length - 2)) + str[str.Length - 1] + str[str.Length - 2];
        }

        public bool FrontAgain(string str)
        {
            if (str.Substring(0, 2) == str.Substring((str.Length - 2), 2))
            {
                return true;
            }
            return false;
        }

        public string MinCat(string a, string b)
        {
            if (a.Length == b.Length)
            {
                return a + b;
            }
            if (a.Length > b.Length)
            {
                return a.Substring((a.Length - b.Length)) + b;
            }
            if (a.Length < b.Length)
            {
                return a + b.Substring((b.Length - a.Length));
            }
            // giving error "not all code paths return a value" without next line
            return "I'm only putting this here to avoid an error";
        }

        public string TweakFront(string str)
        {
            if (str.Length == 0)
            {
                return "";
            }
            if (str.Length == 1 && str != "a")
            {
                return "";
            }
            if (str == "a")
            {
                return "a";
            }
            if (str[0] == 'a' && str[1] == 'b')
            {
                return str;
            }
            if (str[0] == 'a')
            {
                return "a" + str.Substring(2);
            }
            if (str[1] == 'b')
            {
                return "b" + str.Substring(2);
            }
            return str.Substring(2);
        }

        public string StripX(string str)
        {
            if (str[0] == 'x' && str[str.Length - 1] == 'x')
            {
                return str.Substring(1, (str.Length - 2));
            }
            if (str[0] == 'x')
            {
                return str.Substring(1);
            }
            if (str[str.Length - 1] == 'x')
            {
                return str.Substring(0, (str.Length - 1));
            }
            return str;
        }
    }
}
