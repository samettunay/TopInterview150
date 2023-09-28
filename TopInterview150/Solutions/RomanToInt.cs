using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class RomanToInt
    {
        public int Generate(string s)
        {
            var romanNumbers = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

            int result = 0;
            int temp = 0;

            foreach (char number in s)
            {
                if (temp >= romanNumbers[number])
                {
                    result += romanNumbers[number];
                }
                else
                {
                    result -= temp;
                    result += romanNumbers[number] - temp;
                }

                temp = romanNumbers[number];
            }

            return result;
        }
    }
}
