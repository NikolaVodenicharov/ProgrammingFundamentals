using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SerbianUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> profitsStatistic = new Dictionary<string, Dictionary<string, decimal>>();

            while (true)
            {
                string[] inputInfo = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);

                if (inputInfo[0].ToLower().Equals("end")) //end inputing of information, end the loop
                {
                    break;
                }

                if (inputInfo.Length < 4 || inputInfo[0].Contains("@"))   //ignore incorect format
                {
                    continue;
                }

                StringBuilder singer = new StringBuilder();
                StringBuilder venue = new StringBuilder();
                decimal ticketsPrice = 0;
                decimal ticketsCount = 0;

                for (int i = 0; i < inputInfo.Length; i++)
                {
                    string currentString = inputInfo[i];

                    if (currentString.Contains("@"))    //add venue
                    {
                        currentString = currentString.Remove(0, 1); //remove @
                        venue.Append(currentString);

                        for (int j = i + 1; j < i + 2; j++)
                        {
                            if (!char.IsDigit(inputInfo[j][0]))
                            {
                                venue.Append(" " + inputInfo[j]);
                                i++;
                            }
                            else
                            {
                                break;
                            }
                        }                       
                    }

                    else if (char.IsDigit(currentString[0]))    //add price and count of tickets
                    {
                        decimal.TryParse(currentString, out ticketsPrice);
                        decimal.TryParse(inputInfo[i + 1], out ticketsCount);
                        break;
                    }

                    else    //add singer
                    {
                        singer.Append(currentString + " ");
                    }
                }

                string venueName = venue.ToString().Trim();
                string singerName = singer.ToString().Trim();
                decimal singerProfit = ticketsPrice * ticketsCount;

                if (!profitsStatistic.ContainsKey(venueName))
                {
                    profitsStatistic.Add(venueName, new Dictionary<string, decimal>());
                }

                if (!profitsStatistic[venueName].ContainsKey(singerName))
                {
                    profitsStatistic[venueName].Add(singerName, new decimal());
                }

                profitsStatistic[venueName][singerName] += singerProfit;
            }

            foreach (var location in profitsStatistic)
            {
                Console.WriteLine(location.Key);

                foreach (var singer in location.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
