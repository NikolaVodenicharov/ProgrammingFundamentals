using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numA = decimal.Parse(Console.ReadLine());
            decimal numB = decimal.Parse(Console.ReadLine());
            decimal eps = 0.000001m;

            bool areEqual = Math.Abs(numA - numB) < eps;

            Console.WriteLine(areEqual);
        }
    }
}
