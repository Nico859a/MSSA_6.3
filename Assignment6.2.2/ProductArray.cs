using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._2._2
{
    internal class ProductArray
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] result = ProductExceptSelf(nums);

            Console.WriteLine("The product of the array except itself is:");
            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] leftProduct = new int[nums.Length];
            int[] rightProduct = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    leftProduct[i] = 1;
                }
                else
                {
                    leftProduct[i] = leftProduct[i - 1] * nums[i - 1];
                }
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i == nums.Length - 1)
                {
                    rightProduct[i] = 1;
                }
                else
                {
                    rightProduct[i] = rightProduct[i + 1] * nums[i + 1];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rightProduct[i] * leftProduct[i];

            }
            return nums;

        }
    }
}
