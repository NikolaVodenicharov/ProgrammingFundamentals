using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.RefactoringSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            bool isItSpecial = false;
            for (int i = 1; i <= n; i++)
            {
                num = i;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                isItSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isItSpecial}");
                sum = 0;
            }
        }
    }
}
