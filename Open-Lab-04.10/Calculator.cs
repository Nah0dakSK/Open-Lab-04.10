using System;
using System.Linq;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public double Average(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }
            double result = sum / nums.Length;
            return result;
        }
    }
}
