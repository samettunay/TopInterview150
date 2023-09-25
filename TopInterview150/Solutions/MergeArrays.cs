using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class MergeArrays
    {
        public void Generate(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < m; i++)
            {
                nums1[i] = nums1[i];
            }

            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            Array.Sort(nums1);
        }
    }
}
