using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class LengthOfLastWord
    {
        public int Generate(string s)
        {
            var splited = s.Split(' ');

            for (int i = splited.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(splited[i]))
                {
                    return splited[i].Length;
                }
            }
            return 0;
        }
    }
}
