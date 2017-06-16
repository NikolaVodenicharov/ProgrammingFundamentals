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
            var phonebookDictionary = new Dictionary<string, string>();

            while (! inputInformation.Equals("END"))
            {
                var splitedInputInformation = inputInformation.Split(' ').ToList();
                string contact = splitedInputInformation[1];

                if (splitedInputInformation[0].Equals("A"))
                {
                    string number = splitedInputInformation[2];

                    phonebookDictionary.Add(contact, number);   //ako ne su6testvuva kontakta (Key) 6te go dobavi, no ako su6testvyva 6te dade gre6ka
                    phonebookDictionary[contact] = number;      //ako kontakta su6testvuva go zamenq
                }
                else if (splitedInputInformation[0].Equals("S"))
                {
                    if (phonebookDictionary.ContainsKey(contact))
                    {
                        Console.WriteLine($"{contact} -> {phonebookDictionary[contact]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {contact} does not exist.");
                    }
                }
                else if (splitedInputInformation[0].Equals("ListAll"))
                {
                    phonebookDictionary.OrderBy(x => x.Key);
                }
                inputInformation = Console.ReadLine();
            }
            Console.WriteLine();
        }
    }
}
