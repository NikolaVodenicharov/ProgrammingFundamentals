using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var userLogs = new SortedDictionary<string, List<string>>();

            while (true)
            {
                var inputInformation = Console.ReadLine();
                if (inputInformation.Equals("end"))
                {
                    break;
                }

                List<string> splitter = inputInformation.Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string userName = splitter[5];

                if (! userLogs.ContainsKey(userName))
                {
                    userLogs.Add(userName, new List<string>());
                }
                userLogs[userName].Add(splitter[1]);
            }

            foreach (var pair in userLogs)
            {
                var ipCount = new Dictionary<string, int>();
                foreach (var p in pair.Value)
                {
                    if (!ipCount.ContainsKey(p))
                    {
                        ipCount.Add(p, new int());
                    }
                    ipCount[p]++;
                }

                Console.WriteLine($"{pair.Key}:");
                int count = 0;
                foreach (var ip in ipCount)
                {
                    count++;
                    if (count.Equals(ipCount.Count))
                    {
                        Console.Write($"{ip.Key} => {ip.Value}.");
                    }
                    else
                    {
                        Console.Write($"{ip.Key} => {ip.Value}, ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
