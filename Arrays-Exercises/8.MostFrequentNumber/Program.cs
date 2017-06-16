using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            PrintAnswer(numbers);
        }

        private static void PrintAnswer(int[] numbers)
        {
            int position = 0;
            position = CountingFrequency(numbers, position);
            Console.WriteLine(numbers[position]);
        }

        private static int CountingFrequency(int[] numbers, int position)
        {
            int frequency = 0;
            int currentFrequency = 1;

            for (int currentPosition = 0; currentPosition < numbers.Length - 1; currentPosition++)
            {
                for (int chekingPosition = currentPosition + 1; chekingPosition < numbers.Length; chekingPosition++)
                {
                    if (numbers[currentPosition] == numbers[chekingPosition])
                    {
                        currentFrequency++;
                    }
                    if (currentFrequency > frequency)
                    {
                        position = currentPosition;
                        frequency = currentFrequency;
                    }
                }
                currentFrequency = 1;
            }
            return position;
        }
    }
}
