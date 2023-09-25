using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class RemoveElement
    {
        public int Generate(int[] nums, int val)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                if (nums[left] == val)
                {
                    nums[left] = nums[right];
                    right -= 1;
                }
                else
                {
                    left += 1;
                }
            }
            return left;
        }
    }
}
