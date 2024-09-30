using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndGenerics
{
    public static class BoxingTask
    {
        public static object[] FillWithIntsAndFloats()
        {
            object[] nums = new object[50];

            Random rnd = new();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(0, 2) == 0 ? rnd.Next(0, 100) : (float)rnd.NextDouble();
            }

            return nums;
        }

        public static float Sum(object[] nums)
        {
            float sum = 0f;

            foreach (object num in nums)
            {
                sum += (float)num;
            }

            return sum;
        }
    }
}
