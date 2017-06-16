using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputInformation = Console.ReadLine();
            var phonebook = new SortedDictionary<string, string>();

            while (!inputInformation.Equals("END"))
            {
                var splitedInputInformation = inputInformation.Split(' ').ToList();

                if (splitedInputInformation[0].Equals("A"))
                {
                    AddToPhonebook(phonebook, splitedInputInformation);
                }
                else if (splitedInputInformation[0].Equals("S"))
                {
                    PrintFromPhonebook(phonebook, splitedInputInformation);
                }
                else if (splitedInputInformation[0].Equals("ListAll"))
                {
                    PrintAllFromPhonebook(phonebook);
                }

                inputInformation = Console.ReadLine();
            }
            Console.WriteLine();
        }

        private static void PrintAllFromPhonebook(SortedDictionary<string, string> phonebook)
        {
            foreach (var p in phonebook.Keys)
            {
                Console.WriteLine($"{p} -> {phonebook[p]}");
            }
        }

        private static void PrintFromPhonebook(SortedDictionary<string, string> phonebook, List<string> splitedInputInformation)
        {
            string contact = splitedInputInformation[1];
            if (phonebook.ContainsKey(contact))
            {
                Console.WriteLine($"{contact} -> {phonebook[contact]}");
            }
            else
            {
                Console.WriteLine($"Contact {contact} does not exist.");
            }
        }

        private static void AddToPhonebook(SortedDictionary<string, string> phonebookDictionary, List<string> splitedInputInformation)
        {
            string contact = splitedInputInformation[1];
            string number = splitedInputInformation[2];
            phonebookDictionary[contact] = number;
        }
    }
}
