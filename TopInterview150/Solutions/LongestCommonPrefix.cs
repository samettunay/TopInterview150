using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class LongestCommonPrefix
    {
        public string Generate(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            string commonPrefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(commonPrefix) != 0)
                {
                    commonPrefix = commonPrefix.Substring(0, commonPrefix.Length - 1);

                    if (commonPrefix.Length == 0)
                    {
                        return "";
                    }
                }
            }

            return commonPrefix;
        }
    }
}
