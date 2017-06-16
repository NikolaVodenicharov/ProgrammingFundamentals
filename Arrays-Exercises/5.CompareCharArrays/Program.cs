using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int shorterArr = Math.Min(arr1.Length, arr2.Length);
            bool areArraysEqual = true;

            for (int i = 0; i < shorterArr; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    continue;
                }
                else
                {
                    if (arr1[i] < arr2[i])
                    {
                        Console.WriteLine(arr1);
                        Console.WriteLine(arr2);
                    }
                    else
                    {
                        Console.WriteLine(arr2);
                        Console.WriteLine(arr1);
                    }
                    areArraysEqual = false;
                    break;
                } 
            }

            if (areArraysEqual)
            {
                if (arr1.Length > arr2.Length)
                {
                    Console.WriteLine(arr2);
                    Console.WriteLine(arr1);
                }
                else
                {
                    Console.WriteLine(arr1);
                    Console.WriteLine(arr2);
                }
            }
        }
    }
}
