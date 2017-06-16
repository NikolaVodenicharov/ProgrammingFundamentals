using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            var counts = new SortedDictionary<double, int>();

            foreach (var n in numbers)
            {
                double parsedNumbers = double.Parse(n);
                if (counts.ContainsKey(parsedNumbers))
                {
                    counts[parsedNumbers]++;
                }
                else
                {
                    counts[parsedNumbers] = 1;
                }
            }

            foreach (var n in counts.Keys)
            {
                Console.WriteLine($"{n} -> {counts[n]}");
            }
        }
    }
}
