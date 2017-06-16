using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> users = new SortedDictionary<string, SortedDictionary<string, int>>();

            int numberOfInputRows = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputRows; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ').ToArray();
                string ipAdress = inputs[0];
                string userName = inputs[1];
                int durationOfSession = int.Parse(inputs[2]);

                if (!users.Keys.Contains(userName))
                {
                    users.Add(userName, new SortedDictionary<string, int>());
                }

                if (!users[userName].ContainsKey(ipAdress))
                {
                    users[userName].Add(ipAdress, new int());
                }

                users[userName][ipAdress] += durationOfSession;
            }

            foreach (var pair in users)
            {
                int totalDuration = pair.Value.Select(x => x.Value).Sum();

                Console.WriteLine($"{pair.Key}: {totalDuration} [{string.Join(", ", pair.Value.Keys)}]");
            }
        }
    }
}
