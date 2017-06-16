using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputInformation = Console.ReadLine();
            var splitedWords = inputInformation.Split(' ').ToArray();
            Random rnd = new Random();

            for (int first = 0; first < splitedWords.Length; first++)
            {
                var second = rnd.Next(0, splitedWords.Length);
                var old = splitedWords[first];
                splitedWords[first] = splitedWords[second];
                splitedWords[second] = old;
            }

            Console.WriteLine(string.Join("\r\n", splitedWords));


        }
    }
}
