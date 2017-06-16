using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());

            int[] sum = new int[nums.Length];

            for (int r = 1; r <= numberOfRotations; r++)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    sum[(i + r) % nums.Length] += nums[i];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
