using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool noSuchTriple = true;
            for (int i = 0; i < nums.Length -1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int a = nums[i];
                    int b = nums[j];
                    if (nums.Contains(a + b))
                    {
                        Console.WriteLine($"{a} + {b} == {a + b}");
                        noSuchTriple = false;
                    }
                }
            }
            if (noSuchTriple)
            {
                Console.WriteLine("No");
            }
        }
    }
}
