using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class MajorityElement
    {
        public int Generate(int[] nums)
        {
            int candidate = nums[0];
            int count = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                    count = 1;
                }
                else if (candidate == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return candidate;
        }
    }
}
