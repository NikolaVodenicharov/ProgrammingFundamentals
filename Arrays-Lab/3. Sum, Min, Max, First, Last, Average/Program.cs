using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum__Min__Max__First__Last__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum = " + nums.Sum());
            Console.WriteLine("Min = " + nums.Min());
            Console.WriteLine("Max = " + nums.Min());
            Console.WriteLine("First = " + nums.First());
            Console.WriteLine("Last = " + nums.Last());
            Console.WriteLine("Avarage = " + nums.Average());

            //nums.Skip(1).First();    //za vtori element
        }
    }
}
