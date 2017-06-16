using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExtractMiddleElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = ExtractMiddleElements(nums);
            Console.WriteLine("{ " + string.Join(", ", result) + " }" );
        }

        private static int[] ExtractMiddleElements(int[] n)
        {
            if (n.Length <= 2)
            {
                return n;
            }
            else if (n.Length % 2 == 0)
            {
                return new int[] { n[n.Length / 2 - 1], n[n.Length / 2] }; 
            }
            else //for odd
            {
                return new int[] { n[n.Length / 2 - 1], n[n.Length / 2], n[n.Length/2 +1] };
            }
        }
    }
}
