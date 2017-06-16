using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.AndreyAndBilliard
{
    class Customer
    {
        public Customer()
        {
            this.Orders = new Dictionary<string, int>();
        }

        public string CustomerName { get; set; }
        public Dictionary<string, int> Orders { get; set; }
        public decimal Bill { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> offeredProducts = new Dictionary<string, decimal>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputProducts = Console.ReadLine().Split('-');
                string productName = inputProducts[0];
                decimal productPrice = decimal.Parse(inputProducts[1]);
                if (!offeredProducts.ContainsKey(productName))
                {
                    offeredProducts.Add(productName, productPrice);
                }
                else
                {
                    offeredProducts[productName] = productPrice;
                }
            }

            List<Customer> customers = new List<Customer>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("end of clients"))
                {
                    break;
                }

                string[] inputCustomerOrders = input.Split(new char[] { '-', ','}, StringSplitOptions.RemoveEmptyEntries);
                string customerName = inputCustomerOrders[0];
                string productName = inputCustomerOrders[1];
                int productQuantity = int.Parse(inputCustomerOrders[2]);

                if (!offeredProducts.ContainsKey(productName))
                {
                    continue;
                }

                if (customers.Any(x => x.CustomerName == customerName))
                {
                    Customer existingCustomer = customers.First( x => x.CustomerName == customerName);
                    if (!existingCustomer.Orders.ContainsKey(productName))
                    {
                        existingCustomer.Orders.Add(productName, productQuantity);
                    }
                    else
                    {
                        existingCustomer.Orders[productName] += productQuantity;
                    }
                    existingCustomer.Bill += offeredProducts[productName] * productQuantity;
                }
                else
                {
                    Customer newCustomer = new Customer();
                    newCustomer.CustomerName = customerName;
                    newCustomer.Orders.Add(productName, productQuantity);
                    newCustomer.Bill = offeredProducts[productName] * productQuantity;
                    customers.Add(newCustomer);
                }
            }

            foreach (var customer in customers.OrderBy(x => x.CustomerName))
            {
                Console.WriteLine(customer.CustomerName);

                foreach (var product in customer.Orders)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }

                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }
            Console.WriteLine("Total bill: {0}", customers.Sum(b => b.Bill));
        }
    }
}
