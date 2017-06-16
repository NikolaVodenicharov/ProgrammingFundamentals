using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = numbers.Length / 4;
            var topRowLeftPart = numbers.Take(k).Reverse();
            var topRowRightPart = numbers.Reverse().Take(k);
            var topRow = topRowLeftPart.Concat(topRowRightPart).ToList();
            //List<int> topRow = numbers.Take(k).Reverse().ToList();
            //topRow.AddRange(numbers.Reverse().Take(k));
            List<int> bottomRow = numbers.Skip(k).Take(k*2).ToList();

            var sum = topRow.Select((x, index) => x + bottomRow[index]);
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
