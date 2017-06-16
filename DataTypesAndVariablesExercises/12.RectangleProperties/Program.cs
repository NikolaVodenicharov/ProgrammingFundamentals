using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = Convert.ToDouble(Console.ReadLine());
            double heigth = Convert.ToDouble(Console.ReadLine());
            double perimeter = width * 2 + heigth * 2;
            double area = width * heigth;
            double diagonal = Math.Sqrt(width * width + heigth * heigth);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
