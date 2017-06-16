using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputPoints = Point.ReadArrayOfPoints();
            var nearestPoints = Point.FindNearestPoints(inputPoints);

            Console.WriteLine($"{Point.CalcDistance(nearestPoints[0], nearestPoints[1]):f3}");
            Console.WriteLine(nearestPoints[0]);
            Console.WriteLine(nearestPoints[1]);
        }
    }

    class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public static double CalcDistance (Point p1, Point p2)
        {
            var a = p1.X - p2.X;
            var b = p1.Y - p2.Y;
            var distance = Math.Sqrt(a * a + b * b);
            return distance;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", this.X, this.Y);
        }

        public static Point ReadPoint()
        {
            var coordinate = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var p = new Point() { X = coordinate[0], Y = coordinate[1] };
            return p;
        }

        public static Point[] ReadArrayOfPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] inputPoints = new Point[n];
            for (int i = 0; i < n; i++)
            {
                inputPoints[i] = Point.ReadPoint();
            }
            return inputPoints;
        }

        public static Point[] FindNearestPoints(Point[] points)
        {
            var nearestDistance = double.MaxValue;
            Point[] nearestPoints = null;
            for (int first = 0; first < points.Length; first++)
            {
                for (int second = first + 1; second < points.Length; second++)
                {
                    var p1 = points[first];
                    var p2 = points[second];
                    var currentDistance = Point.CalcDistance(p1, p2);
                    if (currentDistance < nearestDistance)
                    {
                        nearestDistance = currentDistance;
                        nearestPoints = new Point[] { p1, p2 };
                    }
                }
            }
            return nearestPoints;
        }
    }
}
