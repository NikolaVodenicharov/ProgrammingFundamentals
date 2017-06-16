using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ReverseArrayStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(' ').ToArray();

            var reversedItems = items.Reverse();                        //ne e array

            //string[] reversedItemsArray = items.Reverse().ToArray();    // array

            //var result = new string[items.Length];                      // treti variant
            //for (int i = 0; i < items.Length; i++)
            //{
            //    result[items.Length - i - 1] = items[i];
            //}



            Console.WriteLine(string.Join(" ", reversedItems));

        }
    }
}
