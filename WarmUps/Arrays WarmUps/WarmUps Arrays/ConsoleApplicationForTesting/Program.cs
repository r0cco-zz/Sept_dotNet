using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationForTesting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[] {1, 2, 3, 4, 5};

            Reverse(numbers);

            Console.ReadLine();
        }

        public static void Reverse(int[] numbers)
        {
            int[] reversearray = new int[numbers.Length];
            if (numbers.Length%2 == 0)
            {
                for (int i = 0; i < numbers.Length/2; i++)
                {
                    int mirrorvalue = numbers[(numbers.Length - 1) - i];
                    reversearray[i] = mirrorvalue;
                }
                for (int i = numbers.Length/2; i < numbers.Length; i++)
                {
                    int mirrorvalue = numbers[i - (numbers.Length - 1)/2];
                    reversearray[i] = mirrorvalue;
                }
                Console.WriteLine(reversearray.ToString());
            }
            for (int i = 0; i < (numbers.Length/2); i++)
            {
                int mirrorvalue = numbers[(numbers.Length - 1) - i];
                reversearray[i] = mirrorvalue;
            }
            for (int i = numbers.Length/2; i < numbers.Length; i++)
            {
                int mirrorvalue = numbers[i - (numbers.Length - 1)/2];
                reversearray[i] = mirrorvalue;
            }
            reversearray[(numbers.Length/2) + 1] = numbers[(numbers.Length/2) + 1];
            Console.WriteLine(reversearray.ToString());
        }
    }
}
