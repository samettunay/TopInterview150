using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class HIndex
    {
        public int Generate(int[] citations)
        {
            Array.Sort(citations, (a, b) => b - a);

            for (int h = 0; h < citations.Length; h++)
            {
                if (citations[h] < h + 1)
                {
                    return h;
                }
            }
            return citations.Length;
        }
    }
}
