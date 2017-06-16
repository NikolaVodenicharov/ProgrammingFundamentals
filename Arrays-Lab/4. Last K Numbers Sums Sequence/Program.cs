using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            decimal[] sequence = new decimal[n];
            sequence[0] = 1;

            for (int i = 1; i < n; i++)
            {
                    sequence[i] = SumNums(sequence, i - k, i-1); 
            }
            Console.WriteLine("Sequence:");
            Console.WriteLine(String.Join(" ", sequence));
        }

        private static decimal SumNums(decimal[] sequence, int startIndex, int endIndex)
        {
            decimal sum = 0; 
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (i >= 0) 
                {
                    sum += sequence[i];
                }
            } 
            return sum;
        }
    }
}
