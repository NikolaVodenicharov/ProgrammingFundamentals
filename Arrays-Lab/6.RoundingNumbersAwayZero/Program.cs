using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.RoundingNumbersAwayZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (var num in nums)
            {
                var rounded = Math.Round(num, MidpointRounding.AwayFromZero);
                Console.WriteLine(num + " => " + rounded);
            }
        }
    }
}
