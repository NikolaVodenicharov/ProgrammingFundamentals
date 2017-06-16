using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string word1 = inputs[0];
            string word2 = inputs[1];

            bool areWordsExchangeable = true;
            Dictionary<char, char> mappedCharacters = new Dictionary<char, char>();
            int continueToNextLoop = 0;
            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++, continueToNextLoop++)
            {
                char word1Char = word1[i];
                char word2Char = word2[i];

                if (!mappedCharacters.ContainsKey(word1Char))
                {
                    mappedCharacters.Add(word1Char, word2Char);
                }
                else
                {
                    if (mappedCharacters[word1Char] != word2Char)
                    {
                        areWordsExchangeable = false;
                        break;
                    }
                }
            }

            if (word2.Length > word1.Length)
            {
                for (int i = continueToNextLoop; i < word2.Length; i++)
                {
                    if (!mappedCharacters.ContainsValue(word2[i]))
                    {
                        areWordsExchangeable = false;
                        break;
                    }
                }
            }

            else if (word1.Length > word2.Length)
            {
                for (int i = continueToNextLoop; i < word1.Length; i++)
                {
                    if (!mappedCharacters.ContainsKey(word1[i]))
                    {
                        areWordsExchangeable = false;
                        break;
                    }
                }
            }


            if (areWordsExchangeable)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
