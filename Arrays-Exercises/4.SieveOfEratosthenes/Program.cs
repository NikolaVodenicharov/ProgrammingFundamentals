﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            FindPrimes(n);
        }

        private static void FindPrimes(int n)
        {
            bool[] primes = new bool[n+1];

            for (int i = 2; i <= n; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i <= n; i++)
            {
                if (!primes[i])
                {
                    continue;
                }
                Console.Write($"{i} ");
                for (int j = i + i; j <= n ; j +=i)
                {
                    primes[j] = false;
                }
            } 
        }
    }
}
