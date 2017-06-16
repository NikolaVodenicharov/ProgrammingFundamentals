using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReverseArrayIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //for (int i = arr.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            arr = arr.Reverse().ToArray();                  //vtori variant na nakov
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
