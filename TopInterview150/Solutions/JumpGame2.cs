using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class JumpGame2
    {
        public int Generate(int[] nums)
        {
            int n = nums.Length;
            int jumps = 0;
            int currentEnd = 0;
            int farthest = 0;

            for (int i = 0; i < n - 1; i++)
            {
                farthest = Math.Max(farthest, i + nums[i]);

                if (i == currentEnd)
                {
                    jumps++;
                    currentEnd = farthest;

                    if (currentEnd >= n - 1)
                    {
                        break;
                    }
                }
            }

            return jumps;
        }
    }
}
