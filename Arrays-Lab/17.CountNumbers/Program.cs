using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            numbers.Sort();
            //var count = 1;
            //bool groupFinish = false;

            //if (numbers.Count == 1)
            //{
            //    Console.WriteLine($"{numbers[0]} -> {count}");
            //}

            //for (int position = 0; position < numbers.Count - 1; position++)
            //{

            //    if (numbers[position] == numbers[position+1])
            //    {
            //        count++;
            //        if (position == numbers.Count - 2)
            //        {
            //            groupFinish = true;
            //        }
            //    }
            //    else 
            //    {
            //        groupFinish = true;
            //    }

            //    if (groupFinish)
            //    {
            //        Console.WriteLine($"{numbers[position]} -> {count}");
            //        count = 1;
            //        groupFinish = false;
            //    }

            //    if ((position == numbers.Count - 2) && (numbers[position] != numbers[position + 1]))
            //    {
            //        Console.WriteLine($"{numbers[position + 1]} -> {1}");
            //    }
            //}

            var position = 0;

            while (position < numbers.Count)
            {
                int num = (int)numbers[position];
                int len = 1;
                while ((numbers.Count > position + len) && (num == numbers[position + len]))
                {
                    len++;
                }
                position = position + len;
                Console.WriteLine($"{num} -> {len}");
            }
        }
    }
}
