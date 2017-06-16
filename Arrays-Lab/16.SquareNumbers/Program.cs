using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> squareNumbers = new List<int>();
            foreach (var num in numList)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squareNumbers.Add(num);
                }
            }

            squareNumbers.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
