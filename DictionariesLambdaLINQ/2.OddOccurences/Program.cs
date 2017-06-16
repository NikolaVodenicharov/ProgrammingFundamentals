using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(' ');
            var dict = new Dictionary<string, int>();

            //words.Where(x => words.Where(y => y == x).Count() % 2 == 1);

            foreach (var item in words)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }

            var list = new List<string>();
            foreach (var pair in dict)
            {
                if (pair.Value % 2 == 1)
                {
                    list.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
