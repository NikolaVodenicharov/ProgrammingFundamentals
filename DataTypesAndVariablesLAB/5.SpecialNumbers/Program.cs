using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isItSpecial;
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int num = i;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isItSpecial = true;
                }
                else
                {
                    isItSpecial = false;
                }
                Console.WriteLine($"{i} -> {isItSpecial}");
            }
        }
    }
}
