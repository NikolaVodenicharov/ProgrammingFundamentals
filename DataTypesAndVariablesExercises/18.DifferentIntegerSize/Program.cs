using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18.DifferentIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {

                            //Variant 1

            //BigInteger n = BigInteger.Parse(Console.ReadLine());

            //if (n <= long.MaxValue && n >= long.MinValue)
            //{
            //    Console.WriteLine($"{n} can fit in:");
            //    if (n <= sbyte.MaxValue && n >= sbyte.MinValue)
            //    {
            //        Console.WriteLine("* sbyte");
            //    }
            //    if (n <= byte.MaxValue && n >= byte.MinValue)
            //    {
            //        Console.WriteLine("* byte");
            //    }
            //    if (n <= short.MaxValue && n >= short.MinValue)
            //    {
            //        Console.WriteLine("* short");
            //    }
            //    if (n <= ushort.MaxValue && n >= ushort.MinValue)
            //    {
            //        Console.WriteLine("* ushort");
            //    }
            //    if (n <= int.MaxValue && n >= int.MinValue)
            //    {
            //        Console.WriteLine("* int");
            //    }
            //    if (n <= uint.MaxValue && n >= uint.MinValue)
            //    {
            //        Console.WriteLine("* uint");
            //    }
            //    if (n <= long.MaxValue && n >= long.MinValue)
            //    {
            //        Console.WriteLine("* long");
            //    }
            //}         
            //else
            //{
            //    Console.WriteLine($"{n} can't fit in any type");
            //}

            
                            //Variant 2

            string input = Console.ReadLine();

            try
            {
                long maxType = long.Parse(input);
                Console.WriteLine($"{maxType} can fit in:");
                try
                {
                    sbyte currentType = sbyte.Parse(input);
                    Console.WriteLine("* sbyte");
                } catch { }
                try
                {
                    byte currentType = byte.Parse(input);
                    Console.WriteLine("* byte");
                } catch { }
                try
                {
                    short currentType = short.Parse(input);
                    Console.WriteLine("* short");
                } catch { }
                try
                {
                    ushort currentType = ushort.Parse(input);
                    Console.WriteLine("* ushort");
                } catch { }
                try
                {
                    int currentType = int.Parse(input);
                    Console.WriteLine("* int");
                } catch { }
                try
                {
                    uint currentType = uint.Parse(input);
                    Console.WriteLine("* uint");
                } catch { }
                Console.WriteLine("* long");
            }
            catch (Exception)
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
