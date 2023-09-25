using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class RotateArray
    {
        public void Generate(int[] nums, int k)
        {
            int n = nums.Length;
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[(i + k) % n] = nums[i];
            }
            for (int i = 0; i < n; i++)
            {
                nums[i] = arr[i];
            }
        }
    }
}
