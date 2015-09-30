using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WarmUps_Arrays
{
    public class WarmUpsArrays
    {

        public bool FirstLast6(int[] numbers)
        {
            if (numbers[0] == 6 || numbers[numbers.Length - 1] == 6)
            {
                return true;
            }
            return false;
        }

        public bool SameFirstLast(int[] numbers)
        {
            if (numbers.Length > 1 && numbers[0] == numbers[numbers.Length - 1])
            {
                return true;
            }
            return false;
        }

        public int[] MakePi(int n)
        {
            int[] piarray = new int[n];
            piarray[0] = 3;
            for (int i = 1; i < n; i++)
            {
                double roundpi = Math.Round(Math.PI, n);
                string stringpi = roundpi.ToString().Substring(i+1,1);
                piarray[i] = int.Parse(stringpi);
            }
            
            return piarray;
        }

        public bool commonEnd(int[] a, int[] b)
        {
            if (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1])
            {
                return true;
            }
            return false;
        }

        public int Sum(int[] numbers)
        {
            int endsum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                endsum += numbers[i];
            }
            return endsum;
        }

        public int[] RotateLeft(int[] numbers)
        {
            int[] numbers2 = new int[numbers.Length];
            int valuenumbers;
            int firstIndexofNumbers = numbers[0];
            numbers2[numbers.Length - 1] = firstIndexofNumbers;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                valuenumbers = numbers[i + 1];
                numbers2[i] = valuenumbers;
            }
            return numbers2;
        }

        public int[] Reverse(int[] numbers)
        {
            Array.Reverse(numbers);
            return numbers;
        }

        public int[] HigherWins(int[] numbers)
        {
            int[] newarray = new int[numbers.Length];
            if (numbers[0] > numbers[numbers.Length - 1])
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    newarray[i] = numbers[0];
                }
                return newarray;
            }
            if (numbers[0] < numbers[numbers.Length - 1])
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    newarray[i] = numbers[numbers.Length - 1];
                }
                return newarray;
            }
            return numbers;
        }

        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] newarray = new int[2];
            newarray[0] = a[1];
            newarray[1] = b[1];

            return newarray;
        }

        public bool HasEven(int[] numbers)
        {
            foreach (int numbersvalue in numbers)
            {
                if (numbersvalue%2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public int[] KeepLast(int[] numbers)
        {
            int[] newarray = new int[numbers.Length*2];
            newarray[newarray.Length - 1] = numbers[numbers.Length - 1];

            return newarray;
        }

        public bool Double23(int[] numbers)
        {
            int numberof2s = 0;
            int numberof3s = 0;
            foreach (int numbersvalue in numbers)
            {
                if (numbersvalue == 2)
                {
                    numberof2s++;
                }
                if (numbersvalue == 3)
                {
                    numberof3s++;
                }
            }
            if (numberof2s == 2 || numberof3s == 2)
            {
                return true;
            }
            return false;
        }

        public int[] Fix23(int[] numbers)
        {
            int[] newarray = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                newarray[i] = numbers[i];
                if (numbers[i] == 3 && numbers[i] != numbers[0])
                {
                    if (numbers[i - 1] == 2)
                    {
                        newarray[i] = 0;
                    }
                }
            }
            return newarray;
        }

        public bool Unlucky1(int[] numbers)
        {
            if (numbers.Length < 2)
            {
                return false;
            }
            if ((numbers[0] == 1 && numbers[1] == 3) ||
                numbers[1] == 1 && numbers[2] == 3)
            {
                return true;
            }
            if ((numbers[numbers.Length - 2] == 1 && numbers[numbers.Length - 1] == 3) ||
                (numbers[numbers.Length - 3] == 1 && numbers[numbers.Length - 2] == 3))
            {
                return true;
            }
            return false;
        }

        public int[] Make2(int[] a, int[] b)
        {
            int[] newarray = new int[2];
            if (a.Length == 0)
            {
                newarray[0] = b[0];
                newarray[1] = b[1];
                return newarray;
            }
            if (a.Length == 1)
            {
                newarray[0] = a[0];
                newarray[1] = b[0];
                return newarray;
            }
            if (a.Length >= 2)
            {
                newarray[0] = a[0];
                newarray[1] = a[1];
                return newarray;
            }
            return newarray;
        }
    }
}
