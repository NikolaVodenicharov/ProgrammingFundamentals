using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chaArray = Console.ReadLine().ToArray();
            char[] libraryChars = LibraryCharsConstructor();

            for (int i = 0; i < chaArray.Length; i++)
            {
                for (int j = 0; j < libraryChars.Length; j++)
                {
                    if (chaArray[i] == libraryChars[j])
                    {
                        Console.WriteLine(chaArray[i] + " -> " + j);
                    }
                }
            }
        }

        private static char[] LibraryCharsConstructor()
        {
            char[] libraryChars = new char[26];

            int position = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                libraryChars[position] = i;
                position++;
            }

            return libraryChars;
        }
    }
}
