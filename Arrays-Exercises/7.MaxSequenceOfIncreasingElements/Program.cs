using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                PrintLongestIncreasingSequence(numbers);
            }

        private static void PrintLongestIncreasingSequence(int[] numbers)
        {
            int bestStart = 0;
            int bestLength = 1;
            FindLongestIncreasingSequence(numbers, ref bestStart, ref bestLength);

            int[] longestSequence = new int[bestLength];
            for (int i = 0; i < bestLength; i++)
            {
                longestSequence[i] = numbers[bestStart + i];
            }
            Console.WriteLine(string.Join(" ", longestSequence));
        }

        private static void FindLongestIncreasingSequence(int[] numbers, ref int bestStart, ref int bestLength)
        {
            int currentStart = 0;
            int currentLength = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    currentLength++;
                    if (currentLength > bestLength)
                    {
                        bestStart = currentStart;
                        bestLength = currentLength;
                    }
                }
                else
                {
                    currentStart = i;
                    currentLength = 1;
                }
            }
        }
    }
}
