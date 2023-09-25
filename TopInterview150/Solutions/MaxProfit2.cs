using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class MaxProfit2
    {
        public int Generate(int[] prices)
        {
            int profit = 0;
            int minPrice = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (minPrice > prices[i])
                {
                    minPrice = prices[i];
                }
                else
                {
                    int currentProfit = prices[i] - minPrice;
                    profit += currentProfit;
                    minPrice = prices[i];
                }
            }
            return profit;
        }
    }
}
