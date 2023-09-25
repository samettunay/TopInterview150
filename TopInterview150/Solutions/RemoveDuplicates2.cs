using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class RemoveDuplicates2
    {
        public int Generate(int[] nums)
        {
            int currentNum = int.MinValue;
            int count = 0;
            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == currentNum)
                {
                    count++;
                }
                else
                {
                    currentNum = nums[i];
                    count = 1;
                }

                if (count <= 2)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }
    }
}
