﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float metersPerSecond = distance / (hours * 3600 + minutes * 60 + seconds);
            Console.WriteLine("{0}", metersPerSecond);

            float kilometersPerHour = (distance / 1000) / (hours + minutes / 60 + seconds / 3600);
            Console.WriteLine("{0}", kilometersPerHour);

            float milesPerHour = (distance / 1609) / (hours + minutes / 60 + seconds / 3600);
            Console.WriteLine("{0}", milesPerHour);
        }
    }
}
