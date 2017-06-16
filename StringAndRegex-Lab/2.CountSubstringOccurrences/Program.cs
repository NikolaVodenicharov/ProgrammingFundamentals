using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            string inputSearchingSubstring = Console.ReadLine().ToLower();

            int counter = -1;
            int index = -1;

            do
            {
                counter += 1;
                index = inputText.IndexOf(inputSearchingSubstring, index + 1);
            } while (!index.Equals(-1));

            Console.WriteLine(counter);
        }
    }
}
