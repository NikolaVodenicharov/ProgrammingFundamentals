using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //while (nums.Length > 1)
            //{
            //    var condensed = new int[nums.Length - 1];
            //    for (int i = 0; i < nums.Length - 1; i++)
            //    {
            //        condensed[i] = nums[i] + nums[i + 1];
            //    }
            //    nums = condensed;
            //}

            for (int r = 0; r < nums.Length - 1; r++)
            {
                for (int i = 0; i < nums.Length -1; i++)
                {
                    nums[i] = nums[i] + nums[i + 1];
                }
            }

            Console.WriteLine(nums[0]);
        }
    }
}
