using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = nums.Length / 4;

            //int[] row1 = new int[nums.Length / 2];
            //for (int i = 0; i < k; i++)
            //{
            //    row1[i] = nums[k - 1 - i];
            //}
            //for (int j = 0 + k; j < 2*k; j++)
            //{
            //    row1[j] = nums[5 * k - 1 - j];
            //}
            ////Console.WriteLine(string.Join(" ", row1));

            //int[] row2 = new int[nums.Length / 2];
            //for (int i = 0; i < 2*k; i++)
            //{
            //    row2[i] = nums[k+i];
            //}
            ////Console.WriteLine(string.Join(" ", row2));

            //int[] sum = new int[nums.Length / 2];
            //for (int i = 0; i < nums.Length/2; i++)
            //{
            //    sum[i] = row1[i] + row2[i];
            //}
            //Console.WriteLine(string.Join(" ", sum));


            int[] result = new int[nums.Length / 2];
            for (int i = 0; i < result.Length; i++)
            {
                if (i < k)
                {
                    result[i] = nums[k + i] + nums[k - i - 1];
                }
                else
                {
                    result[i] = nums[k + i] + nums[nums.Length + k - i - 1];
                }
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
