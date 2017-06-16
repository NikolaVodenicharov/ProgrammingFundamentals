using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Point
{
    public double X { get; set; }

    public double Y { get; set; }

    public string Name { get; set; }

    public bool IsOnTheLeftFrom(Point p2)
    {
        var onTheLeft = this.X < p2.X;
        return onTheLeft;
    }

    public static double CalcDistance(Point p1, Point p2)
    {
        var a = p1.X - p2.X;
        var b = p1.Y - p2.Y;
        var distance = Math.Sqrt(a * a + b * b);
        return distance;
    }

    public static Point ReadPoint()
    {
        var coords = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var p = new Point() { X = coords[0], Y = coords[1] };
        return p;
    }

    public override string ToString()
    {
        return String.Format("({0}, {1})", this.X, this.Y);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var p1 = Point.ReadPoint();
        var p2 = Point.ReadPoint();

        //Point p1 = new Point();
        //p1.X = 5;
        //p1.Y = -2.7;
        //p1.Name = "A";
        //Point p2 = new Point() { X=2, Y=4, Name="B" };
        Console.WriteLine(p1);
        Console.WriteLine("({0}, {1})", p1.X, p1.Y);
        Console.WriteLine("{0:f3}", Point.CalcDistance(p1, p2));
    }
}