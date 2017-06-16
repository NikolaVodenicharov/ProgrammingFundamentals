using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');
            int smallerArr = Math.Min(arr1.Length, arr2.Length);

            int left = LeftToRight(arr1, arr2, smallerArr);
            int right = RightToLeft(arr1, arr2, smallerArr);

            Console.WriteLine(Math.Max(left, right));
        }


        private static int RightToLeft(string[] arr1, string[] arr2, int smallerArr)
        {
            Array.Reverse(arr1);
            Array.Reverse(arr2);
            int right = 0;
            for (int i = 0; i < smallerArr; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    right++;
                }
                else
                {
                    break;
                }
            }
            return right;
        }

        private static int LeftToRight(string[] arr1, string[] arr2, int smallerArr)
        {
            int left = 0;

            for (int i = 0; i < smallerArr; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    left++;
                }
                else
                {
                    break;
                }
            }
            return left;
        }
    }
}
