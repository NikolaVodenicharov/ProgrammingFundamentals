using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.HandOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> personDict = new Dictionary<string, List<string>>();

            while (true)
            {
                string inputInformation = Console.ReadLine();
                if (inputInformation.Equals("JOKER"))
                {
                    break;
                }

                List<string> splitForNameAndCards = inputInformation.Split(':').ToList();
                string personName = splitForNameAndCards[0];
                List<string> personCards = splitForNameAndCards[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!personDict.Keys.Contains(personName))
                {
                    personDict.Add(personName, new List<string>());
                }
                personDict[personName].AddRange(personCards);
            }

            foreach (var pair in personDict)
            {
                List<string> distinctedPersonDict = pair.Value.Distinct().ToList();
                int sum = 0;
                foreach (var card in distinctedPersonDict)
                {
                    string cardPower = card.Substring(0, card.Length - 1);
                    int cardPowerPoints = 0;

                    if (cardPower.Equals("2")) cardPowerPoints = 2;
                    else if (cardPower.Equals("3")) cardPowerPoints = 3;
                    else if (cardPower.Equals("4")) cardPowerPoints = 4;
                    else if (cardPower.Equals("5")) cardPowerPoints = 5;
                    else if (cardPower.Equals("6")) cardPowerPoints = 6;
                    else if (cardPower.Equals("7")) cardPowerPoints = 7;
                    else if (cardPower.Equals("8")) cardPowerPoints = 8;
                    else if (cardPower.Equals("9")) cardPowerPoints = 9;
                    else if (cardPower.Equals("10")) cardPowerPoints = 10;
                    else if (cardPower.Equals("J")) cardPowerPoints = 11;
                    else if (cardPower.Equals("Q")) cardPowerPoints = 12;
                    else if (cardPower.Equals("K")) cardPowerPoints = 13;
                    else if (cardPower.Equals("A")) cardPowerPoints = 14;

                    string cardType = card.Substring(card.Length - 1);
                    int cardTypePoints = 0;

                    if (cardType.Equals("S")) cardTypePoints = 4;
                    else if (cardType.Equals("H")) cardTypePoints = 3;
                    else if (cardType.Equals("D")) cardTypePoints = 2;
                    else if (cardType.Equals("C")) cardTypePoints = 1;

                    int cardPoints = cardPowerPoints * cardTypePoints;
                    sum += cardPoints;
                }
                Console.WriteLine($"{pair.Key}: {sum}");
            }
        }
    }
}
