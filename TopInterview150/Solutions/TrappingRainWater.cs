using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class TrappingRainWater
    {
        public int Generate(int[] height)
        {
            int n = height.Length;
            if (n <= 2)
                return 0;

            int left = 0;
            int right = n - 1;
            int leftMax = 0;
            int rightMax = 0;
            int water = 0;

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] > leftMax)
                    {
                        leftMax = height[left];
                    }
                    else
                    {
                        water += leftMax - height[left];
                    }
                    left++;
                }
                else
                {
                    if (height[right] > rightMax)
                    {
                        rightMax = height[right];
                    }
                    else
                    {
                        water += rightMax - height[right];
                    }
                    right--;
                }
            }

            return water;
        }
    }
}
