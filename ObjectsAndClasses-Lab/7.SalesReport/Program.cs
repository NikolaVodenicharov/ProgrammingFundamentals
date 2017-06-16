using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SalesReport
{   
    class Sale
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public static Sale ReadSale()
        {
            var input = Console.ReadLine().Split(' ');
            var town = input[0];
            var product = input[1];
            var price = decimal.Parse(input[2]);
            var quantity = decimal.Parse(input[3]);
            var sale = new Sale() { Town = town, Price = price, Product = product, Quantity = quantity };
            return sale;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sales = new List<Sale>();
            for (int i = 0; i < n; i++)
            {
                var sale = Sale.ReadSale();
                sales.Add(sale);
            }

            var towns = sales.Select(s => s.Town).Distinct().OrderBy(t => t).ToList();
            
            foreach (var t in towns)
            {
                var salesForT = sales.Where(s => s.Town == t).Sum(s => s.Price * s.Quantity);
                Console.WriteLine("{0} -> {1:f2}", t, salesForT);
            }
        }
    }
}
