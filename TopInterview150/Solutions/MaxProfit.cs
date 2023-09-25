using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class MaxProfit
    {
        public int Generate(int[] prices)
        {
            int maxProfit = 0;
            int minPrice = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else
                {
                    int potentialProfit = prices[i] - minPrice;
                    maxProfit = Math.Max(maxProfit, potentialProfit);
                }
            }
            return maxProfit;
        }
    }
}
