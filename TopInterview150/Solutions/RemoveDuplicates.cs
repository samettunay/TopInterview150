using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class RemoveDuplicates
    {
        public int Generate(int[] nums)
        {
            int uniqueCount = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[uniqueCount] = nums[i];
                    uniqueCount++;
                }
            }

            return uniqueCount;
        }
    }
}
