using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class ReverseWords
    {
        public string Generate(string s)
        {
            var splited = s.Split(' ');
            var result = splited.Where(x => !string.IsNullOrEmpty(x)).ToArray().Reverse();

            return string.Join(" ", result);
        }
    }
}
