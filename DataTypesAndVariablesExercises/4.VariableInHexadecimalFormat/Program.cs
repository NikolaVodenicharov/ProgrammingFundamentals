using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexVariable = Console.ReadLine();
            int hexConverted = Convert.ToInt32(hexVariable, 16);
            Console.WriteLine(hexConverted);
        }
    }
}
