using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BooleanVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool converted = Convert.ToBoolean(text);
            if (converted)
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
