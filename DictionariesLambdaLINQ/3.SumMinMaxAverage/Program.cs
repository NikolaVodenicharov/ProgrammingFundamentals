﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum = {0}", numbers.Sum());
            Console.WriteLine("Min = {0}", numbers.Min());
            Console.WriteLine("Max = {0}", numbers.Max());
            Console.WriteLine("Average = {0}", numbers.Average());
        }
    }
}

