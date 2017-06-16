using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.IntersectionsOfCIrcles
{
    class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public static double CalculateDistance(Point p1, Point p2)
        {
            double sideA = p1.X - p2.X;
            double sideB = p1.Y - p2.Y;
            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);
            return distance;
        }
    }

    class Circle
    {
        public Point Center { get; set; }

        public int Radius { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point p1 = new Point()
            {
                X = input1[0],
                Y = input1[1]
            };
            Circle circle1 = new Circle()
            {
                Center = p1,
                Radius = input1[2]
            };

            Point p2 = new Point()
            {
                X = input2[0],
                Y = input2[1]
            };
            Circle circle2 = new Circle()
            {
                Center = p2,
                Radius = input2[2]
            };

            double distance = Point.CalculateDistance(p1, p2);

            if (distance <= (circle1.Radius + circle2.Radius))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
