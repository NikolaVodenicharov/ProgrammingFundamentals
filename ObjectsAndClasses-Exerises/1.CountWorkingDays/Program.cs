using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            List<DateTime> holidays = new List<DateTime>()
            {
                new DateTime (2016, 1, 1),
                new DateTime (2016, 3, 3),
                new DateTime (2016, 5, 1),
                new DateTime (2016, 5, 6),
                new DateTime (2016, 5, 24),
                new DateTime (2016, 9, 6),
                new DateTime (2016, 9, 22),
                new DateTime (2016, 11, 1),
                new DateTime (2016, 12, 24),
                new DateTime (2016, 12, 25),
                new DateTime (2016, 12, 26),
            };


            int workingDaysCounter = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                DateTime tempDate = new DateTime(2016, date.Month, date.Day);
                bool isWeekDay = date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
                bool isHoliday = holidays.Contains(tempDate);

                if (isWeekDay && !isHoliday)
                {
                    workingDaysCounter++;
                }
            }

            Console.WriteLine(workingDaysCounter);
        }
    }
}
