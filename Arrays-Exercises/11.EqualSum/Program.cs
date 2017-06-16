using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool noSuchIndex = true; //is there index such an idex ?

            for (int i = 0; i < arr.Length; i++)
            {
                int left = 0;
                int right = 0;

                for (int j = 0; j < i; j++)
                {
                    left += arr[j];
                }
                for (int k = i + 1; k < arr.Length; k++)
                {
                    right += arr[k];
                }
                if (left == right)
                {
                    Console.WriteLine(i);
                    noSuchIndex = false;
                    break; 
                }
            }
            if (noSuchIndex)
            {
                Console.WriteLine("no");
            }
        }
    }
}
