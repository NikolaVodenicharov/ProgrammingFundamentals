using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MasSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            CalculateLongestSequence(numbers);
        }

        private static void CalculateLongestSequence(int[] numbers)
        {
            int bestStart, bestLength;
            FindLongestSequence(numbers, out bestStart, out bestLength);

            int[] longestSequence = new int[bestLength];

            for (int i = 0; i < bestLength; i++)
            {
                longestSequence[i] = numbers[bestStart + i];
            }
            Console.WriteLine(string.Join(" ", longestSequence));
        }

        private static void FindLongestSequence(int[] numbers, out int bestStart, out int bestLength)
        {
            bestStart = 0;
            bestLength = 1;
            int currentStart = 0;
            int currentLength = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
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
