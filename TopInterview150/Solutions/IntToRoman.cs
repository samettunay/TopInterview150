using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class IntToRoman
    {
        public string Generate(int num)
        {
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < symbols.Length; i++)
            {
                while (num >= values[i])
                {
                    num -= values[i];
                    result.Append(symbols[i]);
                }
            }

            return result.ToString();
        }
    }
}
