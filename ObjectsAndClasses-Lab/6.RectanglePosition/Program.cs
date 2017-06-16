using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle1 = Rectangle.ReadRectangle();
            var rectangle2 = Rectangle.ReadRectangle();

            Console.WriteLine(Rectangle.IsRect1InsindRect2(rectangle1, rectangle2) ? "Inside" : "Not inside");
        }
    }

    class Rectangle
    {
        public double Left { get; set; }

        public double Top { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Right
        {
            get
            {
                return this.Left + this.Width;
            }
        }

        public double Bottom
        {
            get
            {
                return this.Top + this.Height;
            }
            
        }

        public static Rectangle ReadRectangle()
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var rectnagle = new Rectangle()
            {
                Left = input[0],
                Top = input[1],
                Width = input[2],
                Height = input[3]
            };
            return rectnagle;
        }

        public override string ToString()
        {
            return String.Format( $"Rect[Left={Left}, Top={Top}, Right={Right}, Bottom={Bottom}]");
        }

        public static bool IsRect1InsindRect2(Rectangle rectangle1, Rectangle rectangle2)
        {
            var inside = rectangle1.Left >= rectangle2.Left &&
                         rectangle1.Right <= rectangle2.Right &&
                         rectangle1.Top >= rectangle2.Top &&
                         rectangle1.Bottom <= rectangle2.Bottom;
            return inside;
        }
    }
}
