using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var peoplesEmails = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();
                if (name.ToLower().Equals("stop"))
                {
                    break;
                }

                string email = Console.ReadLine();
                if (!email.Split('.').Last().Equals("us") && !email.Split('.').Last().Equals("uk"))
                {
                    peoplesEmails[name] = email;
                }
            }

            foreach (var pair in peoplesEmails)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}

//string domain = email.Substring(email.Length - 2).ToLower();
