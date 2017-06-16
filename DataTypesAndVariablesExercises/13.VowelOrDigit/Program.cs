using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (char.IsDigit(input))
            {
                Console.WriteLine("digit");
            }
            else if (char.IsLetter(input))
            {
                string vowel = "aeioyu";
                if (vowel.Contains(input))
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                Console.WriteLine("other");
                }
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
