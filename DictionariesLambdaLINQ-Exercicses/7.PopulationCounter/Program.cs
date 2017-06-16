using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class User_Logs
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, long>> populationStatistic = new Dictionary<string, Dictionary<string, long>>();

        while (true)
        {
            string[] inputs = Console.ReadLine().Split('|').ToArray();

            if (inputs[0] == "report")
            {
                break;
            }

            string cityName = inputs[0];
            string countryName = inputs[1];
            long cityPopulation = long.Parse(inputs[2]);

            if (!populationStatistic.Keys.Contains(countryName))
            {
                populationStatistic.Add(countryName, new Dictionary<string, long>());
            }
            populationStatistic[countryName].Add(cityName, cityPopulation);
        }

        foreach (var pair in populationStatistic.OrderByDescending(x => x.Value.Sum(y => y.Value)))
        {
            List<long> sumOfCityPopulation = pair.Value.Select(x => x.Value).ToList();
            Console.WriteLine($"{pair.Key} (total population: {sumOfCityPopulation.Sum()})");
            Console.Write($"=>{string.Join("=>", pair.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
        }
    }
}