using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separator = new char[] { ' ', ':', ',', '.', ';', '!', '"', '\'', '(', ')', '[', ']', '\\', '/' };

            List<string> inputText = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();

            foreach (var word in inputText)
            {
                var lowerCaseCharts = 0;
                var upperCaseCharts = 0;
                foreach (char letter in word)
                {
                    if (char.IsLower(letter))
                    {
                        lowerCaseCharts++;
                    }
                    else if (char.IsUpper(letter))
                    {
                        upperCaseCharts++;
                    }
                }
                if (lowerCaseCharts == word.Length)
                {
                    lowerCaseWords.Add(word);
                }
                else if (upperCaseCharts == word.Length)
                {
                    upperCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCaseWords));
        }
    }
}
