using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputInformation = Console.ReadLine();
            var date = DateTime.ParseExact(inputInformation, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);

            //var splitter = inputInformation.Split('-').Select(int.Parse).ToArray();
            //var splitedDate = new DateTime(splitter[2], splitter[1], splitter[0]);
            //Console.WriteLine(splitedDate.DayOfWeek);




            //var peterBirthday = new DateTime(1996, 11, 27);
            //var mariaBirthday = new DateTime(1995, 6, 14);

            //Console.WriteLine("Peter's birth date: {0:dd-MM-yyyy}", mariaBirthday);

            //var mariaAfter18Motnt = mariaBirthday.AddMonths(18);

            //Console.WriteLine("Peter's birth date: {0:dd-MM-yyyy}", mariaAfter18Motnt);

            //TimeSpan ageDiff = peterBirthday.Subtract(mariaBirthday);
            //Console.WriteLine(ageDiff);
        }
    }
}
