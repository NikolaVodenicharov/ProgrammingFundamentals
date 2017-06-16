using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separator = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ', };

            var words = Console.ReadLine().ToLower().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var smallWords = new List<string>();
            foreach (var w in words)
            {
                if (w.Length < 5)
                {
                    smallWords.Add(w);
                }
            }
            var result = smallWords.OrderBy(x => x).Distinct();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
