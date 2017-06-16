using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = Console.ReadLine().Split('|').ToList();
            //list.Reverse();

            //var result = new List<string>();

            //foreach (var item in list)
            //{
            //    List<string> nums = item.Split( ' ' ).ToList();
            //    foreach (var num in nums)
            //    {
            //        if (num != "")
            //        {
            //            result.Add(num);
            //        }
            //    }
            //}
            //Console.WriteLine(String.Join(" ", result));


            var list = Console.ReadLine().Split('|').ToList();
            list.Reverse();

            var result = new List<string>();

            foreach (var item in list)
            {
                    List<string> nums = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    result.AddRange(nums);
            }
            Console.WriteLine(String.Join(" ", result));

        }
    }
}
