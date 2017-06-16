using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeCheckerRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool isItPrime = true;
                for (int devisor = 2; devisor <= Math.Sqrt(i); devisor++)
                {
                    if (i % devisor == 0)
                    {
                        isItPrime = false;
                        break;  
                    }
                }
                Console.WriteLine($"{i} -> {isItPrime}");
            }

        }
    }
}
