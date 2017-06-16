using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsOfDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int numberOfPairs = CalculatingNumberOfPairs(nums, difference);
            Console.WriteLine(numberOfPairs);
        }

        private static int CalculatingNumberOfPairs(int[] nums, int difference)
        {
            int numberOfPairs = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == difference)
                    {
                        numberOfPairs++;
                    }
                }
            }

            return numberOfPairs;
        }
    }
}
